using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace HubSpotDotNet.Test
{
    [TestClass]
    public class UnitTestContacts
    {
        IHubSpot hs;

        public UnitTestContacts()
        {
            string apiKey = File.ReadAllText("API.key");
            hs = new HubSpot(apiKey);
        }

        [TestMethod]
        public void GetAccountDetailsTest()
        {
            var response = hs.GetAccountDetails();

            Assert.AreNotEqual(0, response.PortalId);
        }
    }
}
