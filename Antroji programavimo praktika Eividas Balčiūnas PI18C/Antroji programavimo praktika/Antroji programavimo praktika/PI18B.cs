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
    public partial class PI18B : Form
    {
        public PI18B()
        {
            InitializeComponent();
        }
        Vidurkis vidurkis = new Vidurkis();
        private void PridetiStudenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentoVardas.Text))
            {
                MessageBox.Show("Iveskite studento varda");
            }
            else if (string.IsNullOrWhiteSpace(StudentoPavarde.Text))
            {
                MessageBox.Show("Iveskite studento pavarde");
            }
            else
            {
                MessageBox.Show("Studentas pridėtas sekmingai");
                using (StreamWriter writer = new StreamWriter("c:\\users\\x\\desktop\\antroji programavimo praktika eividas balčiūnas pi18c\\antroji programavimo praktika\\vartotojai\\PI18B.txt", true))
                {
                    writer.Write(StudentoVardas.Text);
                    writer.Write(" ");
                    writer.Write(StudentoPavarde.Text);
                    writer.WriteLine(" ");
                }
                StudentoVardas.Clear();
                StudentoPavarde.Clear();
            }
        }

        private void Atnaujinti_Click(object sender, EventArgs e)
        {
            Studentai.Items.Clear();
            string[] lines = File.ReadAllLines("c:\\users\\x\\desktop\\antroji programavimo praktika eividas balčiūnas pi18c\\antroji programavimo praktika\\vartotojai\\PI18B.txt");
            Studentai.Items.AddRange(lines);
        }

        private void IstrintiStudenta_Click(object sender, EventArgs e)
        {
            List<string> dapiso = new List<string>();
            if (Studentai.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite studenta");
            }
            else
            {
                string pasirinkimas = Studentai.SelectedItem.ToString();
                using (StreamReader reader = new StreamReader("C:\\Users\\x\\Desktop\\Antroji programavimo praktika Eividas Balčiūnas PI18C\\Antroji programavimo praktika\\Vartotojai\\PI18B.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        dapiso.Add(line);
                    }
                }
                for (int i = 0; i < dapiso.Count; i++)
                {
                    // if it is List<String>
                    if (dapiso[i].Equals(pasirinkimas))
                    {
                        dapiso.RemoveAt(i);
                    }
                }
                using (StreamWriter writer = new StreamWriter("c:\\users\\x\\desktop\\antroji programavimo praktika eividas balčiūnas pi18c\\antroji programavimo praktika\\vartotojai\\PI18B.txt"))
                {
                    foreach (String s in dapiso)
                        writer.WriteLine(s);
                }
                MessageBox.Show("Studentas sėkmingai ištrintas");
            }
        }

        private void GrižtiAtgal_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagrindinisLangas forma = new PagrindinisLangas();
            forma.Show();
        }

        private void PridetiPazimi_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (string.IsNullOrWhiteSpace(StudentoPazimys.Text))
            {
                MessageBox.Show("Iveskite pažimy");
            }
            else if (Studentai.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite studenta");
            }
            else if (!int.TryParse(StudentoPazimys.Text, out parsedValue))
            {
                MessageBox.Show("Iveskite tik skaičius");
            }
            else
            {
                string pasirinkimas = Studentai.SelectedItem.ToString();
                List<string> dapiso = new List<string>();
                using (StreamReader reader = new StreamReader("C:\\Users\\x\\Desktop\\Antroji programavimo praktika Eividas Balčiūnas PI18C\\Antroji programavimo praktika\\Vartotojai\\PI18B.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        dapiso.Add(line);
                    }
                }
                for (int i = 0; i < dapiso.Count; i++)
                {

                    if (dapiso[i].Equals(pasirinkimas))
                    {
                        string GalutinisSuPazimiu;
                        GalutinisSuPazimiu = pasirinkimas + " " + StudentoPazimys.Text;
                        dapiso[i] = (GalutinisSuPazimiu);
                    }

                }
                using (StreamWriter writer = new StreamWriter("c:\\users\\x\\desktop\\antroji programavimo praktika eividas balčiūnas pi18c\\antroji programavimo praktika\\vartotojai\\PI18B.txt"))
                {
                    foreach (String s in dapiso)
                        writer.WriteLine(s);
                }
                MessageBox.Show("Pazimys sėkmingai pridėtas");

            }
        }

        private void StudentoVidurkis_Click(object sender, EventArgs e)
        {
            if (Studentai.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite studenta");
            }
            else
            {
                string pasirinkimas = Studentai.SelectedItem.ToString();
                string ats;
                ats = vidurkis.findSum(pasirinkimas);
                MessageBox.Show(ats);
            }
        }
    }
}
