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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            label11.Text = Form6.veri1;
            label12.Text = Form6.veri2;
            label13.Text = Form6.veri3;
            label14.Text = Form6.veri4;
            label15.Text = Form6.veri5;
            label16.Text = Form6.veri6;
            label1.Text = Form6.veri8;
            label17.Text = Form6.veri9;
            label18.Text = Form6.veri10;
            label19.Text = Form6.veri11;
            label20.Text = Form6.veri12;
            label21.Text = Form6.veri13;
            label24.Text= "Toplam fiyat " + Form6.veri7 + ".";
            if (Form6.veri14 != "0")
            {
                label25.Text = Form6.veri14;
            }
            if (Form6.veri15 != "0")
            {
                label26.Text = Form6.veri15;
            }
            if (Form6.veri16 != "0")
            {
                label27.Text = Form6.veri16;
            }
            if (Form6.veri17 != "0")
            {
                label28.Text = Form6.veri17;
            }
            if (Form6.veri18 != "0")
            {
                label29.Text = Form6.veri18;
            }
            if (Form6.veri19 != "0")
            {
                label30.Text = Form6.veri19;
            }
            
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
