using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace HubSpotDotNet.Test
{
    [TestClass]
    public class UnitTestContacts
    {
        HubSpot hs;

        public UnitTestContacts()
        {
            string apiKey = File.ReadAllText("API.key");
            hs = new HubSpot(apiKey);
        }

        [TestMethod]
        public void CreateANewContactTest()
        {
            var request = new Contacts.Models.CreateANewContactRequestModel
            {
                Email = "test2@image4.io",
                FirstName = "Test"
            };

            request.Properties.Add(new Contacts.Models.Property
            {
                PropertyName = "hs_analytics_source",
                Value = "OFFLINE"
            });

            request.Properties.Add(new Contacts.Models.Property
            {
                PropertyName = "reference",
                Value = "Azure"
            });


            var response = hs.Contacts.CreateANewContact(request);

            Assert.IsTrue(response);

        }
    }
}
