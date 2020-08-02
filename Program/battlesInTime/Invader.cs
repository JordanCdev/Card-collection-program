using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

using System.Windows.Forms;

namespace battlesInTime
{
    public partial class Invader : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source=C:\\Users\\jorda\\Documents\\BattleOfTimes.accdb");
        BindingSource bs;
        DataTable tbl;
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DBsetup Initialise = new DBsetup();

        public Invader() {
            InitializeComponent();
        }

        private void Invader_Load(object sender, EventArgs e) {

            string pullData = "SELECT cardNumber, cardTitle, rarity FROM Invader WHERE owned=false ORDER BY rarity DESC";
            string owned = "SELECT owned FROM Invader";
            Initialise.Connect();
            tbl = Initialise.tbl;
            bs = Initialise.bs;
            Initialise.QueryHandle(pullData, owned);
            invaderTbl.DataSource = bs;
            da.Fill(tbl);
            //dr = Initialise.dr;

            int own = 0, notOwn = 0;

            while (dr.Read()) {
                bool check = (bool)dr["owned"];

                if (check == true) {
                    own++;
                }
                else notOwn++;

            }
            conn.Close();
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
