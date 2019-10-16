using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HubSpotDotNet.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var hs = new HubSpot();
            hs.contacts.Tets();
        }
    }
}
