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
    internal class Deliveries
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

            cmDel.CommandText = "CONVERT(VARCHAR," + m_deliveryDate + ", 103)";

            cmDel.CommandText = "UPDATE Deliveries " +
                                "SET DeliveryDate ='" + m_deliveryDate + "', DeliveryTime = '" + m_deliveryTime + "'" +
                                "WHERE DeliveryId = '" + m_deliveryID + "';";

            // cmDel.Parameters.Add("@delDate", SqlDbType.DateTime).Value = m_deliveryDate;

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

        public DataSet DisplayDelivery()
        {
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

            SqlDataAdapter daCon = new SqlDataAdapter(cmDel);

            daCon.Fill(dsDeliver);

            cnDel.Close();

            return dsDeliver;
        }
    }
}
