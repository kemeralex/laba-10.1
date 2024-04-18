using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_kf_f_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private string vara;
        private double S;
        private double V;

        private void button1_Click_1(object sender, EventArgs e)
        {
            double divis = V / S;
            textBox1.Text = Convert.ToString(divis);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            vara = textBox2.Text;
            V = double.Parse(vara);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            vara = textBox3.Text;
            S = double.Parse(vara);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
