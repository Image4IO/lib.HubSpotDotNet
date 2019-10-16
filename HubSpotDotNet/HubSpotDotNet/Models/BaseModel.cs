using Newtonsoft.Json;

namespace HubSpotDotNet.Models
{
    public class BaseModel
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty(PropertyName = "engagement")]
        public EngagementClass Engagement { get; set; }


        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }


        public class EngagementClass
        {

            [JsonProperty(PropertyName = "__invalid_name__shhkey-v1")]
            public string InvalidNameSHHKeyV1 { get; set; }

            [JsonProperty(PropertyName = "hapikey")]
            public string Hapikey { get; set; }

            [JsonProperty(PropertyName = "__invalid_name__oauth-token")]
            public string InvalidNameOAuthToken { get; set; }

            [JsonProperty(PropertyName = "__invalid_name__internal-cookie")]
            public string InvalidNameInternalCookie { get; set; }

            [JsonProperty(PropertyName = "__invalid_name__app-cookie")]
            public string InvalidNameAppCookie { get; set; }

        }
    }
}
