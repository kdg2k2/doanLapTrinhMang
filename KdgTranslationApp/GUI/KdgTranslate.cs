using GI.Screenshot;
using KdgTranslationApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Tesseract;
using Timer = System.Windows.Forms.Timer;
using System.Speech;
using System.Speech.Synthesis;


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
        private void KdgTranslateApp_Load(object sender, EventArgs e)
        {
            //set ngôn ngữ mặc định
            cbb_quest.Text = "English";
            cbb_answer.Text = "Vietnamese";
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

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thu nhỏ cửa sổ hiện tại để có thể chụp ảnh màn hình
            this.WindowState = FormWindowState.Minimized;
            // Dừng chương trình trong 0.5 giây để đợi cửa sổ thu nhỏ hoàn thành
            Thread.Sleep(500);
            // Chụp một ảnh vùng màn hình được chọn và chuyển đổi thành định dạng bitmap
            try
            {
                Bitmap bitmap = ConvertToBitmap(Screenshot.CaptureRegion());
                // Nhận diện ký tự trong ảnh bitmap sử dụng thư viện OCR và lưu kết quả vào biến ocrResult
                string ocrResult = OCR(bitmap, "vie");
                // Hiển thị kết quả nhận diện ký tự lên TextBox
                tb_quest.Text = ocrResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Khôi phục kích thước cửa sổ hiện tại
            this.WindowState = FormWindowState.Normal;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thu nhỏ cửa sổ hiện tại để có thể chụp ảnh màn hình
            this.WindowState = FormWindowState.Minimized;
            // Dừng chương trình trong 0.5 giây để đợi cửa sổ thu nhỏ hoàn thành
            Thread.Sleep(500);
            // Chụp một ảnh vùng màn hình được chọn và chuyển đổi thành định dạng bitmap
            try
            {
                Bitmap bitmap = ConvertToBitmap(Screenshot.CaptureRegion());
                // Nhận diện ký tự trong ảnh bitmap sử dụng thư viện OCR và lưu kết quả vào biến ocrResult
                string ocrResult = OCR(bitmap, "eng");
                // Hiển thị kết quả nhận diện ký tự lên TextBox
                tb_quest.Text = ocrResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Khôi phục kích thước cửa sổ hiện tại
            this.WindowState = FormWindowState.Normal;
        }

        private void cbtnCamera_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip_Camera.Show(cbtnCamera, e.Location);
            }
        }
        /// <summary>
        /// Dịch văn bản trong tb_quest khi có sự kiện click và cho kết quả ra tb_answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        GoogleTranslator_API trans = new GoogleTranslator_API();
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_quest.Text))//kiểm tra đầu vào
            {
                MessageBox.Show("Please enter text first");
                return;
            }

            else
            {
                tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
            }
        }

        /// <summary>
        /// Set sự kiện tự động dịch khi click vào radiobtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private bool isRadioButtonChecked = false;//tắt nút Dịch khi kích hoạt radio button
        private void rbtn_AutoTranslate_Click(object sender, EventArgs e)
        {
            if (isRadioButtonChecked)
            {
                rbtn_AutoTranslate.Checked = false;
                isRadioButtonChecked = false;
                btnTranslate.Enabled = true;
            }
            else
            {
                rbtn_AutoTranslate.Checked = true;
                isRadioButtonChecked = true;
                btnTranslate.Enabled = false;
                if (tb_quest.Text != "")
                    tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
            }
        }

        private Timer timer = new Timer(); // Khai báo một đối tượng Timer
        private string lastText = ""; // Khai báo một chuỗi để lưu trữ văn bản cuối cùng được nhập vào ô textbox
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Dừng Timer để tránh bị gọi lại trước khi xử lý hoàn tất
            if (lastText != "")
            {
                tb_answer.Text = trans.TranslateText(lastText, cbb_quest.Text, cbb_answer.Text); // Nếu văn bản cuối cùng khác rỗng, dịch nó sang ngôn ngữ được chọn và đưa ra ô textbox
            }
        }

        private void tb_quest_TextChanged(object sender, EventArgs e)
        {
            if (rbtn_AutoTranslate.Checked) // Nếu ô radio button "translate" được chọn
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
        private void cbtnSwitch_Click(object sender, EventArgs e)
        {
            //đổi chỗ 2 văn bản của 2 combobox
            string temp = cbb_quest.Text;
            cbb_quest.Text = cbb_answer.Text;
            cbb_answer.Text = temp;

            if (tb_quest.Text != "")//nếu tb_quest khác rỗng sẽ tự dịch
                tb_answer.Text = trans.TranslateText(tb_quest.Text, cbb_quest.Text, cbb_answer.Text);
        }

        /// <summary>
        /// set sự kiện làm trống các ô textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbtnReset_Click(object sender, EventArgs e)
        {
            //reset về rỗng
            tb_quest.Text = "";
            tb_answer.Text = "";
            cbb_answer.Text = "Vietnamese";
            cbb_quest.Text = "English";
        }

        /// <summary>
        /// set sự kiện đọc văn bản trong textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        SpeechSynthesizer voice = new SpeechSynthesizer();
        private void cbtn_questSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                voice.SelectVoiceByHints(VoiceGender.Male);//chọn giọng nói

                voice.SpeakAsync(tb_quest.Text);//đọc văn bản trong tb_quest
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show lỗi
            }
        }

        private void cbtn_answerSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                voice.SelectVoiceByHints(VoiceGender.Female);//chọn giọng nói

                voice.SpeakAsync(tb_answer.Text);//đọc văn bản trong tb_quest
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show lỗi
            }
        }
    }
}
