using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace HubSpotDotNet.Test
{
    [TestClass]
    public class UnitTestHS
    {
        IHubSpot hs;

        public UnitTestHS()
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



        [TestMethod]
        public void CheckDailyApiUsageTest()
        {
            var response = hs.CheckDailyApiUsage();

            Assert.IsNotNull(response.FetchStatus);
        }
    }
}
