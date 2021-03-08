using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brkovi
{
    public partial class Form1 : Form
    {
        List<Brkovi> lista = new List<Brkovi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {

                Brkovi brk = new Brkovi(textBox1.Text, textBox2.Text, Convert.ToString(comboBox1.Text), Convert.ToInt32(textBox3.Text));

                lista.Add(brk);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();




            }
            catch (Exception greska)
            {

                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message,
                    "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Podatak 1" + "\tPodatak 2"
                + "\tPodatak 3" + "\tPodatak 4" + "\tDodatak\r\n";


            foreach (Brkovi brk in lista)
            {
                richTextBox1.AppendText(brk.ToString());
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {

            foreach (Brkovi brk in lista)
            {
                if (brk.Pod4 == "M")
                {
                    brk.Dodatak = "Ima brkove.";
                }
                else
                {
                    brk.Dodatak = "Nema brkove";
                }
            }
        }
    }
}
