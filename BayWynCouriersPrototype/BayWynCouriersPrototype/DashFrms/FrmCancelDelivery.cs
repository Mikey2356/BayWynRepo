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

        private void FrmCancelDelivery_Load(object sender, EventArgs e)
        {
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Deliveries objDel = new Deliveries();

            string Cancel = "Cancelled";

            objDel.accepted = Cancel;
            objDel.deliveryID = int.Parse(txtDelID.Text);

            objDel.CancelDelivery();
            DataRow drDel;
            DataSet dsDel = objDel.DisplayDelivery();

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
