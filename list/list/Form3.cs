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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

        List<char> veta = new List<char>();
        private void ulozto_Click(object sender, EventArgs e)
        {
            veta.Clear();
            string text = textBox1.Text;
            foreach(char b in text)
            {
                veta.Add(b);
            }

            panel1.Enabled = true;
        }

        private void a_Click(object sender, EventArgs e)
        {
            string jojojeno = (sender as Button).Text.ToString();            
            veta.RemoveAll(x => x == char.Parse(jojojeno));
            Vypis(veta);

        }
        
        private void Vypis(List<char> cokecas)
        {
            textBox1.Text = new string(cokecas.ToArray());
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            
        }
    }
}
