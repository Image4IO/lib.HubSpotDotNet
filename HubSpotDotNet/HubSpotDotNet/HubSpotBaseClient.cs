using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HubSpotDotNet
{
    public class HubSpotBaseClient : IHubSpotBaseClient
    {
        protected HttpClient _client;
        public HubSpotBaseClient(HttpClient client)
        {
            _client = client;
        }
    }
}
