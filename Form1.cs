using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayı_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0, tahmin_sayisi = 0, puan = 1000;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahmin_sayisi++;
            if (tahmin_sayisi<=10)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text = tahmin_sayisi.ToString();
                if (sayi < tahmin)
                {
                    
                    label5.Text = "SAYIYI KÜÇÜLT..";
                    puan -= 100;
                    label7.Text = Convert.ToString(puan);
                }
                else if (sayi == tahmin)
                {
                    label5.Text = "TAM İSABET!!" + label6.Text + " defada bilip" + label7.Text + " puan aldınız..";
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
                else
                {
                    
                    label5.Text = "SAYIYI BÜYÜT..";
                    puan -= 100;
                    label7.Text = Convert.ToString(puan);
                }
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Tahmin hakkınız kalmadı..Oyun kapanıyor..");
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random rnd = new Random();
            sayi = rnd.Next(0, 100);
            label8.Text = Convert.ToString(sayi);
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";

        }
    }
}
