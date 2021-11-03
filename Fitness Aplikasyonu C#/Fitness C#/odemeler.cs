using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class odemeler : Form
    {
        public odemeler()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void odemeler_Load(object sender, EventArgs e)
        {
            comboboxGetir();
            odemeGetir();
        }
        private void comboboxGetir()
        {
            string[] aylar = new[] { "Bir Ay Seçiniz", "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            comboBox1.Items.AddRange(aylar);
            comboBox1.SelectedIndex = 0;
        }
        CustomerDal customerdal = new CustomerDal();
        private void odemeGetir()
        {
            dataGridView1.DataSource = customerdal.odemeGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerdal.odemeEkle(new Odeme { 
            uyeId =Convert.ToInt32(textBox3.Text),
            odenenay = Convert.ToString(comboBox1.Text),
            odenentutar = Convert.ToInt32(textBox4.Text),
            });
            MessageBox.Show("Ödemeler Eklendi");
            customerdal.odemeGetir();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
