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
    public partial class FrmViewReports : Form
    {
        public FrmViewReports()
        {
            InitializeComponent();
        }

        private void FrmViewReports_Load(object sender, EventArgs e)
        {
            // Set the DateTimePicker's format to dd/mm/yyyy.
            dtpReportDay.Format = DateTimePickerFormat.Custom;
            dtpReportDay.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Declare a new reports class.
            Reports objRep = new Reports();
            // Declare a new datarow and dataset.
            DataRow drRep;
            DataSet dsRep;

            // Check what was selected in the combobox.
            switch (cmbView.Text)
            {
                case "Courier Assignments By Day":
                    // Get the DateTime from the DateTimePicker and send it to the class.
                    objRep.deliveryDate = DateTime.Parse(dtpReportDay.Text);
                    // Fill the dataset by calling the method.
                    dsRep = objRep.GetAllDeliveriesByDay();

                    try
                    {
                        // Fill the datarow using the dataset.
                        drRep = dsRep.Tables[0].Rows[0];

                        // Fill the datagrid.
                        dataGridViewRep.DataSource = dsRep.Tables[0];
                    }
                    catch
                    {
                        // If nothing could be returned, return a message box.
                        MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Courier Assignments By Month":
                    objRep.deliveryDate = DateTime.Parse(dtpReportDay.Text);
                    dsRep = dsRep = objRep.GetAllDeliveriesByMonth();

                    try
                    {
                        drRep = dsRep.Tables[0].Rows[0];

                        dataGridViewRep.DataSource = dsRep.Tables[0];
                    }
                    catch
                    {
                        MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Contracted & Non-Contracted Clients":
                    objRep.deliveryDate = DateTime.Parse(dtpReportDay.Text);
                    dsRep = objRep.GetAllContractsByMonth();

                    try
                    {
                        drRep = dsRep.Tables[0].Rows[0];

                        dataGridViewRep.DataSource = dsRep.Tables[0];
                    }
                    catch
                    {
                        MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Value of Contracted & Non-Contracted Clients":
                    objRep.deliveryDate = DateTime.Parse(dtpReportDay.Text);
                    dsRep = objRep.GetAllContractValuesByMonth();

                    try
                    {
                        drRep = dsRep.Tables[0].Rows[0];

                        dataGridViewRep.DataSource = dsRep.Tables[0];
                    }
                    catch
                    {
                        MessageBox.Show("Could not retrieve any records, please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
    }
}
