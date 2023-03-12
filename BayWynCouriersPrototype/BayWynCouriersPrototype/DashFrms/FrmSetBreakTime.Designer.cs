namespace BayWynCouriersPrototype
{
    partial class FrmSetBreakTime
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbStartBreak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEndBreak = new System.Windows.Forms.ComboBox();
            this.btnSetBreak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Employees";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 160);
            this.dataGridView1.TabIndex = 14;
            // 
            // cmbStartBreak
            // 
            this.cmbStartBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartBreak.FormattingEnabled = true;
            this.cmbStartBreak.Items.AddRange(new object[] {
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00"});
            this.cmbStartBreak.Location = new System.Drawing.Point(193, 241);
            this.cmbStartBreak.Name = "cmbStartBreak";
            this.cmbStartBreak.Size = new System.Drawing.Size(121, 28);
            this.cmbStartBreak.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Set start break time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Set end break time:";
            // 
            // cmbEndBreak
            // 
            this.cmbEndBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEndBreak.FormattingEnabled = true;
            this.cmbEndBreak.Items.AddRange(new object[] {
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00"});
            this.cmbEndBreak.Location = new System.Drawing.Point(193, 275);
            this.cmbEndBreak.Name = "cmbEndBreak";
            this.cmbEndBreak.Size = new System.Drawing.Size(121, 28);
            this.cmbEndBreak.TabIndex = 17;
            // 
            // btnSetBreak
            // 
            this.btnSetBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBreak.Location = new System.Drawing.Point(375, 318);
            this.btnSetBreak.Name = "btnSetBreak";
            this.btnSetBreak.Size = new System.Drawing.Size(132, 28);
            this.btnSetBreak.TabIndex = 19;
            this.btnSetBreak.Text = "Set break time";
            this.btnSetBreak.UseVisualStyleBackColor = true;
            // 
            // FrmSetBreakTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(551, 358);
            this.Controls.Add(this.btnSetBreak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEndBreak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStartBreak);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmSetBreakTime";
            this.Text = "SetBreakTime";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbStartBreak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEndBreak;
        private System.Windows.Forms.Button btnSetBreak;
    }
}