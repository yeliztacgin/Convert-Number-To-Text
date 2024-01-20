using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertNumberToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string bir, on, yuz;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int birler, onlar, yuzler;

            birler = sayi % 10;
            sayi = sayi - birler;
            onlar = sayi % 100;
            yuzler = sayi - onlar;
            switch (yuzler)
            {
                case 100:yuz = "yuz";break;
                case 200: yuz = "ikiyuz"; break;
                case 300: yuz = "ucyuz"; break;
                case 400: yuz = "dortyuz"; break;
                case 500: yuz = "besyuz"; break;
                case 600: yuz = "altiyuz"; break;
                case 700: yuz = "yediyuz"; break;
                case 800: yuz = "sekizyuz"; break;
                case 900: yuz = "dokuzyuz"; break;
            }
            switch (onlar)
            {
                case 10: on = "on"; break;
                case 20: on = "yirmi"; break;
                case 30: on = "otuz"; break;
                case 40: on = "kirk"; break;
                case 50: on = "elli"; break;
                case 60: on = "altmis"; break;
                case 70: on = "yetmis"; break;
                case 80: on = "seksen"; break;
                case 90: on = "doksan"; break;
            }
            switch (birler)
            {
                case 1: bir = "bir"; break;
                case 2: bir = "iki"; break;
                case 3: bir = "uc"; break;
                case 4: bir = "dort"; break;
                case 5: bir = "bes"; break;
                case 6: bir = "alti"; break;
                case 7: bir = "yedi"; break;
                case 8: bir = "sekiz"; break;
                case 9: bir = "dokuz"; break;
            }

            label1.Text = yuz + on + bir;

        }
    }
}
