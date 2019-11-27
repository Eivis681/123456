using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Antroji_programavimo_praktika
{
    public partial class Prisijungimas : Form
    {
        public Prisijungimas()
        {
            InitializeComponent();
        }

        private void Prisijungti_Click(object sender, EventArgs e)
        {
            string vardas = PrisijungimoVardas.Text;
            string slaptazodis = PrisijungimoSlaptazodis.Text;
            bool Pvardas = false;
            bool Pslaptazpdis = false;
            if (string.IsNullOrWhiteSpace(PrisijungimoVardas.Text))
            {
                MessageBox.Show("Iveskite vartotojo vardą");
            }
            else if (string.IsNullOrWhiteSpace(PrisijungimoSlaptazodis.Text))
            {
                MessageBox.Show("Iveskite slaptažodi");
            }
            else
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\x\\Desktop\\Antroji programavimo praktika Eividas Balčiūnas PI18C\\Antroji programavimo praktika\\Vartotojai\\Naudotojai.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(';');
                        if (vardas == values[0])
                        {
                            Pvardas = true;
                            if (slaptazodis==values[1])
                            {
                                Pslaptazpdis = true;
                            }
                        }
                    }
                    if (Pvardas==false)
                    {
                        MessageBox.Show("Tokio vartotojo nėra");
                    }
                    else if (Pslaptazpdis==false)
                    {
                        MessageBox.Show("Slaptažodis įvestas neteisingai");
                    }
                    if (Pvardas==true)
                    {
                        if (Pslaptazpdis==true)
                        {
                            PagrindinisLangas forma = new PagrindinisLangas();
                            forma.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void Registruotis_Click(object sender, EventArgs e)
        {
            Registracija forma = new Registracija();
            forma.Show();
            this.Hide();
        }
    }
}
