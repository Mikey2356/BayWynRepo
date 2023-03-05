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
    public partial class FrmLogin : Form
    {
        // Declare the service referece.
        BayWynServiceReference.IBayWynService BWSR = null;

        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method will activate on startup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Declare the new service reference.
            BWSR = new BayWynServiceReference.BayWynServiceClient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Declare two new strings which take from the text boxes.
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            // Declare a bool to check if login is correct or not.
            bool loginChecked = false;

            loginChecked = BWSR.CheckLogin(username, password);

            if (loginChecked == true)
            {
                // Declare the dashboard form.
                FrmDash Dashboard = new FrmDash();
                // Open the dashboard form.
                Dashboard.Show();
                // Hide the current form.
                this.Hide();
            }
        }
    }
}
