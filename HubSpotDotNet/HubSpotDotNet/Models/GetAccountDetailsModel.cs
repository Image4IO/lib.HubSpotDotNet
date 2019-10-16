using Newtonsoft.Json;

namespace HubSpotDotNet.Models
{
    public class GetAccountDetailsModel : BaseModel
    {
        [JsonProperty(PropertyName = "portalId")]
        public int PortalId { get; set; }

        [JsonProperty(PropertyName = "portatimeZonelId")]
        public string timeZone { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "utcOffsetMilliseconds")]
        public int UtcOffsetMilliseconds { get; set; }

        [JsonProperty(PropertyName = "utcOffset")]
        public string UtcOffset { get; set; }
    }
}
