namespace BayWynCouriersPrototype
{
    partial class FrmViewCouriers
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
            this.dataGridViewCor = new System.Windows.Forms.DataGridView();
            this.cmbStartBreak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEndBreak = new System.Windows.Forms.ComboBox();
            this.btnSetBreak = new System.Windows.Forms.Button();
            this.txtCourierID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Couriers";
            // 
            // dataGridViewCor
            // 
            this.dataGridViewCor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCor.Location = new System.Drawing.Point(38, 61);
            this.dataGridViewCor.Name = "dataGridViewCor";
            this.dataGridViewCor.Size = new System.Drawing.Size(469, 160);
            this.dataGridViewCor.TabIndex = 14;
            // 
            // cmbStartBreak
            // 
            this.cmbStartBreak.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartBreak.FormattingEnabled = true;
            this.cmbStartBreak.Items.AddRange(new object[] {
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00"});
            this.cmbStartBreak.Location = new System.Drawing.Point(204, 282);
            this.cmbStartBreak.Name = "cmbStartBreak";
            this.cmbStartBreak.Size = new System.Drawing.Size(121, 29);
            this.cmbStartBreak.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Set start break time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Set end break time:";
            // 
            // cmbEndBreak
            // 
            this.cmbEndBreak.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEndBreak.FormattingEnabled = true;
            this.cmbEndBreak.Items.AddRange(new object[] {
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00"});
            this.cmbEndBreak.Location = new System.Drawing.Point(204, 316);
            this.cmbEndBreak.Name = "cmbEndBreak";
            this.cmbEndBreak.Size = new System.Drawing.Size(121, 29);
            this.cmbEndBreak.TabIndex = 17;
            // 
            // btnSetBreak
            // 
            this.btnSetBreak.BackColor = System.Drawing.Color.White;
            this.btnSetBreak.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBreak.Location = new System.Drawing.Point(370, 316);
            this.btnSetBreak.Name = "btnSetBreak";
            this.btnSetBreak.Size = new System.Drawing.Size(137, 30);
            this.btnSetBreak.TabIndex = 19;
            this.btnSetBreak.Text = "Set break time";
            this.btnSetBreak.UseVisualStyleBackColor = false;
            this.btnSetBreak.Click += new System.EventHandler(this.btnSetBreak_Click);
            // 
            // txtCourierID
            // 
            this.txtCourierID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourierID.Location = new System.Drawing.Point(204, 251);
            this.txtCourierID.Name = "txtCourierID";
            this.txtCourierID.Size = new System.Drawing.Size(100, 29);
            this.txtCourierID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter Courier ID:";
            // 
            // FrmViewCouriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(551, 358);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCourierID);
            this.Controls.Add(this.btnSetBreak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEndBreak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStartBreak);
            this.Controls.Add(this.dataGridViewCor);
            this.Controls.Add(this.label1);
            this.Name = "FrmViewCouriers";
            this.Text = "SetBreakTime";
            this.Load += new System.EventHandler(this.FrmSetBreakTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCor;
        private System.Windows.Forms.ComboBox cmbStartBreak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEndBreak;
        private System.Windows.Forms.Button btnSetBreak;
        private System.Windows.Forms.TextBox txtCourierID;
        private System.Windows.Forms.Label label4;
    }
}