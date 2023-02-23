using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Form5.veri7;
            label17.Text = Form5.veri8;
            label18.Text = Form5.veri9;
            label19.Text = Form5.veri10;
            label20.Text = Form5.veri11;
            label21.Text = Form5.veri12;
        }

        public void Form6_Load(object sender, EventArgs e)
        {
            label11.Text = Form4.veri1;
            label12.Text = Form4.veri2;
            label13.Text = Form4.veri3;
            label14.Text = Form4.veri4;
            label15.Text = Form4.veri5;
            label16.Text = Form4.veri6;
            
        }
        
private void label15_Click(object sender, EventArgs e)
        {

        }
        public static string veri1,veri2,veri3,veri4,veri5,veri6,veri7,veri8,veri9,veri10,veri11,veri12,veri13,veri14,veri15,veri16,veri17,veri18,veri19;
        
        private void button3_Click(object sender, EventArgs e)
        {
            Fatura fatura1 = new Fatura();
            fatura1.sonuc = 16.04 * Convert.ToInt32(numericUpDown1.Value) + 25.33 * Convert.ToInt32(numericUpDown2.Value) + 95.88 * Convert.ToInt32(numericUpDown3.Value) + 459.95 * Convert.ToInt32(numericUpDown4.Value) + 39.57 * Convert.ToInt32(numericUpDown5.Value) + 7.25 * Convert.ToInt32(numericUpDown6.Value);
            label24.Text = "Toplam fiyat " + fatura1.sonuc + ".";
            veri1 = fatura1.unvan;
            veri2= fatura1.vergidairesi;
            veri3 = fatura1.verginumarasi;
            veri4 = fatura1.adres;
            veri5 = fatura1.telefonnumarasi;
            veri6 = fatura1.mailadresi;
            veri7 = fatura1.sonuc.ToString();
            veri8 = label1.Text;
            veri9= label17.Text;
            veri10= label18.Text;
            veri11= label19.Text;   
            veri12= label20.Text;
            veri13 = label21.Text;
            veri14 = Convert.ToString(numericUpDown1.Value);
            veri15 = Convert.ToString(numericUpDown2.Value);
            veri16 = Convert.ToString(numericUpDown3.Value);
            veri17 = Convert.ToString(numericUpDown4.Value);
            veri18 = Convert.ToString(numericUpDown5.Value);
            veri19 = Convert.ToString(numericUpDown6.Value);
        }
        class Cari
        {
            public string unvan = Form4.veri1;
            public string vergidairesi = Form4.veri2;
            public string verginumarasi = Form4.veri3;
            public string adres = Form4.veri4;
            public string telefonnumarasi = Form4.veri5;
            public string mailadresi = Form4.veri6;
        }
        class Fatura : Cari
        {
            public double sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 jj=new Form7();
            Form6.ActiveForm.Hide();
            jj.Show();
        }
    }
    

}
