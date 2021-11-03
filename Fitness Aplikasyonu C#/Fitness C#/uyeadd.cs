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
    public partial class uyeadd : Form
    {
        public uyeadd()
        {
            InitializeComponent();
        }

        private void uyeadd_Load(object sender, EventArgs e)
        {
            string[] cinsiyetler = new[] { "Belirtmek İstemiyorum","Erkek","Kadın"};
            comboBox1.Items.AddRange(cinsiyetler);
            comboBox1.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
double boy, kilo, endex;
 kilo = Convert.ToDouble(textBox6.Text);
boy = Convert.ToDouble(textBox5.Text);
            double idealKilo;
            boy = Convert.ToDouble(textBox5.Text);
            endex = kilo / (Math.Pow(boy, 2));
            idealKilo = Math.Pow(boy, 2) * 23;
            if (endex > 0 && endex <= 18.4)
            {
                label14.Text = "Durum : Kilonuz Zayıf";
                label15.Text="İndeksiniz = " + endex;
            }
            else if (endex > 18.5 && endex <= 24.9)
            {
                label14.Text = "Durum : Kilonuz Normal";
                label15.Text = "İndeksiniz = " + endex;
            }
            else if (endex > 25.0 && endex <= 29.9)
            {
                label14.Text = "Durum : Fazla Kilolusunuz";
                label15.Text = "İndeksiniz = " + endex;
            }
            else if (endex > 30.0 && endex <= 34.9)
            {
                label14.Text = "Durum : 1. Sınıf Obezsiniz";
                label15.Text = "İndeksiniz = " + endex;
            }
            else if (endex > 35.0 && endex <= 44.9)
            {
                label14.Text = "Durum : 2. Sınıf Obezsiniz";
                label15.Text = "İndeksiniz = " + endex;
            }
            else if (endex >= 45.0)
            {
                label14.Text = "Durum : 3. Sınıf Obezsiniz";
                label15.Text = "İndeksiniz = " + endex;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        CustomerDal _customerDal = new CustomerDal();
        private void button1_Click(object sender, EventArgs e)
        {
            _customerDal.musteriekle(new Customer
            {
                uyeAdi = textBox1.Text,
                uyeSoyadi= textBox2.Text,
                yas =Convert.ToInt32(textBox3.Text),
                cinsiyet= comboBox1.Text,
                telefon = Convert.ToInt64(textBox4.Text),
                uyeBoy = Convert.ToDouble(textBox5.Text),
                uyeKilo = Convert.ToDouble(textBox6.Text),
                uyeGogus = Convert.ToDouble(textBox7.Text),
                uyeOmuz = Convert.ToDouble(textBox8.Text),
                uyeKol = Convert.ToDouble(textBox9.Text),
                uyeBel = Convert.ToDouble(textBox10.Text),
              
            });
            MessageBox.Show("Veriler Eklendi");
            _customerDal.GetAllList();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
