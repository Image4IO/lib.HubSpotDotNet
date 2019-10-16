using Newtonsoft.Json;

namespace HubSpotDotNet.Models
{
    public class CheckDailyApiUsageModel : BaseModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "usageLimit")]
        public int UsageLimit { get; set; }

        [JsonProperty(PropertyName = "currentUsage")]
        public int CurrentUsage { get; set; }

        [JsonProperty(PropertyName = "collectedAt")]
        public long CollectedAt { get; set; }

        [JsonProperty(PropertyName = "fetchStatus")]
        public string FetchStatus { get; set; }

        [JsonProperty(PropertyName = "resetsAt")]
        public long ResetsAt { get; set; }
    }
}
