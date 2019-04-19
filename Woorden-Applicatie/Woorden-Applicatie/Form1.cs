using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woorden_Applicatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> woorden = new List<string>();
        public List<string> betekenis = new List<string>();

        public bool NieuwWoord(string woord)
        {
            if (woorden.Contains(woord))
            {
                if(woord == "Fun12 is echt een \"leuk\" vak")
                {
                    Form2 dank = new Form2();
                    dank.Show();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public string betekeniszoeker(string woord)
        {
            int index = woorden.IndexOf(woord);
            return betekenis[index];
        }

        public void updater(string woord, string betekenisx, string newwoord)
        {
            int index = woorden.IndexOf(woord);
            betekenis[index] = betekenisx;
            woorden[index] = newwoord;
        }

        public void listboxfiller()
        {
            foreach (var gay in woorden)
            {
                listBox1.Items.Add(gay);
            }
            foreach (var gay2 in betekenis)
            {
                listBox2.Items.Add(gay2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NieuwWoord(textBox1.Text) == true)
                {
                    MessageBox.Show("YEAH IT DOES YES ");
                }
                else
                {
                    if (textBox1.Text == "Fun12 is echt een \"leuk\" vak")
                    {
                        MessageBox.Show("voeg het toe dit is een coole easteregg");
                    }
                    else
                    {
                        MessageBox.Show("NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
                    }
                }
                label1.Text = betekeniszoeker(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Woordenboek is leeg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = woorden.IndexOf(textBox1.Text);
            woorden.Remove(textBox1.Text);
            betekenis.Remove(textBox2.Text);
            listBox1.Items.Remove(index);
            listBox2.Items.Remove(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            woorden.Clear();
            betekenis.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            woorden.Add(textBox1.Text);
            if(textBox2.Text == null)
            {
                betekenis.Add("Geen betekenis opgegeven");
            }
            else
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                betekenis.Add(textBox2.Text);
                listboxfiller();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            updater(textBox1.Text, textBox2.Text, textBox3.Text);
            listboxfiller();
        }
    }
}
