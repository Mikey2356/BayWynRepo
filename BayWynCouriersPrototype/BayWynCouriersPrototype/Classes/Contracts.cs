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

namespace BayWynCouriersPrototype
{
    internal class Contracts
    {
        // Declare all variables inputted into the form.
        public int m_contractID;
        public string m_businessName;
        public string m_add1;
        public string m_add2;
        public string m_phoneNo;
        public string m_email;
        public string m_notes;

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
        public string notes
        {
            get { return m_notes; }
            set { m_notes = value; }
        }

        public void AddNewContract()
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

            cmCon.CommandText = "INSERT INTO ClientContracts(BusinessName, Address1, Address2, PhoneNo, Email, Notes)" + 
                                "Values ('" + m_businessName + "','" + m_add1 + "','" + m_add2 + "','" + m_phoneNo + "','" + m_email + "','" + m_notes + "')";
            try
            {
                cmCon.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Invalid characters detected.\nPlease avoid using characters such as: '?!&*#;:", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            cmCon.CommandText = "Select MAX(ContractId) FROM ClientContracts";

            try
            {
                m_contractID = (int)cmCon.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Could generate an ID for the contract. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnCon.Close();
        }

        public DataSet GetAllContractsByContractID(int ConID)
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

            cmCon.CommandType = CommandType.Text;

            cmCon.CommandText = "SELECT * FROM ClientContracts where ContractId = '" + ConID + "'";

            SqlDataAdapter daCon = new SqlDataAdapter(cmCon);

            daCon.Fill(dsCon);

            cnCon.Close();

            return dsCon;
        }

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
    }
}
