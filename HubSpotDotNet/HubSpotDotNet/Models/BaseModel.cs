using Newtonsoft.Json;
using System.Collections.Generic;

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
        public Engagement Engagement { get; set; }

        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

        [JsonProperty(PropertyName = "validationResults")]
        public List<ValidationResult> ValidationResults { get; set; }


    }
    public class ValidationResult
    {
        public bool isValid { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public string name { get; set; }
    }
    public class Engagement
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
