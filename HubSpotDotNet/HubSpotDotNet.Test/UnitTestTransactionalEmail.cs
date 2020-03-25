using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace HubSpotDotNet.Test
{
    [TestClass]
    public class UnitTestTransactionalEmail
    {
        HubSpot hs;

        public UnitTestTransactionalEmail()
        {
            string apiKey = File.ReadAllText("API.key");
            hs = new HubSpot(apiKey);
        }

        [TestMethod]
        public void SendSingleEmailTest()
        {
            var request = new TransactionalEmail.Models.SendSingleEmailRequestModel
            {
                EmailId= 85230578,
                Message = new TransactionalEmail.Models.Message
                {
                    To="irensaltali@gmail.com",
                    From="burak@image4.io"
                }
            };


            var response = hs.TransactionalEmail.SendSingleEmail(request);

            Assert.IsTrue(response);

        }
    }
}
