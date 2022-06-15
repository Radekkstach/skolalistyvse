using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Vypis(List<double> seznam, ListBox komponenta)
        {
            foreach(double hodnota in seznam)
            {
                komponenta.Items.Add(hodnota);
            }
        }

        private void Aritmeticka(List<int> seznam, int diference, int a1, int pocet)
        {

            for(int i = 0;i < pocet;i++)
            {
                seznam.Add(a1);
                a1 += diference;
            }
        }

        private void Geometricka(List<double> seznam, double a2, double a1, int pocet)
        {
            double d = a2 / a1;
            for (int i = 0; i < pocet; i++)
            {
                seznam.Add(a1);

                a1 = a1 * d;
            }
        }

        private bool Zjistit(int p, List<double> seznam)
        {
            double soucet = 0;
            
            if(p <= seznam.Count())
            {
                
                for(int i = 0; i< p; i++)
                {
                    soucet += seznam[i];
                }
                label5.Text = "True";
                label6.Text = "" + soucet;
                return true;
            }
            label5.Text = "Nesedi";
            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            List<double> seznamcisel = new List<double>();
            //Aritmeticka(seznamcisel, int.Parse(textBox3.Text), int.Parse(textBox2.Text), int.Parse(textBox1.Text));
            //Vypis(seznamcisel, listBox1);
            Geometricka(seznamcisel, double.Parse(textBox4.Text), double.Parse(textBox2.Text), int.Parse(textBox1.Text));
            Vypis(seznamcisel, listBox2);
            Zjistit(int.Parse(textBox5.Text), seznamcisel);
        }
    }
}
