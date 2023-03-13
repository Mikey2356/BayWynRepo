using BayWynCouriersPrototype.Classes;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayWynCouriersPrototype
{
    public partial class FrmSetDeliveryTime : Form
    {
        public FrmSetDeliveryTime()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This method will be called on form start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSetDeliveryTime_Load(object sender, EventArgs e)
        {
            // Set the DateTimePicker format to dd/mm/yyyy.
            dtpDeliveryDate.Format = DateTimePickerFormat.Custom;
            dtpDeliveryDate.CustomFormat = "dd/MM/yyyy";

            // Declare a new assignments class.
            Assignments objDeliver = new Assignments();
            // Declare a new datarow.
            DataRow drDel;
            // Declare a new dataset and instantly call a method to return any available data from the database.
            DataSet dsDel = objDeliver.GetAllDeliveries();

            try
            {
                // Return data from the dataset to fill the datarow.
                drDel = dsDel.Tables[0].Rows[0];

                dataGridViewDel.DataSource = dsDel.Tables[0];
            }
            catch
            {
                // If no data can be returned, return a message box.
                MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method will be called when the update button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Assignments objDeliver = new Assignments();
            DataRow drDel;

            try
            {
                // Send off the Id to the class.
                objDeliver.m_deliveryID = int.Parse(txtDelID.Text);
            }
            catch
            {
                // If it couldn't send a message box.
                MessageBox.Show("Please enter a ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // TODO: MAKE DAYS WORK OVER 12.
            // Send user inputs to the class.
            objDeliver.m_deliveryDate = DateTime.Parse(dtpDeliveryDate.Text);
            objDeliver.m_deliveryTime = cmbTime.Text;

            // Call the method.
            objDeliver.SetTime();

            // Call the dataset to refresh updated database tables.
            DataSet dsDel = objDeliver.GetAllDeliveries();
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
