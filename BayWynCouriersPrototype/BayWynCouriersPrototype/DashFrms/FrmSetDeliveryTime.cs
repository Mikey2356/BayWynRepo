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

        private void FrmSetDeliveryTime_Load(object sender, EventArgs e)
        {
            dtpDeliveryDate.Format = DateTimePickerFormat.Custom;
            dtpDeliveryDate.CustomFormat = "dd/MM/yyyy";

            Deliveries objDeliver = new Deliveries();
            DataRow drDel;
            DataSet dsDel = objDeliver.DisplayDelivery();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Deliveries objDeliver = new Deliveries();
            DataRow drDel;
            DataSet dsDel = objDeliver.DisplayDelivery();

            try
            {
                objDeliver.m_deliveryID = int.Parse(txtDelID.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // TODO: MAKE DAYS WORK OVER 12.
            objDeliver.m_deliveryDate = DateTime.Parse(dtpDeliveryDate.Text);
            objDeliver.m_deliveryTime = cmbTime.Text;

            objDeliver.SetTime();

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
