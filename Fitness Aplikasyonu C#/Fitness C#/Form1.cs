using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void uyelerigoruntule()
        {
            con = new SqlConnection("Data Source=EMRE\\SQLEXPRESS02;Initial Catalog=Fitness;Integrated Security=True");
            da = new SqlDataAdapter("Select *From uyeler", con);
            ds = new DataSet();
            con.Open();
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uyelerigoruntule();
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form uyeekle = new uyeadd();
            uyeekle.Show();
            this.Hide();
        }

        private void üyeDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form uyeedit = new uyeedit();
            uyeedit.Show();
            this.Hide();
        }
        private void ödemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form odemeler = new odemeler();
            odemeler.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
