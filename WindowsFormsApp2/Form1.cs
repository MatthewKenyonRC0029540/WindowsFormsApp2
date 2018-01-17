using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

         
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i1 = 3 + 4;
            int i2 = 12 / 4;
            int i3 = 15 / 4;
            int i4 = 15 % 4;
            int i5 = 2 + 3 * 4;
            int i6 = 2 + (3 * 4) / (2 - 4);
            double d1 = 3.1 * 2.3;
            double d2 = 1.0 / 3.0;
            double d3 = 1 / 3;
            double d4 = Math.Sqrt(49);
            double d5 = Math.Pow(5, 3);
            double d6 = Math.Pow(27, 1.0 / 3.0);
            double d7 = Math.Sin(45);
            double d8 = Math.Cos(45);
            double d9 = Math.Tan(45);

            richTextBox1.AppendText(i1 + "\n" + i2 + "\n" + i3 + "\n" + i4 + "\n" + i5 + "\n" + i6 + "\n");
            richTextBox1.AppendText(d1 + "\n" + d2 + "\n" + d3 + "\n");
            richTextBox1.AppendText(d4 + "\n" + d5 + "\n" + d6 + "\n");
            richTextBox1.AppendText(d7 + "\n" + d8 + "\n" + d9 + "\n");
           


        }


        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
         
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        



    }
}
