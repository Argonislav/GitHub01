using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text);
            double soucet = a + b, rozdil = a - b, soucin = a * b, podil = a / b;
            MessageBox.Show("" + soucet);
            MessageBox.Show("" + rozdil);
            MessageBox.Show("" + soucin);
            MessageBox.Show("" + podil);
        }
    }
}
