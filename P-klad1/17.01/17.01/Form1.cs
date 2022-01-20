using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cislo;
        int Cislo_Dva;

        string nevim;
        private void Zadani_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {        
                int vysledek = 0;
                nevim = Cislo1.Text;
                cislo = Int32.Parse(nevim);
                    Cislo_Dva = cislo;
                    int i = 0;
                    if (cislo < 0)
                    {
                        MessageBox.Show("Špatně zadáno!");
                        Cislo1.Clear();
                    }
                    else
                    {
                        while (cislo > 0)
                        {
                            int pocitadlo = 0;
                            while (pocitadlo == 0)
                            {

                                vysledek = (cislo % 10) + vysledek;
                                pocitadlo++;
                            }
                            cislo = cislo / 10;
                        }
                        MessageBox.Show(vysledek.ToString(), "ciferný součet");
                        Cislo1.Clear();
                        while (i != Cislo_Dva)
                        {
                            i++;
                            if (Cislo_Dva % i == 0)
                            {
                                listBox1.Items.Add(i.ToString());
                            }
                        }
                    }
            }
            catch
            {
                MessageBox.Show("Špatně zadáno!");
                Cislo1.Clear();
            }


        }

        private void Cislo1_TextChanged(object sender, EventArgs e)
        {
           Cislo1.BackColor = Color.White;
        }

        private void Zadani_MouseHover(object sender, EventArgs e)
        {
            Zadani.BackColor = Color.LightGray;
        }

        private void Zadani_MouseLeave(object sender, EventArgs e)
        {
            Zadani.BackColor = Color.White;
        }

        private void Cislo1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Cislo1_MouseLeave(object sender, EventArgs e)
        {
            Cislo1.BackColor = Color.White;
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Font = new Font("Microsoft Sans Serif;", 12, FontStyle.Bold);
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Font = new Font("Microsoft Sans Serif;", 8);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
