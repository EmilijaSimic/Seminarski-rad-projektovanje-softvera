using Klijent.Kontroleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Klijent.UserControler
{
    public partial class UCPotvrda : UserControl
    {
        List<StavkaPotvrde> stavke = new List<StavkaPotvrde>();
        int rb = 1;
        public UCPotvrda()
        {
            InitializeComponent();
            Odgovor odgovor = KontrolerKIKupac.Instanca.VratiListuKupaca();
            if (odgovor.Uspesno)
            {
                comboBoxKupac.DataSource = (List<Kupac>)odgovor.Podaci;
            }
            odgovor = KontrolerKIZaposleni.Instanca.VratiListuZaposlenih();
            if (odgovor.Uspesno)
            {
                comboBoxZaposleni.DataSource = (List<Zaposleni>)odgovor.Podaci;
            }
            odgovor = KontrolerKIDogadjaj.Instanca.VratiListuDogadjaja();
            if (odgovor.Uspesno)
            {
                comboBoxDogadjaj.DataSource = (List<Dogadjaj>)odgovor.Podaci;
            }
            ResetForme();
        }

        private void btnPretraziKupca_Click(object sender, EventArgs e)
        {
            Odgovor odgovor = KontrolerKIKupac.Instanca.PretraziKupca(txtPretraziKupca.Text);
            if (odgovor.Uspesno)
            {
                comboBoxKupac.DataSource = (List<Kupac>)odgovor.Podaci;
            }
        }

        private void btnDodajStavkuPotvrde_Click(object sender, EventArgs e)
        {
            comboBoxKupac.Enabled = false;
            comboBoxZaposleni.Enabled = false;
            if (Validacija(txtKolicina.Text))
            {
                stavke.Add(new StavkaPotvrde(rb, new Potvrda(), int.Parse(txtKolicina.Text), 0, 0, (Dogadjaj)comboBoxDogadjaj.SelectedItem));
                dgvPotvrda.DataSource = null;
                dgvPotvrda.DataSource = stavke;
                dgvPotvrda.Columns["Potvrda"].Visible = false;
                dgvPotvrda.Columns["Cena"].Visible = false;
                dgvPotvrda.Columns["Iznos"].Visible = false;
                txtKolicina.Text = "";
                rb++;
            }
            else
            {
                MessageBox.Show("Molimo Vas unesite broj karata");
            }
        }

        private void btnNapraviPotvrdu_Click(object sender, EventArgs e)
        {
            Odgovor odgovor = KontrolerKIPotvrda.Instanca.KreirajPotvrdu(new Potvrda(0, DateTime.Now, 0, 0, 0, (Zaposleni)comboBoxZaposleni.SelectedItem, (Kupac)comboBoxKupac.SelectedItem, stavke));
            if (odgovor.Uspesno)
            {
                MessageBox.Show("Uspesno kreirana potvrda!");
            }
            else
            {
                MessageBox.Show("Kreiranje objekta nije uspelo");
            }
            rb = 1;
            comboBoxZaposleni.Enabled = true;
            comboBoxKupac.Enabled = true;
            ResetForme();
        }

        private bool Validacija(string kolicina)
        {
            try
            {
                int d = Int32.Parse(kolicina);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> Nemoguce parsirati: " + ex.Message);
                return false;
            }
        }

        private void ResetForme()
        {
            txtPretraziKupca.Text = "";
            txtPretraziKupca.Text = "";
            dgvPotvrda.DataSource = null;
        }
    }
}
