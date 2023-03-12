using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting.Messaging;

namespace BayWynCouriersPrototype.Classes
{
    internal class Couriers
    {
        public string m_firstName;
        public string m_lastName;
        public string m_breakStart;
        public string m_breakEnd;

        public DataSet GetCouriers()
        {
            DataSet dsCor = new DataSet();



            return dsCor;
        }
    }
}
