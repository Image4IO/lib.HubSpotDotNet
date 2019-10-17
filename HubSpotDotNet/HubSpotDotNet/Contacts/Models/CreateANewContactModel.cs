using Newtonsoft.Json;
using System.Collections.Generic;

namespace HubSpotDotNet.Contacts.Models
{
    public class CreateANewContactModel
    {
        [JsonProperty(PropertyName = "properties")]
        public List<Property> Properties { get; set; }
    }

    public class Property
    {
        [JsonProperty(PropertyName = "property")]
        public string PropertyName { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
