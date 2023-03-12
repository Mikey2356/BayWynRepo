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

        private void FrmSetBreakTime_Load(object sender, EventArgs e)
        {
            Couriers objCourier = new Couriers();
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

        private void btnSetBreak_Click(object sender, EventArgs e)
        {
            Couriers objCourier = new Couriers();

            objCourier.courierID = int.Parse(txtCourierID.Text);
            objCourier.breakStart = cmbStartBreak.SelectedItem.ToString();
            objCourier.breakEnd = cmbEndBreak.SelectedItem.ToString();

            switch(cmbStartBreak.SelectedItem.ToString())
            {
                case "12:00":
                    if(cmbEndBreak.SelectedItem.ToString() == "13:15" || cmbEndBreak.SelectedItem.ToString() == "13:30" || cmbEndBreak.SelectedItem.ToString() == "13:45" || cmbEndBreak.SelectedItem.ToString() == "14:00")
                    {
                        MessageBox.Show("Break time exceeds one hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(cmbEndBreak.SelectedItem.ToString() == "13:00")
                    {
                        objCourier.SetBreakTime();
                    }
                break;

                case "12:15":
                    if (cmbEndBreak.SelectedItem.ToString() == "13:00")
                    {
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
