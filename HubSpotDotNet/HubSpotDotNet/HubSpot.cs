using HubSpotDotNet.Contacts;
using HubSpotDotNet.Forms;
using HubSpotDotNet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HubSpotDotNet
{
    public class HubSpot : IHubSpot
    {
        protected static readonly HttpClient client = new HttpClient();
        protected static string APIKey;
        public IContactsClient Contacts;
        public IFormsClient Forms;

        public HubSpot()
        {
            string apiKey = Environment.GetEnvironmentVariable("HubSpotApiKey");
            Constructor(apiKey);
        }

        public HubSpot(string apiKey)
        {
            Constructor(apiKey);
        }

        private void Constructor(string apiKey)
        {
            APIKey = apiKey;

            Contacts = new ContactsClient(client, apiKey);
            Forms = new FormsClient(client, apiKey);

            client.BaseAddress = new Uri("https://api.hubapi.com");
        }

        public GetAccountDetailsModel GetAccountDetails() => GetAccountDetailsAsync().GetAwaiter().GetResult();

        public async Task<GetAccountDetailsModel> GetAccountDetailsAsync()
        {
            var result = await client.GetAsync("integrations/v1/me?hapikey=" + APIKey);
            var jsonResponse = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<GetAccountDetailsModel>(jsonResponse);

            return response;
        }

        public CheckDailyApiUsageModel CheckDailyApiUsage() => CheckDailyApiUsageAsync().GetAwaiter().GetResult();

        public async Task<CheckDailyApiUsageModel> CheckDailyApiUsageAsync()
        {
            var result = await client.GetAsync("integrations/v1/limit/daily?hapikey=" + APIKey);
            var jsonResponse = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<List<CheckDailyApiUsageModel>>(jsonResponse);

            return response.First();
        }
    }
}
