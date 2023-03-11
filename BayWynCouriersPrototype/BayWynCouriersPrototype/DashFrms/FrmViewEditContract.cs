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
            DataSet dsCon = objCon.GetAllContractsByContractID(int.Parse(txtConID.Text));

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
    }
}
