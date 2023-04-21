using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace KdgTranslationApp.BLL
{
    public class GoogleTranslator_API
    {
        public string TranslateText(string input, string sourceLanguage, string targetLanguage)
        {
            Convert_language_code cv = new Convert_language_code(); //khởi tạo cho hàm chuyển đổi mã ngôn ngữ

            string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", cv.ConvertLanguageNameToCode(sourceLanguage), cv.ConvertLanguageNameToCode(targetLanguage), Uri.EscapeUriString(input)); //URL của API Google Translate

            HttpClient httpClient = new HttpClient(); //Tạo một đối tượng HttpClient để gửi yêu cầu HTTP đến API Google Translate.

            string result = httpClient.GetStringAsync(url).Result;  //Gửi yêu cầu HTTP đến API Google Translate bằng cách gọi phương thức GetStringAsync trên đối tượng httpClient, truyền vào địa chỉ URL của API và đợi kết quả trả về bằng cách gọi phương thức Result.

            if (string.IsNullOrWhiteSpace(result))
            {
                throw new Exception("No response received from Google Translate API.");
            }

            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);//Sử dụng lớp JavaScriptSerializer để phân tích cú pháp chuỗi JSON phản hồi từ API Google Translate và chuyển đổi nó thành một danh sách các đối tượng động (dynamic) của các dòng và các phần tử trong mỗi dòng

            var translationItems = jsonData[0];//Lấy danh sách các dòng chứa phần dịch của câu đầu vào từ đối tượng JSON phân tích được.

            string translation = "";

            foreach (object item in translationItems)//Sử dụng một vòng lặp để ghép các phần tử trong danh sách các dòng phần dịch thành một chuỗi duy nhất.
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }

            if (translation.Length > 1) //Kiểm tra xem chuỗi phần dịch có dài hơn 1 ký tự hay không, nếu có thì xóa ký tự đầu tiên (ký tự trống) và trả về phần dịch. Nếu không, trả về chuỗi phần dịch không chỉnh sửa.
            {
                translation = translation.Substring(1);
            }
            return translation;
        }
    }
}
