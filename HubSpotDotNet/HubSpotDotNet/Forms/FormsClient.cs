using HubSpotDotNet.Forms.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HubSpotDotNet.Forms
{
    public class FormsClient : HubSpotBaseClient, IFormsClient
    {
        public FormsClient(HttpClient client, string apiKey) : base(client, apiKey)
        {


        }

        public SubmitDataToAFormModel SubmitDataToAForm() => SubmitDataToAFormAsync().GetAwaiter().GetResult();

        public async Task<SubmitDataToAFormModel> SubmitDataToAFormAsync()
        {
            var model = new SubmitDataToAFormModel
            {
                Fields = new System.Collections.Generic.List<SubmitDataToAFormModel.Field>
                {
                    new SubmitDataToAFormModel.Field
                    {
                        Name = "email",
                        Value = "test@image4.io"
                    },
                    new SubmitDataToAFormModel.Field
                    {
                        Name = "firstname",
                        Value = "Test"
                    }
                },
                SubmittedAt = new TimeSpan(DateTime.Now.Ticks)
            };

            string json = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(json, System.Text.Encoding.Default, "application/json");


            var result = await _client.PostAsync("/submissions/v3/integration/submit/6034943/" + Guid.NewGuid().ToString(), stringContent);
            var jsonResponse = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<SubmitDataToAFormModel>(jsonResponse);

            return response;
        }
    }
}
