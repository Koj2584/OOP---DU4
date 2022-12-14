using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP___DU4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        Tahac tahac;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tahac = new Tahac(textBox1.Text, short.Parse(textBox2.Text), short.Parse(textBox3.Text));
                panel1.Enabled = true;
                label4.Text = "Hmotnost nákladu: "+tahac.HmotnostNakladu.ToString();
            }
            catch
            {
                MessageBox.Show("Chyba ve formátu vstupu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tahac.NalozNaklad(short.Parse(textBox4.Text));
                label4.Text = "Hmotnost nákladu: " + tahac.HmotnostNakladu.ToString();
            } catch
            {
                MessageBox.Show("Chyba ve formátu vstupu");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tahac.VylozNaklad(short.Parse(textBox5.Text));
                label4.Text = "Hmotnost nákladu: " + tahac.HmotnostNakladu.ToString();
            }
            catch
            {
                MessageBox.Show("Chyba ve formátu vstupu");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tahac.ToString());
        }
    }
}
