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


        string nevim;
        private void Zadani_Click(object sender, EventArgs e)
        {
            try
            {        
                int vysledek = 0;
                nevim = Cislo1.Text;
                cislo = Int32.Parse(nevim);
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
                    MessageBox.Show("ciferný součet", vysledek.ToString());
                    Cislo1.Clear();
                    while (i != vysledek)
                    {
                        i++;
                        if(vysledek % i == 0)
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

        }
    }
}
