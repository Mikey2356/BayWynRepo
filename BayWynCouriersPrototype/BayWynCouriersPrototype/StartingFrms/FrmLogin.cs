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

        // Declare an int to determine level of access.
        // It is a public static variable so it can be passed between forms.
        public static int lvlAccess = 0;

        // Declare a set of strings that will be used for unit testing.
        private string m_username;
        private string m_password;

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

        /// <summary>
        /// This method will activate upon the login button being pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginSend(username, password);
            }
            catch
            {
                // If invalid credentials are provided, or the service references aren't connected a message box will display.
                MessageBox.Show("Invalid credentials, please try again.", "Error", MessageBoxButtons.OK);
            }
        }

        public void LoginSend(string username, string password)
        {
            // Declare two new strings which take from the text boxes.
            username = txtUsername.Text;
            password = txtPassword.Text;

            m_username = username;
            m_password = password;

            // Send information off to the web service which should return a boolean.
            lvlAccess = BWSR.CheckLogin(m_username, m_password);

            // If the returned boolean is true.
            if (lvlAccess == 1 || lvlAccess == 2 || lvlAccess == 3 || lvlAccess == 4)
            {
                // Declare the dashboard form.
                FrmDash Dashboard = new FrmDash();

                // Open the dashboard form.
                Dashboard.Show();

                // Hide the current form.
                this.Close();
            }
        }

        public FrmLogin(String username, String password)
        {
            m_username = username;
            m_password = password;
        }
        //get and return the usernames for the unit test.
        public string username
        {
            get { return m_username; }
            set { m_username = value; }
        }
        public string password
        {
            get { return m_password; }
            set { m_password = value; }
        }
    }
}
