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
    public partial class Devastator : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source=C:\\Users\\jorda\\Documents\\BattleOfTimes.accdb");
        BindingSource bs;
        public Devastator()
        {
            InitializeComponent();
        }

        private void Devastator_Load(object sender, EventArgs e)
        {
            string pullData = "SELECT cardNumber, cardTitle, rarity FROM Devastator WHERE owned=false ORDER BY rarity DESC, cardNumber ASC";
            string owned = "SELECT owned FROM Devastator";

            OleDbCommand cmd = new OleDbCommand(pullData, conn);
            OleDbCommand cmd2 = new OleDbCommand(owned, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           
            conn.Open();
            OleDbDataReader dr = cmd2.ExecuteReader();

            int own = 0;
            int notOwn = 0;
            while (dr.Read())
            {
                bool check = (bool)dr["Owned"];

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

            amount.Text = "Cards owned: " + own + " out of " + total;
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

        private void Devastator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
