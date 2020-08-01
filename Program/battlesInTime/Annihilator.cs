using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace battlesInTime
{
    public partial class Annihilator : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source=C:\\Users\\jorda\\Documents\\BattleOfTimes.accdb");
        BindingSource bs;
        public Annihilator()
        {
            InitializeComponent();
        }

        private void Annihilator_Load(object sender, EventArgs e)
        {

            string pullData = "SELECT cardNumber, cardTitle, rarity FROM Annihilator WHERE owned=false ORDER BY rarity DESC";
            string owned = "SELECT owned FROM Annihilator";

            OleDbCommand cmd = new OleDbCommand(pullData, conn);
            OleDbCommand cmd2 = new OleDbCommand(owned, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            bs = new BindingSource(tbl, null);
            annihTbl.DataSource = bs;
            conn.Open();
            OleDbDataReader dr = cmd2.ExecuteReader();

            int own = 0;
            int notOwn = 0;

            while (dr.Read())
            {
                bool check = (bool)dr["owned"];

                if (check == true)
                {
                    own++;
                }
                else notOwn++;

            }

            conn.Close();
            double total = own + notOwn;
            double stat = own / total * (100.0);
            stat = Math.Round(stat, 1);

            amount.Text = "Cards owned: " + own + " out of " +total;
            label.Text = "Percentage owned: " + stat.ToString() + "%";

            chartObtained.Series["Owned"].Points.Add(own);
            chartObtained.Series["Owned"].Points[0].Color = Color.Green;
            chartObtained.Series["Owned"].Points.Add(notOwn);
            chartObtained.Series["Owned"].Points[1].Color = Color.Red;
            //chartObtained.ChartAreas[0].RecalculateAxesScale(); //automatic
            chartObtained.ChartAreas[0].AxisY.Maximum = total;
            chartObtained.ChartAreas[0].AxisY.Interval = 25;
        
    }

        private void goHome_Click(object sender, EventArgs e)
        {
            Form1 goHome = new Form1();
            this.Hide();
            goHome.Show();
        }

        private void Annihilator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
