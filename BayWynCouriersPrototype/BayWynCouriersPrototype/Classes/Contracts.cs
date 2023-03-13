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

namespace BayWynCouriersPrototype
{
    public class Contracts
    {
        // Declare all variables inputted into the form.
        public int m_contractID;
        public string m_businessName;
        public string m_add1;
        public string m_add2;
        public string m_phoneNo;
        public string m_email;
        public decimal m_price;
        public string m_nonContract;
        public string m_notes;
        public DateTime m_contractDate;

        // Get and set all the variables.
        public int contractID
        {
            get { return m_contractID; }
            set { m_contractID = value; }
        }
        public string businessName
        {
            get { return m_businessName; }
            set { m_businessName = value; }
        }
        public string add1
        {
            get { return m_add1; }
            set { m_add1 = value; }
        }
        public string add2
        {
            get { return m_add2; }
            set { m_add2 = value; }
        }
        public string phoneNo
        {
            get { return m_phoneNo; }
            set { m_phoneNo = value; }
        }
        public string email
        {
            get { return m_email; }
            set { m_email = value; }
        }
        public decimal price
        {
            get { return m_price; }
            set { m_price = value; }
        }
        public string nonContract
        {
            get { return m_nonContract; }
            set { m_nonContract = value; }
        }
        public string notes
        {
            get { return m_notes; }
            set { m_notes = value; }
        }
        public DateTime contractDate
        {
            get { return m_contractDate; }
            set { m_contractDate = value; }
        }

        /// <summary>
        /// This method will be called when it's called from a form.
        /// </summary>
        /// <returns></returns>
        public void AddNewContract()
        {
            // Declare a new connection string.
            string ContractCon = ConfigurationManager.ConnectionStrings["BayWynStrings"].ConnectionString;

            // Declare a new SQL connection using the connection strings.
            SqlConnection cnCon = new SqlConnection(ContractCon);

            try
            {
                // Attempt to establish a connection to the database.
                cnCon.Open();
            }
            catch
            {
                // If the connection attempt fails, return a message box.
                MessageBox.Show("Could not connect to the database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Set up a new SQL command.
            SqlCommand cmCon = new SqlCommand();

            cmCon.Connection = cnCon;

            // Declare the command type.
            cmCon.CommandType = CommandType.Text;

            // Send the command to the SQL database.
            cmCon.CommandText = "INSERT INTO ClientContracts(BusinessName, Address1, Address2, PhoneNo, Email, Notes, Price, IsNonContract, ContractDate)" + 
                                "Values ('" + m_businessName + "','" + m_add1 + "','" + m_add2 + "','" + m_phoneNo + "','" + m_email + "','" + m_notes + "','" + m_price + "','" + m_nonContract + "','" + m_contractDate + "');";
            try
            {
                // Execute the database query.
                cmCon.ExecuteNonQuery();
            }
            catch
            {
                // If it detects an invalid character, send an error message.
                MessageBox.Show("Invalid character detected.\nPlease avoid using: ' ", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Select all ContractIds from the table.
            cmCon.CommandText = "Select MAX(ContractId) FROM ClientContracts";

            try
            {
                // store the int taken from the database.
                m_contractID = (int)cmCon.ExecuteScalar();
            }
            catch
            {
                // If an ID couldn't be generated 
                MessageBox.Show("Could generate an ID for the contract. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close the database connection.
            cnCon.Close();
        }

        /// <summary>
        /// This DataSet will be called when it's called from a form.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllContractsByContractID(int ConID)
        {
            // Declare a new DataSet
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

            cmCon.CommandType = CommandType.Text;

            cmCon.CommandText = "SELECT * FROM ClientContracts where ContractId = '" + ConID + "'";

            // Declare a new data adapter
            SqlDataAdapter daCon = new SqlDataAdapter(cmCon);

            // Fill the DataSet using the data adapter.
            daCon.Fill(dsCon);

            // Close the connection.
            cnCon.Close();

            // Return the dataset.
            return dsCon;
        }

        /// <summary>
        /// This method will be called when it's called from a form.
        /// </summary>
        /// <returns></returns>
        public void DeleteContract()
        {
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

            cmCon.CommandType = CommandType.Text;

            cmCon.CommandText = "DELETE FROM ClientContracts WHERE ContractId = '" + m_contractID + "'";

            MessageBox.Show("Contract Deleted", "Deletion Successful", MessageBoxButtons.OK);

            cmCon.ExecuteNonQuery();

            cnCon.Close();
        }

        /// <summary>
        /// This method will be called when it's called from a form.
        /// </summary>
        /// <returns></returns>
        public void EditContract()
        {
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

            cmCon.CommandType = CommandType.Text;

            cmCon.CommandText = "UPDATE ClientContracts " + 
                                "SET BusinessName = '" + m_businessName + "', Address1 = '" + m_add1 + "', Address2 = '" + m_add2 + "', PhoneNo = '" + m_phoneNo + "', Email = '" + m_email + "', Notes = '" + m_notes + "'" +
                                "WHERE ContractId = '" + m_contractID + "';";
            try
            {
                cmCon.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnCon.Close();
        }
    }
}
