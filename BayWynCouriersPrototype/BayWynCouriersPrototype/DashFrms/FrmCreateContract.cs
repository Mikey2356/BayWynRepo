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
using System.Text.RegularExpressions;

namespace BayWynCouriersPrototype
{
    public partial class FrmCreateContract : Form
    {
        // Declare new variables to be sent off to the class.
        public string isNonContract;
        public decimal totalPrice;
        public DateTime conDate;

        public FrmCreateContract()
        {
            InitializeComponent();
        }

        private void FrmCreateContract_Load(object sender, EventArgs e)
        {
            // If either an administrator or logistics coordinator opens this form.
            if (FrmLogin.lvlAccess == 2 || FrmLogin.lvlAccess == 3)
            {
                // Restrict their access to only be able to make non-contracted listsings.
                checkNonContract.Checked = true;
                checkNonContract.Enabled = false;

                totalPrice = 10;
                lblPrice.Text = "10.00";
            }
        }

        /// <summary>
        /// This method will be called when the create contract button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCon_Click(object sender, EventArgs e)
        {
            Regex regx = new Regex("^[0-9]*$");

            // Check if any of the text boxes are null.
            if(txtBisName.Text == "" || txtAdd1.Text == "" || txtAdd2.Text == "" || txtPhoneNo.Text == "" || txtEmail.Text == "") 
            { 
                // If they are, return a message box.
               MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!regx.IsMatch(txtPhoneNo.Text))
            {
                MessageBox.Show("Please use only numbers in the phone number field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Declare a new contracts class.
                Contracts objCon = new Contracts();

                // Fill the DateTime variable with the current system time.
                conDate = DateTime.Now;

                if (checkNonContract.Checked == true)
                {
                    // Set the new price.
                    totalPrice = 10;
                    isNonContract = "Yes";
                }
                // If it isn't ticked.
                else if (checkNonContract.Checked == false)
                {
                    // Set the original price.
                    totalPrice = 50;
                    isNonContract = "No";
                }

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
