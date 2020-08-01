namespace battlesInTime
{
    partial class UltimateMonsters
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.goHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.chartObtained = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.extTbl = new System.Windows.Forms.DataGridView();
            this.homePG_ttl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartObtained)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // goHome
            // 
            this.goHome.Location = new System.Drawing.Point(590, 17);
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(75, 37);
            this.goHome.TabIndex = 27;
            this.goHome.Text = "Home";
            this.goHome.UseVisualStyleBackColor = true;
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.percent);
            this.groupBox1.Controls.Add(this.amount);
            this.groupBox1.Location = new System.Drawing.Point(17, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 77);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(7, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 2;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(0, 40);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(0, 13);
            this.percent.TabIndex = 1;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(7, 10);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(0, 13);
            this.amount.TabIndex = 0;
            // 
            // chartObtained
            // 
            chartArea3.Name = "ChartArea1";
            this.chartObtained.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartObtained.Legends.Add(legend3);
            this.chartObtained.Location = new System.Drawing.Point(381, 69);
            this.chartObtained.Name = "chartObtained";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.Name = "Owned";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "Not Owned";
            this.chartObtained.Series.Add(series5);
            this.chartObtained.Series.Add(series6);
            this.chartObtained.Size = new System.Drawing.Size(300, 300);
            this.chartObtained.TabIndex = 25;
            this.chartObtained.Text = "Comparision to cards obtained";
            title3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            title3.Name = "ownRep";
            title3.Text = "Comparision of obtainment.";
            this.chartObtained.Titles.Add(title3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cards remaining:";
            // 
            // extTbl
            // 
            this.extTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.extTbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.extTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extTbl.Location = new System.Drawing.Point(17, 90);
            this.extTbl.Name = "extTbl";
            this.extTbl.Size = new System.Drawing.Size(333, 147);
            this.extTbl.TabIndex = 23;
            // 
            // homePG_ttl
            // 
            this.homePG_ttl.AutoSize = true;
            this.homePG_ttl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePG_ttl.Location = new System.Drawing.Point(12, 20);
            this.homePG_ttl.Name = "homePG_ttl";
            this.homePG_ttl.Size = new System.Drawing.Size(347, 25);
            this.homePG_ttl.TabIndex = 22;
            this.homePG_ttl.Text = "Battles In Time (Ultimate Monsters)";
            // 
            // UltimateMonsters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 388);
            this.Controls.Add(this.goHome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartObtained);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extTbl);
            this.Controls.Add(this.homePG_ttl);
            this.Name = "UltimateMonsters";
            this.Text = "UltimateMonsters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UltimateMonsters_FormClosing);
            this.Load += new System.EventHandler(this.UltimateMonsters_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartObtained)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartObtained;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView extTbl;
        private System.Windows.Forms.Label homePG_ttl;
    }
}