namespace BayWynCouriersPrototype
{
    partial class FrmDash
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
            this.btnCreateCon = new System.Windows.Forms.Button();
            this.btnViewCon = new System.Windows.Forms.Button();
            this.btnSetDelTIme = new System.Windows.Forms.Button();
            this.btnAcceptDel = new System.Windows.Forms.Button();
            this.btnViewRep = new System.Windows.Forms.Button();
            this.btnSetBreak = new System.Windows.Forms.Button();
            this.btnCanDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BayWyn Couriers Dashboard";
            // 
            // btnCreateCon
            // 
            this.btnCreateCon.BackColor = System.Drawing.Color.White;
            this.btnCreateCon.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCon.Location = new System.Drawing.Point(107, 83);
            this.btnCreateCon.Name = "btnCreateCon";
            this.btnCreateCon.Size = new System.Drawing.Size(90, 66);
            this.btnCreateCon.TabIndex = 1;
            this.btnCreateCon.Text = "Create Contract";
            this.btnCreateCon.UseVisualStyleBackColor = false;
            this.btnCreateCon.Click += new System.EventHandler(this.btnCreateCon_Click);
            // 
            // btnViewCon
            // 
            this.btnViewCon.BackColor = System.Drawing.Color.White;
            this.btnViewCon.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCon.Location = new System.Drawing.Point(228, 82);
            this.btnViewCon.Name = "btnViewCon";
            this.btnViewCon.Size = new System.Drawing.Size(94, 69);
            this.btnViewCon.TabIndex = 2;
            this.btnViewCon.Text = "View/Edit Contract";
            this.btnViewCon.UseVisualStyleBackColor = false;
            this.btnViewCon.Click += new System.EventHandler(this.btnViewCon_Click);
            // 
            // btnSetDelTIme
            // 
            this.btnSetDelTIme.BackColor = System.Drawing.Color.White;
            this.btnSetDelTIme.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDelTIme.Location = new System.Drawing.Point(353, 83);
            this.btnSetDelTIme.Name = "btnSetDelTIme";
            this.btnSetDelTIme.Size = new System.Drawing.Size(110, 69);
            this.btnSetDelTIme.TabIndex = 3;
            this.btnSetDelTIme.Text = "Set Delivery Time";
            this.btnSetDelTIme.UseVisualStyleBackColor = false;
            this.btnSetDelTIme.Click += new System.EventHandler(this.btnSetDelTIme_Click);
            // 
            // btnAcceptDel
            // 
            this.btnAcceptDel.BackColor = System.Drawing.Color.White;
            this.btnAcceptDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptDel.Location = new System.Drawing.Point(494, 85);
            this.btnAcceptDel.Name = "btnAcceptDel";
            this.btnAcceptDel.Size = new System.Drawing.Size(90, 67);
            this.btnAcceptDel.TabIndex = 5;
            this.btnAcceptDel.Text = "Accept Deliveries";
            this.btnAcceptDel.UseVisualStyleBackColor = false;
            this.btnAcceptDel.Click += new System.EventHandler(this.btnAcceptDel_Click);
            // 
            // btnViewRep
            // 
            this.btnViewRep.BackColor = System.Drawing.Color.White;
            this.btnViewRep.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRep.Location = new System.Drawing.Point(294, 178);
            this.btnViewRep.Name = "btnViewRep";
            this.btnViewRep.Size = new System.Drawing.Size(90, 66);
            this.btnViewRep.TabIndex = 6;
            this.btnViewRep.Text = "View Reports";
            this.btnViewRep.UseVisualStyleBackColor = false;
            this.btnViewRep.Click += new System.EventHandler(this.btnViewRep_Click);
            // 
            // btnSetBreak
            // 
            this.btnSetBreak.BackColor = System.Drawing.Color.White;
            this.btnSetBreak.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBreak.Location = new System.Drawing.Point(429, 178);
            this.btnSetBreak.Name = "btnSetBreak";
            this.btnSetBreak.Size = new System.Drawing.Size(90, 66);
            this.btnSetBreak.TabIndex = 7;
            this.btnSetBreak.Text = "Set Break Time";
            this.btnSetBreak.UseVisualStyleBackColor = false;
            this.btnSetBreak.Click += new System.EventHandler(this.btnSetBreak_Click);
            // 
            // btnCanDel
            // 
            this.btnCanDel.BackColor = System.Drawing.Color.White;
            this.btnCanDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanDel.Location = new System.Drawing.Point(615, 86);
            this.btnCanDel.Name = "btnCanDel";
            this.btnCanDel.Size = new System.Drawing.Size(90, 66);
            this.btnCanDel.TabIndex = 8;
            this.btnCanDel.Text = "Cancel Delivery";
            this.btnCanDel.UseVisualStyleBackColor = false;
            this.btnCanDel.Click += new System.EventHandler(this.btnCanDel_Click);
            // 
            // FrmDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.btnCanDel);
            this.Controls.Add(this.btnSetBreak);
            this.Controls.Add(this.btnViewRep);
            this.Controls.Add(this.btnAcceptDel);
            this.Controls.Add(this.btnSetDelTIme);
            this.Controls.Add(this.btnViewCon);
            this.Controls.Add(this.btnCreateCon);
            this.Controls.Add(this.label1);
            this.Name = "FrmDash";
            this.Text = "BayWyn Dashboard";
            this.Load += new System.EventHandler(this.FrmDash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateCon;
        private System.Windows.Forms.Button btnViewCon;
        private System.Windows.Forms.Button btnSetDelTIme;
        private System.Windows.Forms.Button btnAcceptDel;
        private System.Windows.Forms.Button btnViewRep;
        private System.Windows.Forms.Button btnSetBreak;
        private System.Windows.Forms.Button btnCanDel;
    }
}