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
    public partial class FrmCancelDelivery : Form
    {
        public FrmCancelDelivery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method is called on form start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCancelDelivery_Load(object sender, EventArgs e)
        {
            // Declare the assignments class.
            Assignments objDeliver = new Assignments();
            // Declare a new datarow.
            DataRow drDel;
            // Declare a new dataset and instantly call a method to return all available data from the database to the datagrid
            DataSet dsDel = objDeliver.GetAllDeliveries();

            try
            {
                // Fill the datarow with all available data sent to the dataset from the method.
                drDel = dsDel.Tables[0].Rows[0];

                dataGridViewDel.DataSource = dsDel.Tables[0];
            }
            catch
            {
                // If no data could be returned, return a message box.
                MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method is called when the cancel button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Assignments objDel = new Assignments();

            // Declare a new string which will be send to the assignments class.
            string Cancel = "Cancelled";

            // Send all variables off the the class.
            objDel.accepted = Cancel;
            objDel.deliveryID = int.Parse(txtDelID.Text);

            // Call the method inside the assignments class.
            objDel.CancelDelivery();

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
