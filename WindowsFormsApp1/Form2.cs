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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void TextControl()
        {
            if (textBox1.Text != "" )
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form1.veri1)
            {
                this.Close();
                MessageBox.Show("Muhasebe programı şifreniz "+ Form1.veri2+"'dir.");    
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
