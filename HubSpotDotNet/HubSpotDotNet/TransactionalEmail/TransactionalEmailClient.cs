using HubSpotDotNet.Contacts.Models;
using HubSpotDotNet.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System;
using HubSpotDotNet.TransactionalEmail.Models;

namespace HubSpotDotNet.TransactionalEmail
{
    public class TransactionalEmailClient : HubSpotBaseClient, ITransactionalEmailClient
    {
        public TransactionalEmailClient(HttpClient client, string apiKey) : base(client, apiKey)
        {
        }

        public bool SendSingleEmail(SendSingleEmailRequestModel model) => SendSingleEmailAsync(model).GetAwaiter().GetResult();

        public async Task<bool> SendSingleEmailAsync(SendSingleEmailRequestModel model)
        {

            string json = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(json, Encoding.Default, "application/json");


            var result = await _client.PostAsync("email/public/v1/singleEmail/send?hapikey=" + APIKey, stringContent);
            var jsonResponse = await result.Content.ReadAsStringAsync();


            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                var response = JsonConvert.DeserializeObject<BaseModel>(jsonResponse);
                if (response?.ValidationResults?.Where(v => v.isValid == false).Count() > 0)
                {
                    throw new ValidationException(response.ValidationResults.Where(v => v.isValid == false).First().message);
                }
                else if(response != null && response.Message != null)
                {
                    throw new Exception(response.Message);
                }
                else
                {
                    throw new Exception("Unkown Error");
                }
            }
        }

      
    }
}
