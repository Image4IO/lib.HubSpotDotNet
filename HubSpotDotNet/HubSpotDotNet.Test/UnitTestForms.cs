using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace HubSpotDotNet.Test
{
    [TestClass]
    public class UnitTestForms
    {
        HubSpot hs;

        public UnitTestForms()
        {
            string apiKey = File.ReadAllText("API.key");
            hs = new HubSpot(apiKey);
        }

        [TestMethod]
        public void SubmitDataToAFormTest()
        {
            var response = hs.Forms.SubmitDataToAForm();

            //Assert.AreNotEqual(0, response.PortalId);
        }
    }
}
