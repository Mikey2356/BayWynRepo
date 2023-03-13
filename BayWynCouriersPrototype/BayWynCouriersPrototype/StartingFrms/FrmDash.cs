﻿using System;
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

        /// <summary>
        /// This method is called upon form start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FrmDash_Load(object sender, EventArgs e)
        {
            switch(FrmLogin.lvlAccess)
            {
                // Owner
                case 1:
                    // Because the owner has access to all aspects of the program, they will not have any features hidden from them.
                    btnAcceptDel.Enabled = true;
                    btnCanDel.Enabled = true;
                    btnCreateCon.Enabled = true;
                    btnSetBreak.Enabled = true;
                    btnSetDelTIme.Enabled = true;
                    btnViewCon.Enabled = true;
                    btnViewRep.Enabled = true;
                    break;

                // Administrator
                case 2:
                    btnSetDelTIme.Enabled = false;
                    btnCanDel.Enabled = false;
                    btnCanDel.Enabled = true;
                    btnCreateCon.Enabled = true;
                    btnSetBreak.Enabled = true;
                    btnViewCon.Enabled = true;
                    btnViewRep.Enabled = true;
                    break;

                // Logistics Coordinator
                case 3:
                    btnCreateCon.Enabled = false;
                    btnSetDelTIme.Enabled = false;
                    btnAcceptDel.Enabled = false;

                    btnCanDel.Enabled = true;
                    btnSetBreak.Enabled = true;
                    btnViewCon.Enabled = true;
                    btnViewRep.Enabled = true;
                    break;

                // Couriers
                case 4:
                    btnCreateCon.Enabled = false;
                    btnSetDelTIme.Enabled = false;
                    btnViewCon.Enabled = false;
                    btnViewRep.Enabled = false;
                    btnCanDel.Enabled = false;

                    btnAcceptDel.Enabled = true;
                    btnSetBreak.Enabled = true;
                    break;
            }
        }

        // Depending on what button is pressed, open the respective form.

        private void btnCreateCon_Click(object sender, EventArgs e)
        {
            FrmCreateContract frmCon = new FrmCreateContract();
            frmCon.Show();
        }

        private void btnViewCon_Click(object sender, EventArgs e)
        {
            FrmViewEditContract frmViewCon = new FrmViewEditContract();
            frmViewCon.Show();
        }

        private void btnSetDelTIme_Click(object sender, EventArgs e)
        {
            FrmSetDeliveryTime frmSetTime = new FrmSetDeliveryTime();
            frmSetTime.Show();
        }

        private void btnAcceptDel_Click(object sender, EventArgs e)
        {
            FrmAcceptDeliveries frmAcceptDel = new FrmAcceptDeliveries();
            frmAcceptDel.Show();
        }

        private void btnCanDel_Click(object sender, EventArgs e)
        {
            FrmCancelDelivery frmCancelDel = new FrmCancelDelivery();
            frmCancelDel.Show();
        }

        private void btnSetBreak_Click(object sender, EventArgs e)
        {
            FrmViewCouriers frmBreakTime = new FrmViewCouriers();
            frmBreakTime.Show();
        }

        private void btnViewRep_Click(object sender, EventArgs e)
        {
            FrmViewReports frmReport = new FrmViewReports();
            frmReport.Show();
        }
    }
}
