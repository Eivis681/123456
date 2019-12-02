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
   
    public partial class PI18A : Form
    {
        
        public PI18A()
        {
            InitializeComponent();
           
        }
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
                using (StreamWriter writer = new StreamWriter("c:\\users\\x\\desktop\\antroji programavimo praktika eividas balčiūnas pi18c\\antroji programavimo praktika\\vartotojai\\PI18A.txt", true))
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
            string[] lines = File.ReadAllLines("c:\\users\\x\\desktop\\antroji programavimo praktika eividas balčiūnas pi18c\\antroji programavimo praktika\\vartotojai\\PI18A.txt");
            Studentai.Items.AddRange(lines);
        }
     
        private void IstrintiStudenta_Click(object sender, EventArgs e)
        {
            // pabaigt trinima
            int x = 0;
            //string[] values = new string[x];
            List<string> values = new List<string>();
          
            if (Studentai.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite studenta");
            }
            else
            {
                string pasirinkimas = Studentai.SelectedItem.ToString();
                
                using (StreamReader reader = new StreamReader("C:\\Users\\x\\Desktop\\Antroji programavimo praktika Eividas Balčiūnas PI18C\\Antroji programavimo praktika\\Vartotojai\\PI18A.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        values.Add(line);
                    }

                }
                //{
                //    string line;

                //    int i = 0;
                //    while ((line = reader.ReadLine()) != null)
                //    {
                //        x++;
                //    }
                //    while ((line = reader.ReadLine()) != null)
                //    {
                //        values[i] = line;
                //        i++;
                //    }
                //}
                //values = values.Where(val =>val !=pasirinkimas).ToArray();
        
                //for (int z=0;z<x;z++)
                //{
                //    MessageBox.Show(values[z]);
                //}
            }
        }
            

        private void PridetiPazimi_Click(object sender, EventArgs e)
        {
            bool pagaiga = false;
            if (Studentai.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite studenta");
            }
            else if (string.IsNullOrWhiteSpace(StudentoPazimys.Text))
            {
                MessageBox.Show("Iveskite pažimi kuri norite pridėti");
            }
            else
            {
                int x = 0;
                string[] values = new string[x];
                string pasirinkimas = Studentai.SelectedItem.ToString();
                int pazimys = Int32.Parse(StudentoPazimys.Text);
                using (StreamReader reader = new StreamReader("C:\\Users\\x\\Desktop\\Antroji programavimo praktika Eividas Balčiūnas PI18C\\Antroji programavimo praktika\\Vartotojai\\PI18A.txt"))
                {
                    string line;
                    int i = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        values[i] = line;
                        i++;
                        x++;
                    }
                    for (int j=0;j<x;j++)
                    {
                        if (values[j]==pasirinkimas)
                        {
                            MessageBox.Show("Pažimys sekmingai pridėtas");

                        }
                    }
                }

            }
        }

        private void GrižtiAtgal_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagrindinisLangas forma = new PagrindinisLangas();
            forma.Show();
        }

        private void PridetiPazimi_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentoPazimys.Text))
            {
                MessageBox.Show("Iveskite pažimy");
            }
            else if (Studentai.SelectedItem==null)
            {
                MessageBox.Show("Pasirinkite studenta");
            }
            else
            {
                string pasirinkimas = Studentai.SelectedItem.ToString();
                using (StreamWriter writer = new StreamWriter("c:\\users\\x\\desktop\\antroji programavimo praktika eividas balčiūnas pi18c\\antroji programavimo praktika\\vartotojai\\PI18A.txt", true))
                {

                    writer.Write(StudentoVardas.Text);
                    writer.Write(" ");
                    writer.Write(StudentoPavarde.Text);
                    writer.WriteLine(" ");
                }
            }
        }
    }
}
