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

        public string ConvertCodeToLanguageName(string code)
        {
            string languageName = "";
            //110 ngôn ngữ
            switch (code)
            {
                case "af": languageName = "Afrikaans"; break;
                case "sq": languageName = "Albanian"; break;
                case "am": languageName = "Amharic"; break;
                case "ar": languageName = "Arabic"; break;
                case "hy": languageName = "Armenian"; break;
                case "az": languageName = "Azerbaijani"; break;
                case "eu": languageName = "Basque"; break;
                case "be": languageName = "Belarusian"; break;
                case "bn": languageName = "Bengali"; break;
                case "bs": languageName = "Bosnian"; break;
                case "bg": languageName = "Bulgarian"; break;
                case "ca": languageName = "Catalan"; break;
                case "ceb": languageName = "Cebuano"; break;
                case "ny": languageName = "Chichewa"; break;
                case "zh-CN": languageName = "Chinese (Simplified)"; break;
                case "zh-TW": languageName = "Chinese (Traditional)"; break;
                case "co": languageName = "Corsican"; break;
                case "hr": languageName = "Croatian"; break;
                case "cs": languageName = "Czech"; break;
                case "da": languageName = "Danish"; break;
                case "nl": languageName = "Dutch"; break;
                case "en": languageName = "English"; break;
                case "eo": languageName = "Esperanto"; break;
                case "et": languageName = "Estonian"; break;
                case "tl": languageName = "Filipino"; break;
                case "fi": languageName = "Finnish"; break;
                case "fr": languageName = "French"; break;
                case "fy": languageName = "Frisian"; break;
                case "gl": languageName = "Galician"; break;
                case "ka": languageName = "Georgian"; break;
                case "de": languageName = "German"; break;
                case "el": languageName = "Greek"; break;
                case "gu": languageName = "Gujarati"; break;
                case "ht": languageName = "Haitian Creole"; break;
                case "ha": languageName = "Hausa"; break;
                case "haw": languageName = "Hawaiian"; break;
                case "iw": languageName = "Hebrew"; break;
                case "hi": languageName = "Hindi"; break;
                case "hmn": languageName = "Hmong"; break;
                case "hu": languageName = "Hungarian"; break;
                case "is": languageName = "Icelandic"; break;
                case "ig": languageName = "Igbo"; break;
                case "id": languageName = "Indonesian"; break;
                case "ga": languageName = "Irish"; break;
                case "it": languageName = "Italian"; break;
                case "ja": languageName = "Japanese"; break;
                case "jw": languageName = "Javanese"; break;
                case "kn": languageName = "Kannada"; break;
                case "kk": languageName = "Kazakh"; break;
                case "km": languageName = "Khmer"; break;
                case "rw": languageName = "Kinyarwanda"; break;
                case "ko": languageName = "Korean"; break;
                case "ku": languageName = "Kurdish (Kurmanji)"; break;
                case "ky": languageName = "Kyrgyz"; break;
                case "lo": languageName = "Lao"; break;
                case "la": languageName = "Latin"; break;
                case "lv": languageName = "Latvian"; break;
                case "lt": languageName = "Lithuanian"; break;
                case "lb": languageName = "Luxembourgish"; break;
                case "mk": languageName = "Macedonian"; break;
                case "mg": languageName = "Malagasy"; break;
                case "ms": languageName = "Malay"; break;
                case "ml": languageName = "Malayalam"; break;
                case "mt": languageName = "Maltese"; break;
                case "mi": languageName = "Maori"; break;
                case "mr": languageName = "Marathi"; break;
                case "mn": languageName = "Mongolian"; break;
                case "my": languageName = "Myanmar (Burmese)"; break;
                case "ne": languageName = "Nepali"; break;
                case "no": languageName = "Norwegian"; break;
                case "ny (Chichewa)": languageName = "Nyanja"; break;
                case "or": languageName = "Odia (Oriya)"; break;
                case "ps": languageName = "Pashto"; break;
                case "fa": languageName = "Persian"; break;
                case "pl": languageName = "Polish"; break;
                case "pt": languageName = "Portuguese"; break;
                case "pa": languageName = "Punjabi"; break;
                case "ro": languageName = "Romanian"; break;
                case "ru": languageName = "Russian"; break;
                case "sm": languageName = "Samoan"; break;
                case "gd": languageName = "Scots Gaelic"; break;
                case "sr": languageName = "Serbian"; break;
                case "st": languageName = "Sesotho"; break;
                case "sn": languageName = "Shona"; break;
                case "sd": languageName = "Sindhi"; break;
                case "si": languageName = "Sinhala (Sinhalese)"; break;
                case "sk": languageName = "Slovak"; break;
                case "sl": languageName = "Slovenian"; break;
                case "so": languageName = "Somali"; break;
                case "es": languageName = "Spanish"; break;
                case "su": languageName = "Sundanese"; break;
                case "sw": languageName = "Swahili"; break;
                case "sv": languageName = "Swedish"; break;
                case "tg": languageName = "Tajik"; break;
                case "ta": languageName = "Tamil"; break;
                case "tt": languageName = "Tatar"; break;
                case "te": languageName = "Telugu"; break;
                case "th": languageName = "Thai"; break;
                case "tr": languageName = "Turkish"; break;
                case "tk": languageName = "Turkmen"; break;
                case "uk": languageName = "Ukrainian"; break;
                case "ur": languageName = "Urdu"; break;
                case "ug": languageName = "Uyghur"; break;
                case "uz": languageName = "Uzbek"; break;
                case "vi": languageName = "Vietnamese"; break;
                case "cy": languageName = "Welsh"; break;
                case "xh": languageName = "Xhosa"; break;
                case "yi": languageName = "Yiddish"; break;
                case "yo": languageName = "Yoruba"; break;
                case "zu": languageName = "Zulu"; break;
                default: break;
            }

            return languageName;
        }

    }
}
