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
    public class DBsetup
    {
        public OleDbConnection con;
        public DataTable tbl;
        public BindingSource bs;
        public OleDbDataAdapter da;
        public OleDbDataReader dr;

        public void Connect() {
            string path = "Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source=J:\\Users\\Jordan\\Documents\\GitHub\\DoctorWho_CardCollection\\Database\\BattleOfTimes.mdb";
            con = new OleDbConnection(path);
            tbl = new DataTable();
            bs = new BindingSource(tbl, null);
            con.Open();
        }
        public void QueryHandle(string query) {
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        public OleDbDataReader DataReader(string query) {
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataTable DataTable(string query) {
            OleDbDataAdapter da = new OleDbDataAdapter(query, con);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            return tbl;
        }
        public void Disconnect() {
            con.Close();
        }
    }
    public partial class Form1 : Form
    {
        DBsetup process = new DBsetup();
        BindingSource bs;
        OleDbDataReader dr;
        public Form1() {
            InitializeComponent();
        }

        private void goToExterminator_Click(object sender, EventArgs e) {
            Exterminator openExterminator = new Exterminator();
            this.Hide();
            openExterminator.Show();

        }
        private void goToAnnihilator_Click(object sender, EventArgs e) {
            Annihilator openAnnihilator = new Annihilator();
            this.Hide();
            openAnnihilator.Show();
        }

        private void goToInvader_Click(object sender, EventArgs e) {
            Invader openInvalid = new Invader();
            this.Hide();
            openInvalid.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void goToDev_Click(object sender, EventArgs e) {
            Devastator openDev = new Devastator();
            this.Hide();
            openDev.Show();
        }

        private void goToUlti_Click(object sender, EventArgs e) {
            UltimateMonsters openUlt = new UltimateMonsters();
            this.Hide();
            openUlt.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {
            process.Connect();
            string count = "Select Count(*) As 'Number Owned' FROM(SELECT ID1 FROM Exterminator Where owned = true UNION ALL SELECT ID2 FROM Annihilator Where owned = true)";
            process.QueryHandle(count);
            dr = process.DataReader(count);
           
            while (dr.Read()) {
                total_lbl.Text = dr[0].ToString();
            }
            process.Disconnect();
        }
    }
}
