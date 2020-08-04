using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battlesInTime
{
    public partial class Exterminator : Form
    {
        DBsetup Initialise = new DBsetup();
        OleDbConnection conn;
        BindingSource bs;
        public Exterminator()
        {
            InitializeComponent();
        }

        private void Exterminator_Load(object sender, EventArgs e)
        {
            string pullData = "SELECT cardNumber, cardTitle, rarity FROM Exterminator WHERE owned1=false ORDER BY rarity DESC";
            string owned = "SELECT owned1 FROM Exterminator";
            Initialise.Connect();
            OleDbCommand cmd = new OleDbCommand(pullData, conn);
            OleDbCommand cmd2 = new OleDbCommand(owned, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            bs = new BindingSource(tbl, null);
            extermTbl.DataSource = bs;
            conn.Open();
            OleDbDataReader dr = cmd2.ExecuteReader();
           
            int own = 0;
            int notOwn = 0;
            while (dr.Read())
            {
                bool check = (bool)dr["owned1"];

                if (check == true)
                {
                    own++;
                }
                else notOwn++;

            }
            
            conn.Close();
            double total = own + notOwn;
            double stat = own/total * (100.0);
            stat = Math.Round(stat, 1);

            amount.Text = "Cards owned: " + own + " out of " +total;
            label.Text = "Percentage owned: " + stat.ToString() + "%";

            chartObtained.Series["Owned"].Points.Add(own);
            chartObtained.Series["Owned"].Points[0].Color = Color.Green;
            chartObtained.Series["Owned"].Points.Add(notOwn);
            chartObtained.Series["Owned"].Points[1].Color = Color.Red;
            //chartObtained.ChartAreas[0].RecalculateAxesScale(); //automatic
            chartObtained.ChartAreas[0].AxisY.Maximum = 275;
            chartObtained.ChartAreas[0].AxisY.Interval = 25;
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            Form1 goHome = new Form1();
            this.Hide();
            goHome.Show();
        }

        private void Exterminator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
