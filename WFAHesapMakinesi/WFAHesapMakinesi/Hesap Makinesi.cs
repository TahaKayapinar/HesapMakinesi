using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHesapMakinesi
{
    public partial class Form1 : Form
    {
        bool OptDurum = false;
        double sonuc = 0;
        string opt = "";



        public Form1()
        {
            InitializeComponent();
        }

       

        private void txtEkran_TextChanged(object sender, EventArgs e)
        {

        }



     

        private void Sayilar(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0" || OptDurum == true)
            {
                txtEkran.Clear();
            }

            OptDurum = false;
            Button btn = (Button)sender;
            txtEkran.Text += btn.Text;
        }

        private void OptHesap(object sender, EventArgs e)
        {
            OptDurum =  true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lblSonuc.Text = lblSonuc.Text + " " + txtEkran.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": txtEkran.Text = (sonuc + Double.Parse(txtEkran.Text)).ToString(); break;
                case "-": txtEkran.Text = (sonuc - Double.Parse(txtEkran.Text)).ToString(); break;
                case "*": txtEkran.Text = (sonuc * Double.Parse(txtEkran.Text)).ToString(); break;
                case "/": txtEkran.Text = (sonuc / Double.Parse(txtEkran.Text)).ToString(); break;
            }

            sonuc = double.Parse(txtEkran.Text);
            txtEkran.Text = sonuc.ToString();
            opt = yeniOpt;


        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
            lblSonuc.Text = "";
            opt = "";
            sonuc = 0;
            OptDurum = false;
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            OptDurum = true;
            switch (opt)
            {
                case "+": txtEkran.Text = (sonuc + Double.Parse(txtEkran.Text)).ToString(); break;
                case "-": txtEkran.Text = (sonuc - Double.Parse(txtEkran.Text)).ToString(); break;
                case "*": txtEkran.Text = (sonuc * Double.Parse(txtEkran.Text)).ToString(); break;
                case "/": txtEkran.Text = (sonuc / Double.Parse(txtEkran.Text)).ToString(); break;
            }

            sonuc = double.Parse(txtEkran.Text);
            //txtEkran.Text = sonuc.ToString();
            opt = "";

        }

        private void virgül_Click(object sender, EventArgs e)
        {
            OptDurum = false;
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "0";
            }
            else if (OptDurum)
            {
                txtEkran.Text = "0";
            }

            if (!txtEkran.Text.Contains(","))
            {
                txtEkran.Text += ",";
            }
        }
    }
}
