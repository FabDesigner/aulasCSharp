using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "clicou";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSoma.Text = Convert.ToString(Convert.ToDecimal(txtNota1.Text) + Convert.ToDecimal(txtNota2.Text) +
                                            Convert.ToDecimal(txtNota3.Text) + Convert.ToDecimal(txtNota4.Text) +
                                            Convert.ToDecimal(txtNota5.Text) + Convert.ToDecimal(txtNota6.Text));

            txtMedia.Text = Convert.ToString((Convert.ToDecimal(txtNota1.Text) + Convert.ToDecimal(txtNota2.Text) +
                                            Convert.ToDecimal(txtNota3.Text) + Convert.ToDecimal(txtNota4.Text) +
                                            Convert.ToDecimal(txtNota5.Text) + Convert.ToDecimal(txtNota6.Text)) / 6);

            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtNota5.Text = "";
            txtNota6.Text = "";
            txtNota1.Focus();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
