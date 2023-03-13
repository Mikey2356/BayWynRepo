using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayWynCouriersPrototype
{
    public partial class FrmViewEditContract : Form
    {
        public FrmViewEditContract()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will be called when the search button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Declare a new class.
            Contracts objCon = new Contracts();
            // Declare a new datarow.
            DataRow drCon;
            // Declare a new dataset and instantly send it to retrieve all data using the inputted ID.
            DataSet dsCon = objCon.GetAllContractsByContractID(int.Parse(txtSearchConID.Text));

            // Fill the datarow with the returned data from the dataset.
            try
            {
                drCon = dsCon.Tables[0].Rows[0];

                dataGridViewCon.DataSource = dsCon.Tables[0];
            }
            catch
            {
                // If no data could be returned, return a message box.
                MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        /// <summary>
        /// This method will be called when the delete button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Contracts objCon = new Contracts();

            // Send the inputted ID off to the method.
            objCon.contractID = int.Parse(txtConDel.Text);
            // Call the method.
            objCon.DeleteContract();
        }

        /// <summary>
        /// This method will be called when the update button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Contracts objCon = new Contracts();

            // Send all user inputs off to the class.
            objCon.contractID = int.Parse(txtSearchConID.Text);
            objCon.businessName = txtBisName.Text;
            objCon.add1 = txtAdd1.Text;
            objCon.add2 = txtAdd2.Text;
            objCon.phoneNo = txtPhoneNo.Text;
            objCon.email = txtEmail.Text;
            objCon.notes = txtNotes.Text;

            // Call the method.
            objCon.EditContract();
        }

        /// <summary>
        /// Method will be called upon clicking a cell in the datagrid viewer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewCon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Collect all data on a clicked row.
                if (dataGridViewCon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                { 
                    // Fill out all text boxes with the data from the datagrid row.
                    txtConID.Text = dataGridViewCon.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtBisName.Text = dataGridViewCon.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtAdd1.Text = dataGridViewCon.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtAdd2.Text = dataGridViewCon.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtPhoneNo.Text = dataGridViewCon.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtEmail.Text = dataGridViewCon.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtNotes.Text = dataGridViewCon.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
            catch
            {
                // If an invalid row was clicked, send a message box.
                MessageBox.Show("Please select a valid row.", "Datagrid error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
