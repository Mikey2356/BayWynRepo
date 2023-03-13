using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace BayWynCouriersPrototype
{
    public partial class FrmCreateContract : Form
    {
        // Declare new variables to be sent off to the class.
        public string isNonContract;
        public decimal totalPrice = 50;
        public DateTime conDate;

        public FrmCreateContract()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will be called when the create contract button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCon_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes are null.
            if(txtBisName == null || txtAdd1 == null || txtAdd2 == null || txtPhoneNo == null || txtEmail == null) 
            { 
                // If they are, return a message box.
               MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Declare a new contracts class.
                Contracts objCon = new Contracts();

                // Fill the DateTime variable with the current system time.
                conDate = DateTime.Now;

                // Send all fields off to the contracts class.
                objCon.businessName = txtBisName.Text;
                objCon.add1 = txtAdd1.Text;
                objCon.add2 = txtAdd2.Text;
                objCon.phoneNo = txtPhoneNo.Text;
                objCon.email = txtEmail.Text;
                objCon.notes = txtNotes.Text;
                objCon.price = totalPrice;
                objCon.nonContract = isNonContract;
                objCon.contractDate = conDate;

                // Call the method inside the contracts class.
                objCon.AddNewContract();

                // Return the contract ID to display in a text box.
                txtConID.Text = objCon.contractID.ToString();
            }
        }

        /// <summary>
        /// This method will be called when update price button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            // If the checkbox is ticked.
            if(checkNonContract.Checked == true)
            {
                // Set the new price.
                lblPrice.Text = "10.00";
                totalPrice = 10;
                isNonContract = "Yes";
            }
            // If it isn't ticked.
            else if (checkNonContract.Checked == false)
            {
                // Set the original price.
                lblPrice.Text = "50.00";
                totalPrice = 50;
                isNonContract = "No";
            } 
        }
    }
}
