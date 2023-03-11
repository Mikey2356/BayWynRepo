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
        /// <summary>
        /// This method will be called once the service reference is called from the form.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int CheckLogin(string username, string password)
        {
            // This int array will be used to decalre what level of access will be provided.
            // If the int remains 0, access will be denied.
            int checker = 0;

            switch(username + password)
            {
                // 1 = Owner Access
                case "BayOwner" + "Pass":
                    checker = 1;
                    break;

                // 2 = Admin Access
                case "BayAdmin" + "Passw0rd":
                    checker = 2;
                    break;

                // 3 = Logistics Coordinator Access
                case "BayCoord" + "Coordinator123":
                    checker = 3;
                    break;

                // 4 = Courier Access
                case "Courier1" + "Cor123":
                    checker = 4;
                    break;
            }

            return checker;
        }
    }
}
