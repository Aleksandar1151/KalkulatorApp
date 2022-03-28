using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorApp
{
    public partial class Form1 : Form
    {
        double prviBroj;  
        double drugiBroj;
        string operacija; 
        double rezultat;
        public Form1()
        {
            InitializeComponent();
            postavljanjeBoja();
           
        }

        void postavljanjeBoja()
        {
            string boje_prvaKolona = "#b76935";
            string boje_drugaKolona = "#b76935";
            string boje_trecaKolona = "#b76935";
            string boje_cetvrtaKolona = "#6f523b";

            
            //Svijetlja pozadina
            //BackColor =  ColorTranslator.FromHtml("#ffe6a7"); 

            //Tamna pozadina
            BackColor =  ColorTranslator.FromHtml("#333533");

            dugme7.BackColor =  ColorTranslator.FromHtml(boje_prvaKolona);
            dugme8.BackColor =  ColorTranslator.FromHtml(boje_drugaKolona);
            dugme9.BackColor =  ColorTranslator.FromHtml(boje_trecaKolona);
            dugmeSabiranje.BackColor =  ColorTranslator.FromHtml(boje_cetvrtaKolona);

            dugme4.BackColor =  ColorTranslator.FromHtml(boje_prvaKolona);
            dugme5.BackColor =  ColorTranslator.FromHtml(boje_drugaKolona);
            dugme6.BackColor =  ColorTranslator.FromHtml(boje_trecaKolona);
            dugmeOduzimanje.BackColor = ColorTranslator.FromHtml(boje_cetvrtaKolona);

            dugme1.BackColor =  ColorTranslator.FromHtml(boje_prvaKolona);
            dugme2.BackColor =  ColorTranslator.FromHtml(boje_drugaKolona);
            dugme3.BackColor =  ColorTranslator.FromHtml(boje_trecaKolona);
            dugmeMnozenje.BackColor =  ColorTranslator.FromHtml(boje_cetvrtaKolona);

            dugme0.BackColor =  ColorTranslator.FromHtml(boje_prvaKolona);
            dugmeJednako.BackColor =  ColorTranslator.FromHtml("#263C41"); //D69971  13333F
            dugmeDijeljenje.BackColor =  ColorTranslator.FromHtml(boje_cetvrtaKolona);

            dugmeOcisti.BackColor = ColorTranslator.FromHtml(boje_cetvrtaKolona);
        }

        private void DodajBroj(double broj)
        {
            if (rezultatBox.Text == "0" && rezultatBox.Text != null)  
            {  
                rezultatBox.Text = Convert.ToString(broj);  
            }  
            else  
            {  
                rezultatBox.Text = rezultatBox.Text + broj;  
            }  
        }

        private void Dugme0Klik(object sender, EventArgs e)
        {
            DodajBroj(0);           
        }

        private void Dugme1Klik(object sender, EventArgs e)
        {
            DodajBroj(1);
        }

        private void Dugme2Klik(object sender, EventArgs e)
        {
           DodajBroj(2);
        }

        private void Dugme3Klik(object sender, EventArgs e)
        {
           DodajBroj(3);
        }

        private void Dugme4Klik(object sender, EventArgs e)
        {
            DodajBroj(4);
        }

        private void Dugme5Klik(object sender, EventArgs e)
        {
            DodajBroj(5);
        }

        private void Dugme6Klik(object sender, EventArgs e)
        {
            DodajBroj(6);
        }

        private void Dugme7Klik(object sender, EventArgs e)
        {
            DodajBroj(7); 
        }

        private void Dugme8Klik(object sender, EventArgs e)
        {
            DodajBroj(8);
        }

        private void Dugme9Klik(object sender, EventArgs e)
        {
            DodajBroj(9); 
        }

        private void DugmeSabiranjeKlik(object sender, EventArgs e)
        {
            prviBroj = double.Parse(rezultatBox.Text);
            operacija = "+";

            labelIstorija.Text = rezultatBox.Text +" "+ operacija;
            rezultatBox.Text = "0";
            
        }

        private void DugmeOduzimanjeKlik(object sender, EventArgs e)
        {
            prviBroj = double.Parse(rezultatBox.Text);
            operacija = "-";

            labelIstorija.Text = rezultatBox.Text +" "+ operacija;
            rezultatBox.Text = "0";
        }

        private void DugmeMnozenjeKlik(object sender, EventArgs e)
        {
            prviBroj = double.Parse(rezultatBox.Text);
            operacija = "*";

            labelIstorija.Text = rezultatBox.Text +" "+ operacija;
            rezultatBox.Text = "0";
        }

        private void DugmeDijeljenjeKlik(object sender, EventArgs e)
        {
            prviBroj = double.Parse(rezultatBox.Text);
            operacija = "/";

            labelIstorija.Text = rezultatBox.Text +" "+ operacija;
            rezultatBox.Text = "0";
        }

        private void dugmeJednakoKlik(object sender, EventArgs e)
        {
            drugiBroj = double.Parse(rezultatBox.Text);

            switch(operacija)
            {
                case "+":
                    {
                        rezultat = prviBroj + drugiBroj;
                        rezultatBox.Text = Convert.ToString(rezultat);
                        prviBroj = rezultat;
                        break;
                    }
               case "-":
                    {
                        rezultat = prviBroj - drugiBroj;
                        rezultatBox.Text = Convert.ToString(rezultat);
                        prviBroj = rezultat;
                        break;
                    }
                case "*":
                    {
                        rezultat = prviBroj * drugiBroj;
                        rezultatBox.Text = Convert.ToString(rezultat);
                        prviBroj = rezultat;
                        break;
                    }
                case "/":
                    {
                        if(drugiBroj == 0)
                        {
                            rezultatBox.Text = "Zabranjeno je dijeljenje sa 0!";
                        }
                        else
                        {
                            rezultat = prviBroj / drugiBroj;
                            rezultatBox.Text = Convert.ToString(rezultat);
                            prviBroj = rezultat;
                        }

                        break;
                    }

            }

            labelIstorija.Text = "";        
        }

        private void DugmeOcistiKlik(object sender, EventArgs e)
        {
            rezultatBox.Text = "0" ;
            labelIstorija.Text = "";
        }
    }
}
