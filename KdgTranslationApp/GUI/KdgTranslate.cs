using GI.Screenshot;
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

namespace KdgTranslationApp
{
    public partial class KdgTranslateApp : DevExpress.XtraEditors.XtraForm
    {
        public KdgTranslateApp()
        {
            InitializeComponent();
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
    }
}
