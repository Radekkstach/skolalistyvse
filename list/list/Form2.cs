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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void Generovani(int n, List<int> seznam)            
        {

            Random rng = new Random();
            for(int i = 0; i < n; i++)
            {
                int nahodne = rng.Next(-100, 101);
                seznam.Add(nahodne);
                
            }
        }
        private void Vypis(List<int> seznam, ListBox komponenta)
        {
            listBox1.Items.Clear();
            foreach (int hodnota in seznam)
            {
                komponenta.Items.Add(hodnota);
            }
        }

        private void Prohozeni(List<int> seznam)
        {

            bool mini = false;
            bool maxi = false;
            int minimum = 101;
            int pozicemin = 0;
            int max = 0;
            int pozicemax = 0;
            
            for(int i = 0; i < seznam.Count(); i++)
            {
                if(seznam[i] % 3 == 0 && seznam[i] < minimum)
                {
                    minimum = seznam[i];
                    pozicemin = i;
                    mini = true;
                }
                if(seznam[i] % 2 == 0 && seznam[i] > max)
                {
                    max = seznam[i];
                    pozicemax = i;
                    maxi = true;
                }

            }
            if (maxi && mini)
            {
                seznam[pozicemin] = max;
                seznam[pozicemax] = minimum;
            }
            


        }
        List<int> seznamcisel = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            seznamcisel.Clear();
            Generovani((int)numericUpDown1.Value, seznamcisel);
            Vypis(seznamcisel, listBox1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prohozeni(seznamcisel);
            Vypis(seznamcisel, listBox1);
        }
    }
}
