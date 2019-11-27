using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_programavimo_praktika
{
    public partial class PagrindinisLangas : Form
    {
        public PagrindinisLangas()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prisijungimas forma = new Prisijungimas();
            forma.Show();
        }

        private void PI18A_Click(object sender, EventArgs e)
        {
            this.Hide();
            PI18A forma = new PI18A();
            forma.Show();
        }

        private void PI18B_Click(object sender, EventArgs e)
        {
            this.Hide();
            PI18B forma = new PI18B();
            forma.Show();
        }

        private void PI18C_Click(object sender, EventArgs e)
        {
            this.Hide();
            PI18C forma = new PI18C();
            forma.Show();
        }

        private void PI18D_Click(object sender, EventArgs e)
        {
            this.Hide();
            PI18D forma = new PI18D();
            forma.Show();
        }

        private void PI18E_Click(object sender, EventArgs e)
        {
            this.Hide();
            PI18E forma = new PI18E();
            forma.Show();
        }

        private void PI18F_Click(object sender, EventArgs e)
        {
            this.Hide();
            PI18F forma = new PI18F();
            forma.Show();
        }
    }
}
