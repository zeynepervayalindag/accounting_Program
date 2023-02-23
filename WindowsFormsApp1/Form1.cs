using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Firma firma1 = new Firma("05319176700", "zeynepervayalindag", "zyalindag@hotmail.com","111","001");
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != firma1.Telefonno && textBox1.Text != firma1.Kullaniciadi && textBox1.Text != firma1.Emailadres)
            {
                label3.Text = "Girdiğin kullanıcı adı bir hesaba ait değil.\nLütfen kullanıcı adını kontrol et ve tekrar dene.";
            }
            else if (textBox2.Text != firma1.Sifre)
            {
                label3.Text = "Üzgünüz, şifren yanlıştı. Lütfen şifreni dikkatlice kontrol et.";
            }
            else if (textBox3.Text != firma1.Firmano)
            {
                label3.Text="Üzgünüz, firma nonuz yanlıştı. Lütfen firma nonu dikkatlice kontrol et.";
            }
            else
            {
                Form1.ActiveForm.Hide();
                Form3 cc = new Form3();
                cc.Show();
            }
         }
        private void TextControl()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            { 
                button1.Enabled = true;
            }
            else
            { 
                button1.Enabled = false; 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextControl();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextControl();
            textBox2.PasswordChar = '*';
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel3.Text == "Göster")
            {
                textBox2.PasswordChar = '\0';
                linkLabel3.Text = "Gizle";
            }
            else if ( linkLabel3.Text == "Gizle")
            {
                textBox2.PasswordChar = '*';
                linkLabel3.Text = "Göster";
            }
        }
        public static string veri1, veri2;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 ff = new Form2();
            veri1 = firma1.Emailadres;
            veri2 = firma1.Sifre;
            ff.Show();
            
        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextControl();
            
        }
    }
    class Firma
    {
        private string telefonno;
        private string kullaniciadi;
        private string emailadres;
        private string sifre;
        private string firmano;
        public string Telefonno
        {
            set
            {
                telefonno = value;
            }
            get
            {
                return telefonno;
            }
        }
        public string Kullaniciadi
        {
            set
            {
                kullaniciadi = value;
            }
            get
            {
                return kullaniciadi;
            }
        }
        public string Emailadres
        {
            set
            {
                emailadres = value;
            }
            get
            {
                return emailadres;
            }
        }
        public string Sifre
        {
            set
            {
                sifre = value;
            }
            get
            {
                return sifre;
            }
        }
        public string Firmano
        {
            set
            {
                firmano = value;
            }
            get
            {
                return firmano;
            }
        }
        public Firma(string telefonno, string kullaniciadi, string emailadres, string sifre, string firmano)
        {
            this.telefonno = telefonno;
            this.kullaniciadi = kullaniciadi;
            this.emailadres = emailadres;
            this.sifre = sifre;
            this.firmano = firmano;
        }
    }
}
