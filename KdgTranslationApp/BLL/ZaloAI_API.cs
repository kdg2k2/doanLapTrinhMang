using RestSharp;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace KdgTranslationApp.BLL
{
    public class ZaloAI_API
    {
        SoundPlayer player = null;

        public void PlaySoundFromUrl(string url)
        {
            using (var wc = new WebClient())
            {
                byte[] data = wc.DownloadData(url);
                using (var ms = new MemoryStream(data))
                {
                    player = new SoundPlayer(ms);
                    player.Stream.Seek(0, SeekOrigin.Begin);
                    player.Play();
                }
            }
        }

        public void StopSound()
        {
            if (player != null)
            {
                player.Stop();
            }
        }

        public string GetAudioUrl(string text)
        {
            string apiKey = "f8p9cIrz7OXjS1Yi6dAQdce5FwQ30n1A";
            string url = "https://api.zalo.ai/v1/tts/synthesize";
            int speakerId = 4; // default speaker
            float speed = 1.0f; // default speed
            int quality = 0; // default quality
            int encodeType = 0; // default encoding

            string inputText = text;

            // create request
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("apikey", apiKey);
            request.AddParameter("input", inputText);
            request.AddParameter("speaker_id", speakerId);
            request.AddParameter("speed", speed);
            request.AddParameter("quality", quality);
            request.AddParameter("encode_type", encodeType);

            // execute request
            IRestResponse response = client.Execute(request);

            // check for errors
            if (response.IsSuccessful)
            {
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                string audioUrl = data.data.url;
                return audioUrl;
            }
            else
            {
                MessageBox.Show(response.Content, "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
