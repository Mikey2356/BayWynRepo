using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Cryptography;

namespace BayWynCouriersPrototype.Classes
{
    public class Reports
    {
        // Declare a new date time.
        public DateTime m_deliveryDate;

        // Get and set the DateTime sent from the form.
        public DateTime deliveryDate
        {
            get { return m_deliveryDate; }
            set { m_deliveryDate = value; }
        }

        /// <summary>
        /// This DataSet will be called when the user requests deliveries in a single day.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllDeliveriesByDay()
        {
            // Declare a new dataset.
            DataSet dsCon = new DataSet();

            // Declare a new connection strings and store it within a string.
            string ContractCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            // Declare a new SQL connection.
            SqlConnection cnCon = new SqlConnection(ContractCon);

            try
            {
                // Open the connection to the database.
                cnCon.Open();
            }
            catch
            {
                // If a connection cannot be established, return a message box.
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Declare a new SQL command.
            SqlCommand cmCon = new SqlCommand();

            cmCon.Connection = cnCon;

            // Set up the command type.
            cmCon.CommandType = CommandType.Text;

            // Send the SQL command.
            cmCon.CommandText = "SELECT * FROM Deliveries WHERE DeliveryDate = '" + m_deliveryDate + "';";

            // Declare a new SQL data adapter.
            SqlDataAdapter daCon = new SqlDataAdapter(cmCon);

            // Fill the dataset using the data adapter.
            daCon.Fill(dsCon);

            // Close the connection.
            cnCon.Close();

            // Return the dataset.
            return dsCon;
        }

        /// <summary>
        /// This DataSet will be called when the user requests deliveries in a single month.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllDeliveriesByMonth()
        {
            DataSet dsCon = new DataSet();

            string ContractCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            SqlConnection cnCon = new SqlConnection(ContractCon);

            try
            {
                cnCon.Open();
            }
            catch
            {
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmCon = new SqlCommand();

            cmCon.Connection = cnCon;

            // Declare an SQL parameter, this will take the DateTime sent from the form and format it into SQL DateTime for more consistent usage.
            cmCon.Parameters.Add("@delDate", SqlDbType.Date).Value = m_deliveryDate;

            cmCon.CommandType = CommandType.Text;

            // This SQL query uses the MONTH clause where it will take the month from a DateTime in the table and compare it to the DateTime sent from the form.
            cmCon.CommandText = "SELECT * FROM Deliveries WHERE MONTH(DeliveryDate) = MONTH(@delDate);";
                                

            SqlDataAdapter daCon = new SqlDataAdapter(cmCon);

            daCon.Fill(dsCon);

            cnCon.Close();

            return dsCon;
        }

        /// <summary>
        /// This DataSet will be called when the user requests contracts in a single month.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllContractsByMonth()
        {
            DataSet dsCon = new DataSet();

            string ContractCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            SqlConnection cnCon = new SqlConnection(ContractCon);

            try
            {
                cnCon.Open();
            }
            catch
            {
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmCon = new SqlCommand();

            cmCon.Connection = cnCon;

            cmCon.Parameters.Add("@delDate", SqlDbType.Date).Value = m_deliveryDate;

            cmCon.CommandType = CommandType.Text;

            cmCon.CommandText = "SELECT * FROM ClientContracts WHERE MONTH(ContractDate) = MONTH(@delDate);";

            SqlDataAdapter daCon = new SqlDataAdapter(cmCon);

            daCon.Fill(dsCon);

            cnCon.Close();

            return dsCon;
        }

        /// <summary>
        /// This DataSet will be called when the user requests contract values in a single month.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllContractValuesByMonth()
        {
            DataSet dsCon = new DataSet();

            string ContractCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            SqlConnection cnCon = new SqlConnection(ContractCon);

            try
            {
                cnCon.Open();
            }
            catch
            {
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmCon = new SqlCommand();

            cmCon.Connection = cnCon;

            cmCon.Parameters.Add("@delDate", SqlDbType.Date).Value = m_deliveryDate;

            cmCon.CommandType = CommandType.Text;

            cmCon.CommandText = "SELECT ContractID, Price, IsNonContract FROM ClientContracts WHERE MONTH(ContractDate) = MONTH(@delDate);";

            SqlDataAdapter daCon = new SqlDataAdapter(cmCon);

            daCon.Fill(dsCon);

            cnCon.Close();

            return dsCon;
        }
    }
}
