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

namespace BayWynCouriersPrototype.Classes
{
    public class Assignments
    {
        public int m_deliveryID;
        public DateTime m_deliveryDate;
        public string m_deliveryTime;
        public string m_deliveryContents;
        public string m_deliveringCourier;
        public string m_accepted;

        public int deliveryID
        {
            get { return m_deliveryID; }
            set { m_deliveryID = value; }
        }
        public DateTime deliveryDate
        {
            get { return m_deliveryDate; }
            set { m_deliveryDate = value; }
        }
        public string deliveryTime
        {
            get { return m_deliveryTime; }
            set { m_deliveryTime = value; }
        }
        public string deliveryContents
        {
            get { return m_deliveryContents; }
            set{ m_deliveryContents = value; }
        }
        public string deliveringCourier
        {
            get { return m_deliveringCourier; }
            set { m_deliveringCourier = value; }
        }
        public string accepted
        {
            get { return m_accepted; }
            set { m_accepted = value; }
        }

        public void SetTime()
        {
            // Declare a new connection string.
            string DeliverCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            // Declare a new SQL connection using the connection strings.
            SqlConnection cnDel = new SqlConnection(DeliverCon);

            try
            {
                // Attempt to establish a connection to the database.
                cnDel.Open();
            }
            catch
            {
                // If the connection attempt fails, return a message box.
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Set up a new SQL command.
            SqlCommand cmDel = new SqlCommand();

            cmDel.Connection = cnDel;

            // Declare an SQL parameter, this will take the DateTime sent from the form and format it into SQL DateTime for more consistent usage.
            // cmDel.Parameters.Add("@delDate", SqlDbType.DateTime).Value = m_deliveryDate;

            // Declare the command type.
            cmDel.CommandType = CommandType.Text;

            /*  See testing document for further context.
                Sending m_deliveryDate as a parsed DateTime does not work:
                "SET DeliveryDate ='" + m_deliveryDate < - Set to GB format by default.
                Parsing and formating DateTime in this class does not work:
                DateTime.Parse(m_deliveryDate.ToString("dd/MM/yyyy")) < - GB format tested.
                DateTime.Parse(m_deliveryDate.ToString("MM/dd/yyyy")) < - US format tested. */
            
            // Send the command to the SQL database.
            cmDel.CommandText = "UPDATE Deliveries " +
                                "SET DeliveryDate ='" + m_deliveryDate + "'," + "DeliveryTime = '" + m_deliveryTime + "'" +
                                "WHERE DeliveryId = '" + m_deliveryID + "';";

            try
            {
                // Execute the database query.
                cmDel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If the query can't execute correctly, return a message box.
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnDel.Close();
        }

        public void AcceptDelivery()
        {
            string DeliverCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            SqlConnection cnDel = new SqlConnection(DeliverCon);

            try
            {
                cnDel.Open();
            }
            catch
            {
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmDel = new SqlCommand();

            cmDel.Connection = cnDel;

            cmDel.CommandType = CommandType.Text;

            cmDel.CommandText = "UPDATE Deliveries " +
                                "SET Status ='" + m_accepted + "', DeliveringCourier ='" + m_deliveringCourier + "'" +
                                "WHERE DeliveryId = '" + m_deliveryID + "';";

            try
            {
                cmDel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnDel.Close();
        }

        public void CancelDelivery()
        {
            string DeliverCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            SqlConnection cnDel = new SqlConnection(DeliverCon);

            try
            {
                cnDel.Open();
            }
            catch
            {
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmDel = new SqlCommand();

            cmDel.Connection = cnDel;

            cmDel.CommandType = CommandType.Text;

            cmDel.CommandText = "UPDATE Deliveries " +
                                "SET Status ='" + m_accepted + "'" +
                                "WHERE DeliveryId = '" + m_deliveryID + "';";

            try
            {
                cmDel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnDel.Close();
        }

        public DataSet GetAllDeliveries()
        {
            // Declare a new DataSet
            DataSet dsDeliver = new DataSet();

            string DeliveryCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            SqlConnection cnDel = new SqlConnection(DeliveryCon);

            try
            {
                cnDel.Open();
            }
            catch
            {
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmDel = new SqlCommand();

            cmDel.Connection = cnDel;

            cmDel.CommandType = CommandType.Text;

            cmDel.CommandText = "SELECT * FROM Deliveries";

            // Declare a new data adapter
            SqlDataAdapter daCon = new SqlDataAdapter(cmDel);

            // Fill the DataSet using the data adapter.
            daCon.Fill(dsDeliver);

            // Close the connection.
            cnDel.Close();

            // Return the dataset.
            return dsDeliver;
        }
    }
}
