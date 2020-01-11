using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double q;
        private double w;
        private double t;
        private double y;
        private double i;
        private double o;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            q = Convert.ToInt32(textBox1.Text);
            w = Convert.ToInt32(textBox2.Text);
            t = Convert.ToInt32(textBox4.Text);
            o = Convert.ToInt32(textBox3.Text);
            i = (q / 100)*o;
            y = ((q - w)+i)/t;           
            textBox5.Text = Convert.ToString(y);

        }

       
    }
}
