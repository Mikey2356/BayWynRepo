using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;

namespace BayWynCouriersWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BayWynService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BayWynService.svc or BayWynService.svc.cs at the Solution Explorer and start debugging.
    public class BayWynService : IBayWynService
    {
        public bool CheckLogin(string username, string password)
        {
            bool loginCorrect = false;

            switch(username + password)
            {
                case "Dave123" + "Password123":
                        loginCorrect = true;
                    break;
            }

            return loginCorrect;
        }
        public string username
        {
            get { return username; }
            set { username = value; }
        }

        public string password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
