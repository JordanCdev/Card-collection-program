namespace battlesInTime
{
    partial class Form1
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
            this.goToExterminator = new System.Windows.Forms.Button();
            this.goToInvader = new System.Windows.Forms.Button();
            this.goToDev = new System.Windows.Forms.Button();
            this.goToAnnihilator = new System.Windows.Forms.Button();
            this.homePG_ttl = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.GroupBox();
            this.goToUlti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.total_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goToExterminator
            // 
            this.goToExterminator.Location = new System.Drawing.Point(42, 93);
            this.goToExterminator.Name = "goToExterminator";
            this.goToExterminator.Size = new System.Drawing.Size(115, 45);
            this.goToExterminator.TabIndex = 0;
            this.goToExterminator.Text = "Exterminator";
            this.goToExterminator.UseVisualStyleBackColor = true;
            this.goToExterminator.Click += new System.EventHandler(this.goToExterminator_Click);
            // 
            // goToInvader
            // 
            this.goToInvader.Location = new System.Drawing.Point(383, 93);
            this.goToInvader.Name = "goToInvader";
            this.goToInvader.Size = new System.Drawing.Size(115, 45);
            this.goToInvader.TabIndex = 6;
            this.goToInvader.Text = "Invader";
            this.goToInvader.UseVisualStyleBackColor = true;
            this.goToInvader.Click += new System.EventHandler(this.goToInvader_Click);
            // 
            // goToDev
            // 
            this.goToDev.Location = new System.Drawing.Point(212, 192);
            this.goToDev.Name = "goToDev";
            this.goToDev.Size = new System.Drawing.Size(115, 45);
            this.goToDev.TabIndex = 7;
            this.goToDev.Text = "Devastator";
            this.goToDev.UseVisualStyleBackColor = true;
            this.goToDev.Click += new System.EventHandler(this.goToDev_Click);
            // 
            // goToAnnihilator
            // 
            this.goToAnnihilator.Location = new System.Drawing.Point(212, 93);
            this.goToAnnihilator.Name = "goToAnnihilator";
            this.goToAnnihilator.Size = new System.Drawing.Size(115, 45);
            this.goToAnnihilator.TabIndex = 8;
            this.goToAnnihilator.Text = "Annihilator";
            this.goToAnnihilator.UseVisualStyleBackColor = true;
            this.goToAnnihilator.Click += new System.EventHandler(this.goToAnnihilator_Click);
            // 
            // homePG_ttl
            // 
            this.homePG_ttl.AutoSize = true;
            this.homePG_ttl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePG_ttl.Location = new System.Drawing.Point(37, 22);
            this.homePG_ttl.Name = "homePG_ttl";
            this.homePG_ttl.Size = new System.Drawing.Size(154, 25);
            this.homePG_ttl.TabIndex = 9;
            this.homePG_ttl.Text = "Battles In Time";
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(566, 93);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(310, 155);
            this.summary.TabIndex = 10;
            this.summary.TabStop = false;
            this.summary.Text = "Most Wanted";
            // 
            // goToUlti
            // 
            this.goToUlti.Location = new System.Drawing.Point(42, 192);
            this.goToUlti.Name = "goToUlti";
            this.goToUlti.Size = new System.Drawing.Size(115, 45);
            this.goToUlti.TabIndex = 11;
            this.goToUlti.Text = "Ultimate Monsters";
            this.goToUlti.UseVisualStyleBackColor = true;
            this.goToUlti.Click += new System.EventHandler(this.goToUlti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.total_lbl);
            this.groupBox1.Location = new System.Drawing.Point(383, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 82);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(7, 20);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(0, 13);
            this.total_lbl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goToUlti);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.homePG_ttl);
            this.Controls.Add(this.goToAnnihilator);
            this.Controls.Add(this.goToDev);
            this.Controls.Add(this.goToInvader);
            this.Controls.Add(this.goToExterminator);
            this.Name = "Form1";
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToExterminator;
        private System.Windows.Forms.Button goToInvader;
        private System.Windows.Forms.Button goToDev;
        private System.Windows.Forms.Button goToAnnihilator;
        private System.Windows.Forms.Label homePG_ttl;
        private System.Windows.Forms.GroupBox summary;
        private System.Windows.Forms.Button goToUlti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label total_lbl;
    }
}

