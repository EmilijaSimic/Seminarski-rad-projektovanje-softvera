using Klijent.UserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Forma
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void dodajDogadjajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziKontrolu(new UCDogadjaj());
        }

        private void sviDogađajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziKontrolu(new UCDogadjaj());
        }

        private void dodajKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziKontrolu(new UCKupac());
        }

        private void sviKupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziKontrolu(new UCKupac());
        }

        private void dodajZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziKontrolu(new UCZaposleni()); 
        }

        private void sviZaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziKontrolu(new UCZaposleni());
        }

        private void novaPotvrdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziKontrolu(new UCPotvrda());
        }

        private void svePotvrdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziKontrolu(new UCPotvrda());
        }

        private void PrikaziKontrolu(UserControl kontrola)
        {
            panelPrikaz.Controls.Clear();
            kontrola.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Add(kontrola);
        }
    }
}
