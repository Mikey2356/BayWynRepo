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
        public int m_courierID;
        public string m_firstName;
        public string m_lastName;
        public string m_breakStart;
        public string m_breakEnd;

        public int courierID
        {
            get { return m_courierID; }
            set { m_courierID = value; }
        }

        public string firstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        public string lastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        public string breakStart
        {
            get { return m_breakStart; }
            set { m_breakStart = value; }
        }
        public string breakEnd
        {
            get { return m_breakEnd; }
            set { m_breakEnd = value; }
        }

        public DataSet GetCouriers()
        {
            DataSet dsCor = new DataSet();

            string CourierCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            SqlConnection cnCor = new SqlConnection(CourierCon);

            try
            {
                cnCor.Open();
            }
            catch
            {
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmCor = new SqlCommand();

            cmCor.Connection = cnCor;

            cmCor.CommandType = CommandType.Text;

            cmCor.CommandText = "SELECT * FROM Couriers";

            SqlDataAdapter daCon = new SqlDataAdapter(cmCor);

            daCon.Fill(dsCor);

            cnCor.Close();

            return dsCor;
        }

        public void SetBreakTime()
        {
            string CourierCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            SqlConnection cnCor = new SqlConnection(CourierCon);

            try
            {
                cnCor.Open();
            }
            catch
            {
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmCor = new SqlCommand();

            cmCor.Connection = cnCor;

            cmCor.CommandType = CommandType.Text;

            cmCor.CommandText = "UPDATE Couriers " +
                                "SET BreakStart ='" + m_breakStart + "', BreakEnd = '" + m_breakEnd + "'" +
                                "WHERE CourierId = '" + m_courierID + "';";


            try
            {
                cmCor.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnCor.Close();
        }
    }
}
