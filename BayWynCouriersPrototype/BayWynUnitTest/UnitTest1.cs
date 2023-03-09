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

        [TestMethod]
        public void Constructor_NormalData_LoginPressed()
        {
            BayWynCouriersPrototype.FrmLogin newLog;

            newLog = new BayWynCouriersPrototype.FrmLogin();

            Assert.IsNotNull(newLog);
        }

        [TestMethod]
        public void Constructor_NormalData_AccessGranted()
        {
            BayWynCouriersPrototype.FrmDash newDash;

            newDash = new BayWynCouriersPrototype.FrmDash();

            Assert.IsNotNull(newDash);
        }
    }
}
