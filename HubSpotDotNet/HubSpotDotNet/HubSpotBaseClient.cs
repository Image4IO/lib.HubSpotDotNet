using System.Net.Http;

namespace HubSpotDotNet
{
    public class HubSpotBaseClient : IHubSpotBaseClient
    {
        protected HttpClient _client;
        protected static string APIKey;

        public HubSpotBaseClient(HttpClient client, string apiKey)
        {
            _client = client;
            APIKey = apiKey;
        }
    }
}
