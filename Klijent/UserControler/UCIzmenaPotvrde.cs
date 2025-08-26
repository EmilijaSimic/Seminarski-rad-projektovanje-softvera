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

namespace Klijent.UserControler
{
    public partial class UCIzmenaPotvrde : UserControl
    {
        List<StavkaPotvrde> stavke = new List<StavkaPotvrde>();
        Potvrda potvrda;
        public UCIzmenaPotvrde()
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

        private void btnObrisiStavkuPotvrde_Click(object sender, EventArgs e)
        {
            if (dgvPotvrda.SelectedRows.Count > 0)
            {
                StavkaPotvrde selektovani = (StavkaPotvrde)dgvPotvrda.SelectedRows[0].DataBoundItem;
                stavke.Remove(selektovani);
                dgvPotvrda.DataSource = null;
                dgvPotvrda.DataSource = stavke;
                dgvPotvrda.Columns["Potvrda"].Visible = false;
            }
        }

        private void btnPretraziPotvrdu_Click(object sender, EventArgs e)
        {
            Odgovor odgovor = KontrolerKIPotvrda.Instanca.PretraziPotvrdu(new Potvrda(0,new DateTime(), 0, 0, 0, (Zaposleni)comboBoxZaposleni.SelectedItem, (Kupac)comboBoxKupac.SelectedItem, stavke));
            if (odgovor.Uspesno)
            {
                potvrda = (Potvrda)odgovor.Podaci;
                txtDatum.Text = potvrda.Datum.ToString();
                txtCena.Text = potvrda.Cena.ToString();
                txtPopust.Text = potvrda.Popust.ToString();
                txtIznosUkupno.Text = potvrda.IznosUkupno.ToString();
                comboBoxKupac.SelectedItem = (Kupac)potvrda.Kupac;
                comboBoxZaposleni.SelectedItem = (Zaposleni)potvrda.Zaposleni;

                comboBoxZaposleni.Enabled = false;
                comboBoxKupac.Enabled = false;

                dgvPotvrda.DataSource = potvrda.Stavke;
                dgvPotvrda.Columns["Potvrda"].Visible = false;
                stavke = potvrda.Stavke;
            }
            else
            {
                MessageBox.Show("Nema takve potvrde, kreirajte je!");
            }
        }

        private void btnDodajStavkuPotvrde_Click(object sender, EventArgs e)
        {
            if (Validacija(txtKolicina.Text))
            {
                stavke.Add(new StavkaPotvrde(0, null, int.Parse(txtKolicina.Text), 0, 0, (Dogadjaj)comboBoxDogadjaj.SelectedItem));
                dgvPotvrda.DataSource = null;
                dgvPotvrda.DataSource = stavke;
                dgvPotvrda.Columns["Potvrda"].Visible = false;
                dgvPotvrda.Columns["Cena"].Visible = false;
                dgvPotvrda.Columns["Iznos"].Visible = false;
                txtKolicina.Text = "";
            }
            else
            {
                MessageBox.Show("Molimo Vas unesite broj karata");
            }
        }

        private void btnPotvrdiIzmenu_Click(object sender, EventArgs e)
        {
            potvrda.Stavke = stavke;
            Odgovor odgovor = KontrolerKIPotvrda.Instanca.PromeniPotvrdu(potvrda);
            if (odgovor.Uspesno)
            {
                MessageBox.Show("Radi!!!!");
            }
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
            txtDatum.Text = "";
            txtCena.Text = "";
            txtIznosUkupno.Text = "";
            txtPopust.Text = "";
            txtKolicina.Text = "";
            dgvPotvrda.DataSource = null;
        }
    }
}
