using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlıs, matYanlıs;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(textBox1.Text);
            matDogru = Convert.ToDouble(textBox4.Text);
            turkceYanlıs = Convert.ToDouble(textBox2.Text);
            matYanlıs = Convert.ToDouble(textBox5.Text);
            turkceNet = (turkceDogru - (turkceYanlıs / 4));
            matNet = (matDogru - (matYanlıs / 4));
            textBox3.Text = turkceNet.ToString();
            textBox6.Text = matNet.ToString();
            textBox3.Enabled = false;
            textBox6.Enabled = false;
        }
    }
}
