namespace BayWynCouriersPrototype
{
    partial class FrmAcceptDeliveries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDel = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelID = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCourier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accept Deliveries";
            // 
            // dataGridViewDel
            // 
            this.dataGridViewDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDel.Location = new System.Drawing.Point(40, 67);
            this.dataGridViewDel.Name = "dataGridViewDel";
            this.dataGridViewDel.Size = new System.Drawing.Size(527, 194);
            this.dataGridViewDel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose ID:";
            // 
            // txtDelID
            // 
            this.txtDelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelID.Location = new System.Drawing.Point(40, 299);
            this.txtDelID.Name = "txtDelID";
            this.txtDelID.Size = new System.Drawing.Size(100, 26);
            this.txtDelID.TabIndex = 9;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(421, 337);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(146, 34);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Accept Delivery";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter delivering courier:";
            // 
            // cmdCourier
            // 
            this.cmdCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCourier.FormattingEnabled = true;
            this.cmdCourier.Items.AddRange(new object[] {
            "Adam Taylor",
            "Anton Brown",
            "David Williams",
            "Cameron Edwards",
            "Joel Garcia",
            "Joshua Adams",
            "Michael Jensen",
            "Nathan Jones",
            "Robert Miller",
            "William Yates"});
            this.cmdCourier.Location = new System.Drawing.Point(193, 297);
            this.cmdCourier.Name = "cmdCourier";
            this.cmdCourier.Size = new System.Drawing.Size(121, 28);
            this.cmdCourier.TabIndex = 13;
            // 
            // FrmAcceptDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(586, 383);
            this.Controls.Add(this.cmdCourier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDelID);
            this.Controls.Add(this.dataGridViewDel);
            this.Controls.Add(this.label1);
            this.Name = "FrmAcceptDeliveries";
            this.Text = "FrmAcceptDeliveries";
            this.Load += new System.EventHandler(this.FrmAcceptDeliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelID;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdCourier;
    }
}