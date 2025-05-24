using RestSharp;
using System;
using System.Threading.Tasks;

namespace Sms_Otomasyon_New
{
    internal class SmsSender
    {
        private const string apiKey = "0a7a18b684825de67f2f858b6b66b5b2-c4250933-1670-432a-a0a2-a0cfad63a15a";
        private const string baseUrl = "https://m3kpr9.api.infobip.com";
        public async Task SendSmsAsync(string toPhone, string messageText)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("/sms/2/text/advanced", Method.Post);

            request.AddHeader("Authorization", $"App {apiKey}");
            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(new
            {
                messages = new[]
                {
                    new
                    {
                        from = "InfoSMS", 
                        destinations = new[]
                        {
                            new { to = toPhone }
                        },
                        text = messageText
                    }
                }
            });

            var response = await client.ExecuteAsync(request);

            Console.WriteLine("Durum: " + response.StatusCode);
            Console.WriteLine("Yanıt: " + response.Content);
        }
    }
}
