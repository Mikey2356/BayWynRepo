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
    public partial class FrmDash : Form
    {
        public FrmDash()
        {
            InitializeComponent();
        }

        public void FrmDash_Load(object sender, EventArgs e)
        {
            MessageBox.Show(FrmLogin.lvlAccess.ToString());

            switch(FrmLogin.lvlAccess)
            {
                // Owner
                case 1:
                    // Because the owner has access to all aspects of the program, they will not have any features hidden from them.
                    btnAcceptDel.Enabled = true;
                    btnCanDel.Enabled = true;
                    btnChangeDel.Enabled = true;
                    btnCreateCon.Enabled = true;
                    btnSetBreak.Enabled = true;
                    btnSetDelTIme.Enabled = true;
                    btnViewCon.Enabled = true;
                    btnViewRep.Enabled = true;
                    break;

                // Administrator
                case 2:
                    btnSetDelTIme.Enabled = false;
                    btnCanDel.Enabled = false;

                    // Obtain reports will remain available but the admin will still not be able to access specific parts of that form.

                    btnCanDel.Enabled = true;
                    btnChangeDel.Enabled = true;
                    btnCreateCon.Enabled = true;
                    btnSetBreak.Enabled = true;
                    btnViewCon.Enabled = true;
                    btnViewRep.Enabled = true;
                    break;

                // Logistics Coordinator
                case 3:
                    btnCreateCon.Enabled = false;
                    btnSetDelTIme.Enabled = false;
                    btnChangeDel.Enabled = false;
                    btnAcceptDel.Enabled = false;

                    btnCanDel.Enabled = true;
                    btnSetBreak.Enabled = true;
                    btnViewCon.Enabled = true;
                    btnViewRep.Enabled = true;
                    break;

                // Couriers
                case 4:
                    btnCreateCon.Enabled = false;
                    btnChangeDel.Enabled = false;
                    btnSetDelTIme.Enabled = false;
                    btnViewCon.Enabled = false;
                    btnViewRep.Enabled = false;
                    btnCanDel.Enabled = false;

                    btnAcceptDel.Enabled = true;
                    btnSetBreak.Enabled = true;
                    break;
            }
        }

        private void btnCreateCon_Click(object sender, EventArgs e)
        {
            FrmCreateContract frmCon = new FrmCreateContract();
            frmCon.Show();
            //this.Hide();
        }

        private void btnViewCon_Click(object sender, EventArgs e)
        {
            FrmViewEditContract frmViewCon = new FrmViewEditContract();
            frmViewCon.Show();
        }
    }
}
