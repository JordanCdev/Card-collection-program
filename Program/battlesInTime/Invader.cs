using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

using System.Windows.Forms;

namespace battlesInTime
{
    public partial class Invader : Form
    {
        BindingSource bs;
        DataTable tbl;
        OleDbDataReader dr;
        DBsetup Initialise = new DBsetup();

        public Invader() {
            InitializeComponent();
        }

        private void Invader_Load(object sender, EventArgs e) { 
            string pullData = "SELECT cardNumber, cardTitle, rarity FROM Invader WHERE owned=false ORDER BY rarity DESC";
            string owned = "SELECT owned FROM Invader";
            Initialise.Connect();
            Initialise.QueryHandle(pullData);
            Initialise.QueryHandle(owned);
            this.tbl = Initialise.DataTable(pullData);
            this.dr = Initialise.DataReader(owned);
            this.bs = new BindingSource(tbl, null);
            invaderTbl.DataSource = bs;
     
            int own = 0, notOwn = 0;

            while (dr.Read()) {
                bool check = (bool)dr["owned"];
                if (check == true) {
                    own++;
                }
                else notOwn++;
            }
            Initialise.Disconnect();

            double total = own + notOwn;
            double stat = own / total * (100.0);
            stat = Math.Round(stat, 1);

            amount.Text = "Cards owned: " + own + " out of " + total;
            label.Text = "Percentage owned: " + stat.ToString() + "%";
            chartObtained.Series["Owned"].Points.Add(own);
            chartObtained.Series["Owned"].Points[0].Color = Color.Green;
            chartObtained.Series["Owned"].Points.Add(notOwn);
            chartObtained.Series["Owned"].Points[1].Color = Color.Red;
            chartObtained.ChartAreas[0].AxisY.Maximum = total;
            chartObtained.ChartAreas[0].AxisY.Interval = 25;
        }
        private void goHome_Click(object sender, EventArgs e) {
            Form1 goHome = new Form1();
            this.Hide();
            goHome.Show();
        }
        private void Invader_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
