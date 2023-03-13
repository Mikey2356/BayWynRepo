﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Data;
using BayWynCouriersPrototype;

namespace BayWynUnitTest
{
    [TestClass]
    public class BayWynUnitTest
    {
        // I'm struggling super hard with these unit tests, after countless videos and moodle resources searched I cannot wrap my head around how this is supposed to work.
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
        public void Constructor_ProvidedID()
        {
            // Arrange
            Contracts Con = new Contracts();

            // Act
            var Result = Con.GetAllContractsByContractID(int.Parse(null));

            // Assert
            Assert.IsNull(Result);
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
