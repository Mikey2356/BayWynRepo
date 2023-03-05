using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BayWynUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_NormalData_UsernameProvided()
        {
            BayWynCouriersWCF.BayWynService newService;

            newService = new BayWynCouriersWCF.BayWynService();

            Assert.IsNotNull(newService);
        }
    }
}
