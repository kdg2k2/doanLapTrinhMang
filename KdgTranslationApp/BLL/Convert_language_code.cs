using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdgTranslationApp.BLL
{
    public class Convert_language_code
    {
        public string ConvertLanguageNameToCode(string languageName)
        {
            string code = "";
            //110 ngôn ngữ
            switch (languageName)
            {
                case "Afrikaans": code = "af"; break;
                case "Albanian": code = "sq"; break;
                case "Amharic": code = "am"; break;
                case "Arabic": code = "ar"; break;
                case "Armenian": code = "hy"; break;
                case "Azerbaijani": code = "az"; break;
                case "Basque": code = "eu"; break;
                case "Belarusian": code = "be"; break;
                case "Bengali": code = "bn"; break;
                case "Bosnian": code = "bs"; break;
                case "Bulgarian": code = "bg"; break;
                case "Catalan": code = "ca"; break;
                case "Cebuano": code = "ceb"; break;
                case "Chichewa": code = "ny"; break;
                case "Chinese (Simplified)": code = "zh-CN"; break;
                case "Chinese (Traditional)": code = "zh-TW"; break;
                case "Corsican": code = "co"; break;
                case "Croatian": code = "hr"; break;
                case "Czech": code = "cs"; break;
                case "Danish": code = "da"; break;
                case "Dutch": code = "nl"; break;
                case "English": code = "en"; break;
                case "Esperanto": code = "eo"; break;
                case "Estonian": code = "et"; break;
                case "Filipino": code = "tl"; break;
                case "Finnish": code = "fi"; break;
                case "French": code = "fr"; break;
                case "Frisian": code = "fy"; break;
                case "Galician": code = "gl"; break;
                case "Georgian": code = "ka"; break;
                case "German": code = "de"; break;
                case "Greek": code = "el"; break;
                case "Gujarati": code = "gu"; break;
                case "Haitian Creole": code = "ht"; break;
                case "Hausa": code = "ha"; break;
                case "Hawaiian": code = "haw"; break;
                case "Hebrew": code = "iw"; break;
                case "Hindi": code = "hi"; break;
                case "Hmong": code = "hmn"; break;
                case "Hungarian": code = "hu"; break;
                case "Icelandic": code = "is"; break;
                case "Igbo": code = "ig"; break;
                case "Indonesian": code = "id"; break;
                case "Irish": code = "ga"; break;
                case "Italian": code = "it"; break;
                case "Japanese": code = "ja"; break;
                case "Javanese": code = "jw"; break;
                case "Kannada": code = "kn"; break;
                case "Kazakh": code = "kk"; break;
                case "Khmer": code = "km"; break;
                case "Kinyarwanda": code = "rw"; break;
                case "Korean": code = "ko"; break;
                case "Kurdish (Kurmanji)": code = "ku"; break;
                case "Kyrgyz": code = "ky"; break;
                case "Lao": code = "lo"; break;
                case "Latin": code = "la"; break;
                case "Latvian": code = "lv"; break;
                case "Lithuanian": code = "lt"; break;
                case "Luxembourgish": code = "lb"; break;
                case "Macedonian": code = "mk"; break;
                case "Malagasy": code = "mg"; break;
                case "Malay": code = "ms"; break;
                case "Malayalam": code = "ml"; break;
                case "Maltese": code = "mt"; break;
                case "Maori": code = "mi"; break;
                case "Marathi": code = "mr"; break;
                case "Mongolian": code = "mn"; break;
                case "Myanmar (Burmese)": code = "my"; break;
                case "Nepali": code = "ne"; break;
                case "Norwegian": code = "no"; break;
                case "Nyanja (Chichewa)": code = "ny"; break;
                case "Odia (Oriya)": code = "or"; break;
                case "Pashto": code = "ps"; break;
                case "Persian": code = "fa"; break;
                case "Polish": code = "pl"; break;
                case "Portuguese": code = "pt"; break;
                case "Punjabi": code = "pa"; break;
                case "Romanian": code = "ro"; break;
                case "Russian": code = "ru"; break;
                case "Samoan": code = "sm"; break;
                case "Scots Gaelic": code = "gd"; break;
                case "Serbian": code = "sr"; break;
                case "Sesotho": code = "st"; break;
                case "Shona": code = "sn"; break;
                case "Sindhi": code = "sd"; break;
                case "Sinhala (Sinhalese)": code = "si"; break;
                case "Slovak": code = "sk"; break;
                case "Slovenian": code = "sl"; break;
                case "Somali": code = "so"; break;
                case "Spanish": code = "es"; break;
                case "Sundanese": code = "su"; break;
                case "Swahili": code = "sw"; break;
                case "Swedish": code = "sv"; break;
                case "Tajik": code = "tg"; break;
                case "Tamil": code = "ta"; break;
                case "Tatar": code = "tt"; break;
                case "Telugu": code = "te"; break;
                case "Thai": code = "th"; break;
                case "Turkish": code = "tr"; break;
                case "Turkmen": code = "tk"; break;
                case "Ukrainian": code = "uk"; break;
                case "Urdu": code = "ur"; break;
                case "Uyghur": code = "ug"; break;
                case "Uzbek": code = "uz"; break;
                case "Vietnamese": code = "vi"; break;
                case "Welsh": code = "cy"; break;
                case "Xhosa": code = "xh"; break;
                case "Yiddish": code = "yi"; break;
                case "Yoruba": code = "yo"; break;
                case "Zulu": code = "zu"; break;
                default: break;
            }

            return code;
        }

    }
}
