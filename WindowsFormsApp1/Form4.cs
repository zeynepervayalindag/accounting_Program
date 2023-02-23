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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        
        private void TextControl()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        public static string veri1,veri2,veri3,veri4,veri5,veri6;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 10)
            {
                label8.Text = "Vergi numarası yanlıştı. Lütfen vergi numarasını kontrol et.";
            }
            else if (textBox5.Text.Length != 11)
            {
                label8.Text = "Telefon numarası yanlıştı. Lütfen telefon numarasını kontrol et.";
            }
            else
            {
                veri1 = textBox3.Text;
                veri2 = textBox2.Text;
                veri3 = textBox1.Text;
                veri4 = textBox4.Text;
                veri5 = textBox5.Text;
                veri6 = textBox6.Text;
                this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextControl();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextControl();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextControl();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextControl();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TextControl();
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TextControl();
        }
    }
}
