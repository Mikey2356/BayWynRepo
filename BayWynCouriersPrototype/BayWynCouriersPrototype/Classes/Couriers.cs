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
    public class Couriers
    {
        // Declare new variables.
        public int m_courierID;
        public string m_firstName;
        public string m_lastName;
        public string m_breakStart;
        public string m_breakEnd;

        // Get and set all varaibles sent from the form with the newly declared variables.
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

        /// <summary>
        /// This DataSet will be called when it's called from a form.
        /// </summary>
        /// <returns></returns>
        public DataSet GetCouriers()
        {
            // Declare a new DataSet.
            DataSet dsCor = new DataSet();

            // Declare a new connection string.
            string CourierCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            // Declare a new SQL connection using the connection strings.
            SqlConnection cnCor = new SqlConnection(CourierCon);

            try
            {
                // Attempt to establish a connection to the database.
                cnCor.Open();
            }
            catch
            {
                // If the connection attempt fails, return a message box.
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Set up a new SQL command.
            SqlCommand cmCor = new SqlCommand();

            cmCor.Connection = cnCor;

            // Declare the command type.
            cmCor.CommandType = CommandType.Text;

            // Send the command to the SQL database.
            cmCor.CommandText = "SELECT * FROM Couriers";

            // Declare a new data adapter.
            SqlDataAdapter daCon = new SqlDataAdapter(cmCor);

            // Fill the dataset using the data adapter.
            daCon.Fill(dsCor);

            // Close the database connection.
            cnCor.Close();

            // Return the dataset.
            return dsCor;
        }

        /// <summary>
        /// This method will be called when it's called from a form.
        /// </summary>
        /// <returns></returns>
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
