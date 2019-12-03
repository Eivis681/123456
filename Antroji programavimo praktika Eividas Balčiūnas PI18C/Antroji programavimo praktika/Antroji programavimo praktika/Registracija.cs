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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registruotis_Click(object sender, EventArgs e)
        {
            string vardas = RegistacijosVardas.Text;
            string slaptazodis = RegistracijosSpaltažodis.Text;
            string slaptazodis1 = RegistracijosSlaptažodzioPakartojimas.Text;
            bool pabaiga = false;
            if (string.IsNullOrWhiteSpace(RegistacijosVardas.Text))
            {
                MessageBox.Show("Iveskite vartotojo varda");
            }
            else if (string.IsNullOrWhiteSpace(RegistracijosSpaltažodis.Text))
            {
                MessageBox.Show("Iveskite slaptažodi");
            }
            else if (string.IsNullOrWhiteSpace(RegistracijosSlaptažodzioPakartojimas.Text))
            {
                MessageBox.Show("Iveskite slaptažodžio pakartojima");
            }
            else
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\x\\Desktop\\Antroji programavimo praktika Eividas Balčiūnas PI18C\\Antroji programavimo praktika\\Vartotojai\\Naudotojai.txt"))
                {
                    string line;
                    while ((line =reader.ReadLine()) !=null)
                    {
                        string[] values = line.Split(';');
                        if (vardas==values[0])
                        {
                            MessageBox.Show("Toks vartotojo vardas jau yra");
                            pabaiga = true;
                        }
      
                    }
                    if (pabaiga == false)
                    {
                        reader.Close();
                        MessageBox.Show("Registracija sėkminga");
                        Prisijungimas forma = new Prisijungimas();
                        forma.Show();
                        this.Hide();
                        using (StreamWriter writer = new StreamWriter("c:\\users\\x\\desktop\\antroji programavimo praktika eividas balčiūnas pi18c\\antroji programavimo praktika\\vartotojai\\naudotojai.txt", true))
                        {
                            writer.Write(RegistacijosVardas.Text);
                            writer.Write(";");
                            writer.Write(RegistracijosSpaltažodis.Text);
                            writer.WriteLine(";");
                        }
                    }
                }
                
              
            }
        }
  
    }
}
