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
        public FrmCreateContract()
        {
            InitializeComponent();
        }

        private void btnCreateCon_Click(object sender, EventArgs e)
        {
            if(txtBisName == null || txtAdd1 == null || txtAdd2 == null || txtPhoneNo == null || txtEmail == null) 
            { 
               MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Contracts objCon = new Contracts();

                objCon.businessName = txtBisName.Text;
                objCon.add1 = txtAdd1.Text;
                objCon.add2 = txtAdd2.Text;
                objCon.phoneNo = txtPhoneNo.Text;
                objCon.email = txtEmail.Text;
                objCon.notes = txtNotes.Text;

                objCon.AddNewContract();

                txtConID.Text = objCon.contractID.ToString();
            }
        }
    }
}
