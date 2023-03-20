using BayWynCouriersPrototype.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayWynCouriersPrototype
{
    public partial class FrmViewCouriers : Form
    {
        public FrmViewCouriers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method will be called on form start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSetBreakTime_Load(object sender, EventArgs e)
        {
            // Declare a new class.
            Couriers objCourier = new Couriers();
            // Declare a new datarow.
            DataRow drDel;
            // Declare a new dataset and instantly send it off to retrieve database data.
            DataSet dsDel = objCourier.GetCouriers();

            try
            {
                // Fill datarow with all returned data in the dataset.
                drDel = dsDel.Tables[0].Rows[0];

                // Fill the datagrid with the dataset.
                dataGridViewCor.DataSource = dsDel.Tables[0];
            }
            catch
            {
                // If no records could be retrieved, return a messagebox.
                MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method will be called when the set break button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetBreak_Click(object sender, EventArgs e)
        {
            Couriers objCourier = new Couriers();

            // Send off user inputs to the class.
            objCourier.courierID = int.Parse(txtCourierID.Text);
            objCourier.breakStart = cmbStartBreak.SelectedItem.ToString();
            objCourier.breakEnd = cmbEndBreak.SelectedItem.ToString();

            // Check what time has been selected in the break start combobox.
            switch(cmbStartBreak.SelectedItem.ToString())
            {
                case "12:00":
                    // Check what time has been selected in the break end combobox.
                    if(cmbEndBreak.SelectedItem.ToString() == "13:15" || cmbEndBreak.SelectedItem.ToString() == "13:30" || cmbEndBreak.SelectedItem.ToString() == "13:45" || cmbEndBreak.SelectedItem.ToString() == "14:00")
                    {
                        // If time exceeds one hour, send a message box.
                        MessageBox.Show("Break time exceeds one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(cmbEndBreak.SelectedItem.ToString() == "13:00")
                    {
                        // If time is exactly one hour, call method.
                        objCourier.SetBreakTime();
                    }
                break;

                case "12:15":
                    if (cmbEndBreak.SelectedItem.ToString() == "13:00")
                    {
                        // If time is below one hour, send message box.
                        MessageBox.Show("Break time is below one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(cmbEndBreak.SelectedItem.ToString() == "13:30" || cmbEndBreak.SelectedItem.ToString() == "13:45" || cmbEndBreak.SelectedItem.ToString() == "14:00")
                    {
                        MessageBox.Show("Break time exceeds one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cmbEndBreak.SelectedItem.ToString() == "13:15")
                    {
                        objCourier.SetBreakTime();
                    }
                break;

                case "12:30":
                    if (cmbEndBreak.SelectedItem.ToString() == "13:00" || cmbEndBreak.SelectedItem.ToString() == "13:15")
                    {
                        MessageBox.Show("Break time is below one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cmbEndBreak.SelectedItem.ToString() == "13:45" || cmbEndBreak.SelectedItem.ToString() == "14:00")
                    {
                        MessageBox.Show("Break time exceeds one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cmbEndBreak.SelectedItem.ToString() == "13:30")
                    {
                        objCourier.SetBreakTime();
                    }
                break;

                case "12:45":
                    if (cmbEndBreak.SelectedItem.ToString() == "13:00" || cmbEndBreak.SelectedItem.ToString() == "13:15" || cmbEndBreak.SelectedItem.ToString() == "13:30")
                    {
                        MessageBox.Show("Break time is below one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cmbEndBreak.SelectedItem.ToString() == "14:00")
                    {
                        MessageBox.Show("Break time exceeds one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cmbEndBreak.SelectedItem.ToString() == "13:45")
                    {
                        objCourier.SetBreakTime();
                    }
                break;

                case "13:00":
                    if (cmbEndBreak.SelectedItem.ToString() == "13:00" || cmbEndBreak.SelectedItem.ToString() == "13:15" || cmbEndBreak.SelectedItem.ToString() == "13:30" || cmbEndBreak.SelectedItem.ToString() == "13:45")
                    {
                        MessageBox.Show("Break time is below one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cmbEndBreak.SelectedItem.ToString() == "14:00")
                    {
                        objCourier.SetBreakTime();
                    }
                break;

            }

            // Update the dataset with the new updated data.
            DataRow drDel;
            DataSet dsDel = objCourier.GetCouriers();

            try
            {
                drDel = dsDel.Tables[0].Rows[0];

                dataGridViewCor.DataSource = dsDel.Tables[0];
            }
            catch
            {
                MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
