using AutoCopySelectionText;
using GI.Screenshot;
using Gma.System.MouseKeyHook;
using KdgTranslationApp.BLL;
using RestSharp;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Tesseract;
using Clipboard = System.Windows.Forms.Clipboard;
using Hook = Gma.System.MouseKeyHook.Hook;
using Timer = System.Windows.Forms.Timer;

namespace KdgTranslationApp
{
    public partial class KdgTranslateApp : DevExpress.XtraEditors.XtraForm
    {
        public KdgTranslateApp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set sự kiện xảy ra khi form được load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        Convert_language_code cv = new Convert_language_code();
        SQLiteConnection con = DBConnect.GetDBConnection();
        DBConnect dbcon = new DBConnect();
        private void KdgTranslateApp_Load(object sender, EventArgs e)
        {
            //set ngôn ngữ mặc định
            cbb_quest.Text = "Detect";
            cbb_answer.Text = "Vietnamese";

            //set hotkey
            con.Open();
            //dbcon.CreateTable(con);
            //dbcon.Insert(con, "sf", "D");
            //dbcon.Insert(con, "orc_en", "E");
            //dbcon.Insert(con, "orc_vi", "V");


            using (SQLiteCommand cmd = new SQLiteCommand("select keys from Keys where idEvent = 'sf'", con))
            {
                string result = (string)cmd.ExecuteScalar();
                tb_ShowFormKey.Text = result;
            }

            using (SQLiteCommand cmd = new SQLiteCommand("select keys from Keys where idEvent = 'orc_en'", con))
            {
                string result = (string)cmd.ExecuteScalar();
                tb_TR_EnglishKey.Text = result;
            }

            using (SQLiteCommand cmd = new SQLiteCommand("select keys from Keys where idEvent = 'orc_vi'", con))
            {
                string result = (string)cmd.ExecuteScalar();
                tb_TR_VietnameseKey.Text = result;
            }

            if (tb_ShowFormKey.Text != "")
            {
                string sf = tb_ShowFormKey.Text;
                RegisterHotKey(this.Handle, 1, MOD_ALT, (int)(Keys)Enum.Parse(typeof(Keys), sf));
            }

            if (tb_TR_EnglishKey.Text != "")
            {
                string orc_en = tb_TR_EnglishKey.Text;
                RegisterHotKey(this.Handle, 2, MOD_ALT, (int)(Keys)Enum.Parse(typeof(Keys), orc_en));
            }

            if (tb_TR_VietnameseKey.Text != "")
            {
                string orc_vi = tb_TR_VietnameseKey.Text;
                RegisterHotKey(this.Handle, 3, MOD_ALT, (int)(Keys)Enum.Parse(typeof(Keys), orc_vi));
            }

            SubscribeGlobal();
        }

        /// <summary>
        /// Dịch văn bản trong tb_quest khi có sự kiện click và cho kết quả ra tb_answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        GoogleTranslator_API trans = new GoogleTranslator_API();
        private async void btnTranslate_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_quest.Text))//kiểm tra đầu vào
            {
                MessageBox.Show("Please enter text first");
                return;
            }

            else if (cbb_quest.Text == "Detect" && tb_quest.Text != "")
            {
                cbb_quest.Text = cv.ConvertCodeToLanguageName(await LanguageDetector.DetectLanguageAsync(tb_quest.Text, tb_answer.Text));
                tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
            }

            else
            {
                tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
            }
        }

        /// <summary>
        /// Phát hiện ngôn ngữ
        /// </summary>
        public static class LanguageDetector
        {
            public static async Task<string> DetectLanguageAsync(string text, string targetLanguage)
            {
                Convert_language_code cv = new Convert_language_code();
                using (var client = new HttpClient())
                {
                    // Tạo biến url chứa URL của API Google Translate để nhận diện ngôn ngữ, sử dụng biến cv để chuyển đổi ngôn ngữ đích thành mã ngôn ngữ
                    var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl={cv.ConvertLanguageNameToCode(targetLanguage)}&dt=t&q={Uri.EscapeDataString(text)}";

                    // Gửi yêu cầu HTTP GET tới URL của API Google Translate bằng đối tượng HttpClient
                    var response = await client.GetAsync(url);

                    // Kiểm tra xem phản hồi từ API có thành công hay không, nếu không thì ném ra một ngoại lệ
                    response.EnsureSuccessStatusCode();

                    // Đọc nội dung của phản hồi HTTP từ API Google Translate và lưu trữ nó trong biến content dưới dạng chuỗi
                    var content = await response.Content.ReadAsStringAsync();

                    // Tách chuỗi JSON phản hồi từ API Google Translate để lấy kết quả phân tích ngôn ngữ
                    var parts = content.Split('"');

                    // Nếu chuỗi JSON phản hồi chứa ít nhất 2 phần tử, trả về phần tử thứ hai là kết quả phân tích ngôn ngữ
                    if (parts.Length >= 2)
                    {
                        return parts[1];
                    }
                    // Nếu không, ném ra một ngoại lệ
                    else
                    {
                        throw new Exception("Cannot detect language.");
                    }
                }
            }
        }

        /// <summary>
        /// setting cho cn chụp ảnh và lấy văn bản từ ảnh
        /// </summary>
        /// <param name="bitmapSource"></param>
        /// <returns></returns>
        public static Bitmap ConvertToBitmap(BitmapSource bitmapSource)
        {
            // Lấy chiều rộng và chiều cao của ảnh
            var width = bitmapSource.PixelWidth;
            var height = bitmapSource.PixelHeight;

            // Tính toán kích thước mỗi hàng ảnh, theo đơn vị byte (stride)
            var stride = width * ((bitmapSource.Format.BitsPerPixel + 7) / 8);

            // Cấp phát một vùng nhớ không quản lý (unmanaged memory) với kích thước bằng với kích thước ảnh.
            // Biến memoryBlockPointer trỏ đến địa chỉ bắt đầu của vùng nhớ này.
            var memoryBlockPointer = Marshal.AllocHGlobal(height * stride);

            // Copy các pixel của ảnh vào vùng nhớ không quản lý đã cấp phát ở trên.
            // Vị trí đầu tiên của các pixel là tại vị trí (0,0) của ảnh (Int32Rect(0, 0, width, height)).
            // Tham số thứ hai của hàm CopyPixels là con trỏ trỏ đến vùng nhớ không quản lý đã cấp phát ở trên.
            // Tham số thứ ba là tổng kích thước của vùng nhớ đó (theo đơn vị byte).
            // Tham số thứ tư là kích thước của mỗi hàng ảnh (theo đơn vị byte).
            bitmapSource.CopyPixels(new Int32Rect(0, 0, width, height), memoryBlockPointer, height * stride, stride);

            // Tạo một đối tượng Bitmap mới với các thông số đã tính toán ở trên.
            // Đối tượng Bitmap này được tạo từ vùng nhớ không quản lý đã copy pixel từ ảnh gốc.
            // Lưu ý rằng đối tượng Bitmap được tạo ra này phải được giải phóng bằng cách gọi phương thức Dispose().
            var bitmap = new Bitmap(width, height, stride, PixelFormat.Format32bppArgb, memoryBlockPointer);

            // Trả về đối tượng Bitmap vừa tạo
            return bitmap;
        }

        private string OCR(Bitmap b, string languageCode)// Phương thức này nhận đầu vào là một hình ảnh bitmap và trả về một chuỗi đã được nhận diện ký tự
        {
            string res = "";
            // Tạo một đối tượng TesseractEngine để sử dụng thư viện OCR và đặt ngôn ngữ là tiếng Việt
            using (var engine = new TesseractEngine(@"./tessdata", languageCode, EngineMode.Default))
            {
                // Sử dụng đối tượng TesseractEngine để xử lý hình ảnh và trả về một đối tượng Page
                using (var page = engine.Process(b, PageSegMode.AutoOnly))
                    // Lấy chuỗi đã được nhận diện ký tự từ đối tượng Page và gán cho biến res
                    res = page.GetText();
            }
            // Trả về chuỗi đã được nhận diện ký tự
            return res;
        }

        private void vietnameseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Thu nhỏ cửa sổ hiện tại để có thể chụp ảnh màn hình
                this.WindowState = FormWindowState.Minimized;
                // Dừng chương trình trong 0.5 giây để đợi cửa sổ thu nhỏ hoàn thành
                Thread.Sleep(500);
                // Chụp một ảnh vùng màn hình được chọn và chuyển đổi thành định dạng bitmap
            }
            try
            {
                Unsubscribe();
                Bitmap bitmap = ConvertToBitmap(Screenshot.CaptureRegion());
                // Nhận diện ký tự trong ảnh bitmap sử dụng thư viện OCR và lưu kết quả vào biến ocrResult
                string ocrResult = OCR(bitmap, "vie");
                // Hiển thị kết quả nhận diện ký tự lên TextBox
                tb_quest.Text = ocrResult;
                Subscribe(Hook.GlobalEvents());
                if (cbtn_removeSpace.CheckState != CheckState.Unchecked)
                {
                    cbtn_removeSpace_CheckStateChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Khôi phục kích thước cửa sổ hiện tại
            ShowHiddenForm(this);
        }

        private void englishToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Thu nhỏ cửa sổ hiện tại để có thể chụp ảnh màn hình
                this.WindowState = FormWindowState.Minimized;
                // Dừng chương trình trong 0.5 giây để đợi cửa sổ thu nhỏ hoàn thành
                Thread.Sleep(500);
                // Chụp một ảnh vùng màn hình được chọn và chuyển đổi thành định dạng bitmap
            }
            try
            {
                Unsubscribe();
                Bitmap bitmap = ConvertToBitmap(Screenshot.CaptureRegion());
                // Nhận diện ký tự trong ảnh bitmap sử dụng thư viện OCR và lưu kết quả vào biến ocrResult
                string ocrResult = OCR(bitmap, "eng");
                // Hiển thị kết quả nhận diện ký tự lên TextBox
                tb_quest.Text = ocrResult;
                Subscribe(Hook.GlobalEvents());
                if (cbtn_removeSpace.CheckState != CheckState.Unchecked)
                {
                    cbtn_removeSpace_CheckStateChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Khôi phục kích thước cửa sổ hiện tại
            ShowHiddenForm(this);
        }

        private void cbtnCamera_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip_CameraIcon.Show(cbtnCamera, e.Location);
            }
        }

        /// <summary>
        /// Set sự kiện tự động dịch khi click vào checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private async void cbtn_autoTranslate_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_quest.Text != "")
            {
                cbb_quest.Text = cv.ConvertCodeToLanguageName(await LanguageDetector.DetectLanguageAsync(tb_quest.Text, tb_answer.Text));
                tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
            }
        }

        private Timer timer = new Timer(); // Khai báo một đối tượng Timer
        private string lastText = ""; // Khai báo một chuỗi để lưu trữ văn bản cuối cùng được nhập vào ô textbox
        private async void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Dừng Timer để tránh bị gọi lại trước khi xử lý hoàn tất
            if (lastText != "")
            {
                if (tb_quest.Text != "")
                {
                    if (cbb_quest.Text == "Detect")
                    {
                        cbb_quest.Text = cv.ConvertCodeToLanguageName(await LanguageDetector.DetectLanguageAsync(tb_quest.Text, tb_answer.Text));
                        tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
                    }
                    else
                    {
                        tb_answer.Text = trans.TranslateText(lastText, cbb_quest.Text, cbb_answer.Text); // Nếu văn bản cuối cùng khác rỗng, dịch nó sang ngôn ngữ được chọn và đưa ra ô textbox
                    }
                }
            }
        }

        private void tb_quest_TextChanged(object sender, EventArgs e)
        {
            if (cbtn_autoTranslate.Checked) // Nếu ô radio button "translate" được chọn
            {
                lastText = tb_quest.Text; // Lưu trữ văn bản cuối cùng được nhập vào ô textbox
                timer.Stop(); // Dừng Timer trước khi đặt lại thời gian
                timer.Tick -= Timer_Tick; // Loại bỏ Tick đã được thêm vào trước đó (nếu có)
                timer.Tick += Timer_Tick; // Thêm phương thức Timer_Tick vào danh sách các Tick được thực hiện khi Timer chạy
                timer.Interval = 1500; // Thiết lập thời gian trì hoãn cho Timer là 1500ms
                timer.Start(); // Khởi động Timer
            }
        }
        /// <summary>
        /// set sự kiện đổi chỗ text của 2 cbb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbtnSwitch_Click_1(object sender, EventArgs e)
        {
            if (cbb_quest.Text != "Detect")
            {
                //đổi chỗ 2 văn bản của 2 combobox
                string temp = cbb_quest.Text;
                cbb_quest.Text = cbb_answer.Text;
                cbb_answer.Text = temp;

                if (tb_quest.Text != "")//nếu tb_quest khác rỗng sẽ tự dịch
                    tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
            }
        }

        /// <summary>
        /// set sự kiện làm trống các ô textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbtnReset_Click_1(object sender, EventArgs e)
        {
            //reset về rỗng
            tb_quest.Text = "";
            tb_answer.Text = "";
            cbb_answer.Text = "Vietnamese";
            cbb_quest.Text = "Detect";
        }

        /// <summary>
        /// set sự kiện đọc văn bản trong textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        SpeechSynthesizer voice = new SpeechSynthesizer();
        private void cbtn_questSpeak_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (voice.State == SynthesizerState.Ready)
                {
                    voice.SelectVoiceByHints(VoiceGender.Male);//chọn giọng nói
                    voice.SpeakAsync(tb_quest.Text);//đọc văn bản trong tb_quest
                }
                if (voice.State == SynthesizerState.Speaking)
                {
                    voice.SpeakAsyncCancelAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);//show lỗi
            }
        }

        private void cbtn_answerSpeak_Click_1(object sender, EventArgs e)
        {
            string apiKey = "f8p9cIrz7OXjS1Yi6dAQdce5FwQ30n1A";
            string url = "https://api.zalo.ai/v1/tts/synthesize";
            int speakerId = 2; // default speaker
            float speed = 1.0f; // default speed
            int quality = 0; // default quality
            int encodeType = 0; // default encoding

            string inputText = tb_answer.Text;

            // tạo request
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("apikey", apiKey);
            request.AddParameter("input", inputText);
            request.AddParameter("speaker_id", speakerId);
            request.AddParameter("speed", speed);
            request.AddParameter("quality", quality);
            request.AddParameter("encode_type", encodeType);

            // gửi request
            IRestResponse response = client.Execute(request);

            // kiểm tra có nhận phản hồi thành công không
            if (response.IsSuccessful)
            {
                // đọc phản hồi và nhận url âm thanh
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                string audioUrl = data.data.url;

                //show ra xem audioUrl trả về từ API
                MessageBox.Show("Url API response: " + audioUrl, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // tải audio and play
                using (var wc = new System.Net.WebClient())
                {
                    byte[] audioBytes = wc.DownloadData(audioUrl);
                    MemoryStream ms = new MemoryStream(audioBytes);
                    var audio = new SoundPlayer(ms);
                    audio.Play();
                }
            }
            else //Nếu không thì show nội dung phản hồi lỗi
            {
                MessageBox.Show(response.Content, "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            request.Parameters.Clear();
        }

        /// <summary>
        /// set sự kiện nhập vào textbox bằng mic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void recognier_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)// Sự kiện này được gọi khi hệ thống nhận dạng giọng nói thành công
        {
            tb_quest.Text += e.Result.Text + "\r\n";// Thêm kết quả nhận dạng giọng nói vào cuối của TextBox và xuống dòng
        }

        private void cbtnVoiceInput_Click_1(object sender, EventArgs e)
        {
            SpeechRecognitionEngine recognier = new SpeechRecognitionEngine();//khởi tạo đối tượng nhân diện và xử lý ngôn ngữ nói
            if (recognier.AudioState != AudioState.Silence)
            {
                recognier.SetInputToDefaultAudioDevice();//thiết lập thiết bị mặc định nhận âm thanh đầu vào

                Grammar grammar = new DictationGrammar();// tạo đối tượng grammar thuộc lớp DictationGrammar - là một lớp con của lớp Grammar và đại diện cho một bộ từ điển cho phép người dùng nói bất kỳ từ hoặc cụm từ nào mà hệ thống nhận diện giọng nói có thể xử lý.

                recognier.LoadGrammar(grammar);//tải bộ từ điển grammar vào đối tượng recognier để sử dụng cho việc nhận diện giọng nói.

                recognier.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognier_SpeechRecognized);//gán một phương thức xử lý sự kiện recognier_SpeechRecognized vào sự kiện SpeechRecognized của đối tượng recognier. Phương thức này được gọi khi hệ thống nhận diện giọng nói thành công.

                recognier.RecognizeAsync(RecognizeMode.Multiple);//bắt đầu một phiên nhận dạng giọng nói bằng cách sử dụng phương thức RecognizeAsync. Tham số RecognizeMode.Multiple được sử dụng để cho phép việc nhận dạng liên tục của nhiều cụm từ được phát hiện trong khi phiên nhận dạng giọng nói đang diễn ra.
            }
            if (recognier.AudioState == AudioState.Speech)
            {
                recognier.RecognizeAsyncStop(); // Dừng việc nhận diện giọng nói
                recognier.Dispose(); // Giải phóng tài nguyên
            }
        }

        /// <summary>
        /// set sự kiện cho contentMenuTrip của NotifyIcon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kdgTranslateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// set sự kiện cho notifyIcon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_Taskbar_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Chặn sự kiện FormClosing.
                this.Hide(); // Ẩn Form đi.
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        private bool IsFormHidden(Form form)// hàm kiểm tra form có đang bị ẩn ko?
        {
            return form.WindowState == FormWindowState.Minimized || !form.Visible;
        }

        private void ShowHiddenForm(Form form)
        {
            if (IsFormHidden(form))//nếu form đang ẩn thì show lên
            {
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void englishToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.englishToolStripMenuItem.PerformClick();
        }

        private void vietnameseToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.vietnameseToolStripMenuItem.PerformClick();
        }

        /// <summary>
        /// set sự kiện dịch sau khi thay đổi ngôn ngữ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void cbb_quest_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tb_quest.Text != "")
            {
                if (cbb_quest.Text == "Detect")
                {
                    cbb_quest.Text = cv.ConvertCodeToLanguageName(await LanguageDetector.DetectLanguageAsync(tb_quest.Text, tb_answer.Text));
                    tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
                }
                else
                    tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text); // Nếu văn bản cuối cùng khác rỗng, dịch nó sang ngôn ngữ được chọn và đưa ra ô textbox
            }
        }

        private void cbb_answer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tb_quest.Text != "")//nếu tb_quest khác rỗng sẽ tự dịch
                tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
        }

        /// <summary>
        /// Đăng kí phím tắt
        /// </summary>
        /// <param name="m"></param>
        /// 
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
            {
                if (IsFormHidden(this))//Nếu form đang ẩn thì kích hoạt sự kiện lắng nghe bấm phím
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                }
                this.Activate();
            }

            if (m.Msg == WM_HOTKEY && (int)m.WParam == 2)
            {
                this.englishToolStripMenuItem.PerformClick();
            }

            if (m.Msg == WM_HOTKEY && (int)m.WParam == 3)
            {
                this.vietnameseToolStripMenuItem.PerformClick();
            }
            base.WndProc(ref m);
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int WM_HOTKEY = 0x0312;
        const int MOD_ALT = 0x0001;

        /// <summary>
        /// Lưu phím tắt vào csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tb_ShowFormKey.Text != "")
            {
                dbcon.Update("sf", tb_ShowFormKey.Text);
                UnregisterHotKey(this.Handle, 1);
                string hotKey = tb_ShowFormKey.Text;
                RegisterHotKey(this.Handle, 1, MOD_ALT, (int)(Keys)Enum.Parse(typeof(Keys), hotKey));
            }

            if (tb_TR_EnglishKey.Text != "")
            {
                dbcon.Update("orc_en", tb_TR_EnglishKey.Text);
                UnregisterHotKey(this.Handle, 2);
                string hotKey = tb_TR_EnglishKey.Text;
                RegisterHotKey(this.Handle, 2, MOD_ALT, (int)(Keys)Enum.Parse(typeof(Keys), hotKey));
            }

            if (tb_TR_VietnameseKey.Text != "")
            {
                dbcon.Update("orc_vi", tb_TR_VietnameseKey.Text);
                UnregisterHotKey(this.Handle, 3);
                string hotKey = tb_TR_VietnameseKey.Text;
                RegisterHotKey(this.Handle, 3, MOD_ALT, (int)(Keys)Enum.Parse(typeof(Keys), hotKey));
            }
        }

        /// <summary>
        /// Copy văn bản được bôi đen vào textbox
        /// </summary>
        private void SubscribeGlobal()
        {
            Unsubscribe();
            Subscribe(Hook.GlobalEvents());
        }
        private IKeyboardMouseEvents m_Events;
        private void Subscribe(IKeyboardMouseEvents events)
        {
            m_Events = events;
            m_Events.MouseDragStarted += OnMouseDragStarted;
            m_Events.MouseDragFinished += OnMouseDragFinished;
        }

        private void Unsubscribe()
        {
            if (m_Events == null) return;
            m_Events.MouseDragStarted -= OnMouseDragStarted;
            m_Events.MouseDragFinished -= OnMouseDragFinished;
            m_Events.Dispose();
            m_Events = null;
        }

        private void OnMouseDragStarted(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void OnMouseDragFinished(object sender, MouseEventArgs e)
        {
            try
            {
                SendKeys.SendWait("^c");
                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();
                    if (!string.IsNullOrWhiteSpace(clipboardText))
                        tb_quest.Text = Clipboard.GetText();
                }

                if (cbtn_removeSpace.CheckState != CheckState.Unchecked)
                {
                    cbtn_removeSpace_CheckStateChanged(sender, e);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// đóng kết nối SQLite khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KdgTranslateApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        /// <summary>
        /// xóa khoảng trắng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbtn_removeSpace_CheckStateChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu TextBox không rỗng
            if (!string.IsNullOrEmpty(tb_quest.Text))
            {
                // Thay thế tất cả các khoảng cách liên tiếp bằng 1 khoảng cách
                tb_quest.Text = System.Text.RegularExpressions.Regex.Replace(tb_quest.Text, @"\s+", " ");
            }
        }

        
    }
}
