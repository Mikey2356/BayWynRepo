using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using BayWynCouriersPrototype;

namespace BayWynUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_MissingUsernamePassword_UserError()
        {
            // Arrange
            FrmLogin loginFrm = new FrmLogin("", "");
 
            bool testResult;

            if(loginFrm.username == "" || loginFrm.password == "")
            {
                testResult = false;
            }
            else
            {
                testResult = true;
            }

            // Assert
            Assert.IsFalse(testResult);
        }

        [TestMethod]
        public void Constructor_NormalData_LoginPressed()
        {
            FrmLogin newLog;

            newLog = new FrmLogin();

            Assert.IsNotNull(newLog);
        }

        [TestMethod]
        public void Constructor_NormalData_AccessGranted()
        {
            FrmDash newDash;

            newDash = new FrmDash();

            Assert.IsNotNull(newDash);
        }
    }
}
