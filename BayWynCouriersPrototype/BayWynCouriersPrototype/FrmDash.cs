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
                case 1:
                    button1.Hide();
                    break;
                case 2:
                    button2.Hide();
                    break;
                case 3:
                    button3.Hide();
                    break;
            }
        }
    }
}
