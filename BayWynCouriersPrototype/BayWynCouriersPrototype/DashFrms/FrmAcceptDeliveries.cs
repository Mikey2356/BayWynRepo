using BayWynCouriersPrototype.Classes;
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
    public partial class FrmAcceptDeliveries : Form
    {
        public FrmAcceptDeliveries()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is called upon form start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAcceptDeliveries_Load(object sender, EventArgs e)
        {
            // Declare the assignments class to call it later on.
            Assignments objDeliver = new Assignments();
            // Declare a new datarow.
            DataRow drDel;
            // Declare a new dataset that instantly calls a method in the assignments class to fill out the datagrid.
            DataSet dsDel = objDeliver.GetAllDeliveries();

            try
            {
                // Fill out the datarow using all returned entries from the database.
                drDel = dsDel.Tables[0].Rows[0];

                dataGridViewDel.DataSource = dsDel.Tables[0];
            }
            catch
            {
                // If no records could be found, return a message box.
                MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method is called when the accept button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Assignments objDel = new Assignments();

            // Declare a new string that will be sent to the assignments class.
            string Accept = "Accepted";

            // Send off all retrieved user inputs to the class.
            objDel.accepted = Accept;
            objDel.deliveringCourier = cmdCourier.SelectedItem.ToString();
            objDel.deliveryID = int.Parse(txtDelID.Text);

            // Call the method.
            objDel.AcceptDelivery();
            DataRow drDel;
            DataSet dsDel = objDel.GetAllDeliveries();

            try
            {
                drDel = dsDel.Tables[0].Rows[0];

                dataGridViewDel.DataSource = dsDel.Tables[0];
            }
            catch
            {
                MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
