using HubSpotDotNet.Contacts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HubSpotDotNet
{
    public class HubSpot : IHubSpot
    {
        protected static readonly HttpClient client = new HttpClient();
        public IContactsClient contacts;

        public HubSpot()
        {
            Constructor("");
        }

        public HubSpot(string apiKey)
        {
            Constructor(apiKey);
        }

        private void Constructor(string apiKey)
        {
            contacts = new ContactsClient(client);

            client.BaseAddress = new Uri("https://api.hubapi.com");

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
        }
    }
}
