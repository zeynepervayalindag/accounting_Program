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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 tt = new Form5();
            tt.Show();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 xx = new Form4();
            xx.Show();
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 yy = new Form6();
            yy.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
