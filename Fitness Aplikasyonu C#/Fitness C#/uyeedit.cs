using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class uyeedit : Form
    {
        public uyeedit()
        {
            InitializeComponent();
        }

        private void uyeedit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerDal.GetAllList();


        }
        CustomerDal customerDal = new CustomerDal();
        private void button2_Click(object sender, EventArgs e)
        {
            customerDal.musteriguncelle(new Customer
            {
                uyeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                uyeAdi = textBox1.Text,
                uyeSoyadi = textBox2.Text,
                yas = Convert.ToInt32(textBox3.Text),
                cinsiyet = comboBox1.Text,
                telefon = Convert.ToInt64(textBox4.Text),
                uyeBoy = Convert.ToDouble(textBox5.Text),
                uyeKilo = Convert.ToDouble(textBox6.Text),
                uyeGogus = Convert.ToDouble(textBox7.Text),
                uyeOmuz = Convert.ToDouble(textBox8.Text),
                uyeKol = Convert.ToDouble(textBox9.Text),
                uyeBel = Convert.ToDouble(textBox10.Text),
            });
            MessageBox.Show("Veriler Güncellendi");
            customerDal.GetAllList();
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            comboBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            textBox5.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            textBox7.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            textBox8.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
            textBox9.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
            textBox10.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerDal.musteriSil(new Customer { 
            uyeId=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
            });
            MessageBox.Show("Veriler Silindi");
            customerDal.GetAllList();
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
