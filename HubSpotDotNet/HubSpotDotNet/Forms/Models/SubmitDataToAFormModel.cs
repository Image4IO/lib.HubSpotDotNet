using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HubSpotDotNet.Forms.Models
{
    public class SubmitDataToAFormModel
    {
        [JsonProperty(PropertyName = "submittedAt")]
        public TimeSpan SubmittedAt { get; set; }

        [JsonProperty(PropertyName = "fields")]
        public List<Field> Fields { get; set; }

        [JsonProperty(PropertyName = "context")]
        public ContextClass Context { get; set; }

        [JsonProperty(PropertyName = "legalConsentOptions")]
        public LegalConsentOptionsClass LegalConsentOptions { get; set; }
        public class Field
        {
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "value")]
            public string Value { get; set; }
        }

        public class ContextClass
        {
            [JsonProperty(PropertyName = "hutk")]
            public string Hutk { get; set; }

            [JsonProperty(PropertyName = "pageUri")]
            public string PageUri { get; set; }

            [JsonProperty(PropertyName = "pageName")]
            public string PageName { get; set; }
        }

        public class Communication
        {
            [JsonProperty(PropertyName = "value")]
            public bool Value { get; set; }

            [JsonProperty(PropertyName = "subscriptionTypeId")]
            public int SubscriptionTypeId { get; set; }

            [JsonProperty(PropertyName = "text")]
            public string Text { get; set; }
        }

        public class Consent
        {
            [JsonProperty(PropertyName = "consentToProcess")]
            public bool ConsentToProcess { get; set; }

            [JsonProperty(PropertyName = "text")]
            public string Text { get; set; }

            [JsonProperty(PropertyName = "communications")]
            public List<Communication> Communications { get; set; }
        }

        public class LegalConsentOptionsClass
        {

            [JsonProperty(PropertyName = "consent")]
            public Consent Consent { get; set; }
        }
    }
}
