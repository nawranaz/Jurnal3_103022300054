using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Jurnal3_103022300054
{
    public partial class Form1 : Form
    {
        int hasil = 0;
        string output = "";
        int a, b;
        bool multiple = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil = int.Parse(label1.Text)+ a;
            label1.Text = hasil.ToString();
            hasil = 0;
            multiple = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (!multiple)
            {
                hasil += 1;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 1;
            }
            label1.Text = hasil.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 2;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 2;
            }
            label1.Text = hasil.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 3;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 3;
            }
            label1.Text = hasil.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 4;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 4;
            }
            label1.Text = hasil.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 5;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 5;
            }
            label1.Text = hasil.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 6;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 6;
            }
            label1.Text = hasil.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 7;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 7;
            }
            label1.Text = hasil.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 8;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 8;
            }
            label1.Text = hasil.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 9;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 9;
            }
            label1.Text = hasil.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!multiple)
            {
                hasil += 0;
                multiple = true;
            }
            else
            {
                hasil = (hasil * 10) + 0;
            }
            label1.Text = hasil.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            a = hasil;
           label1.Text = "+";
            hasil = 0;

        }
    }
}
