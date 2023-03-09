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
        public int CheckLogin(string username, string password)
        {
            // This int array will be used to decalre what level of access will be provided.
            // If the int remains 0, access will be denied.
            // 1 = Admin Access
            // 2 = Logistics Coordinator Access
            // 3 = Courier Access
            int checker = 0;

            switch(username + password)
            {
                case "BayAdmin" + "Passw0rd":
                    checker = 1;
                break;

                case "BayCoord" + "Coordinator123":
                    checker = 2;
                break;

                case "Courier1" + "Cor123":
                    checker = 3;
                break;
            }

            return checker;
        }
    }
}
