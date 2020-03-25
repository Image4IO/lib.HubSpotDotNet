using Newtonsoft.Json;
using System.Collections.Generic;

namespace HubSpotDotNet.TransactionalEmail.Models
{
    public class SendSingleEmailRequestModel
    {
        [JsonProperty(PropertyName = "emailId")]
        public long EmailId { get; set; }

        [JsonProperty(PropertyName = "message")]
        public Message Message { get; set; }

        [JsonProperty(PropertyName = "contactProperties")]
        public List<Property> ContactProperties { get; set; }

        [JsonProperty(PropertyName = "customProperties")]
        public List<Property> CustomProperties { get; set; }
    }
    public class Message
    {
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        [JsonProperty(PropertyName = "fron")]
        public string From { get; set; }

        [JsonProperty(PropertyName = "cc")]
        public List<string> CC { get; set; }

        [JsonProperty(PropertyName = "bcc")]
        public List<string> BCC { get; set; }
    }

    public class Property
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
