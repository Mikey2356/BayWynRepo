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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Contracts objCon = new Contracts();
            DataRow drCon;
            DataSet dsCon = objCon.GetAllContractsByContractID(int.Parse(txtSearchConID.Text));

            try
            {
                drCon = dsCon.Tables[0].Rows[0];

                dataGridViewCon.DataSource = dsCon.Tables[0];
            }
            catch
            {
                MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Contracts objCon = new Contracts();

            objCon.contractID = int.Parse(txtConDel.Text);

            objCon.DeleteContract();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Contracts objCon = new Contracts();

            objCon.contractID = int.Parse(txtSearchConID.Text);
            objCon.businessName = txtBisName.Text;
            objCon.add1 = txtAdd1.Text;
            objCon.add2 = txtAdd2.Text;
            objCon.phoneNo = txtPhoneNo.Text;
            objCon.email = txtEmail.Text;
            objCon.notes = txtNotes.Text;

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
                if (dataGridViewCon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                { 
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
                MessageBox.Show("Please select a valid row.", "Datagrid error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
