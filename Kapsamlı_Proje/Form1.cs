using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapsamlı_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = sayi1 + sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int i;
            for (i = 1;i <= 10; i++)
            {
                toplam += i;
            }
            textBox3.Text = toplam.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int kare = sayi1 * sayi1;
            textBox3.Text = kare.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 % 2 == 0)
            {
                textBox3.Text = "Çift";
            }
            else
            {
                textBox3.Text = "Tek";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 120; i++)
            {
                if (120 % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Eymen Uraş tarafından yapılmıştır.", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
