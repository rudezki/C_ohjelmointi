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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void testaaTietokantayhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Arttu Pylkkö");
        }
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "[Syötä elokuvan nimi]")
            {
                textBox2.Text = string.Empty;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "[Syötä elokuvan nimi]";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "0")
            {
                textBox4.Text = string.Empty;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double d = 0.0, defaultRating = 5.0;
            textBox3.Text = DateTime.Now.Year.ToString();
            textBox1.Text = d.ToString();
            textBox2.Text = "[Syötä elokuvan nimi]";
            textBox4.Text = d.ToString();
            textBox5.Text = "[Syötä elokuvan arvio tähän]";
            numericUpDown1.Text = defaultRating.ToString();
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "[Syötä elokuvan arvio tähän]")
            {
                textBox5.Text = string.Empty;
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "[Syötä elokuvan arvio tähän]";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string syotto = textBox3.Text;
            int year, kesto;
            bool result;
            if (syotto == "")
            {
                MessageBox.Show("Et ole syöttänyt mitään julkaisuvuosi-kenttään!");
            }
            result = int.TryParse(syotto, out year);
            if (result == false)
            {
                MessageBox.Show("Julkaisuvuosi ei ole vain numeroita!");
            }
            syotto = textBox4.Text;
            if (syotto == "")
            {
                MessageBox.Show("Et ole syöttänyt mitään kesto-kenttään!");
            }
            result = int.TryParse(syotto, out kesto);
            if (result == false)
            {
                MessageBox.Show("Kesto ei ole vain numeroita");
            }
            else
            {
                MessageBox.Show("Check ok!");
            }
        }
    }
}
