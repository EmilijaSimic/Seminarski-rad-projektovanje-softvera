using Klijent.Kontroleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.UserControler
{
    public partial class UCZaposleni : UserControl
    {
        List<PozicijaZaposlenog> pozicije = new List<PozicijaZaposlenog>();
        public UCZaposleni()
        {
            InitializeComponent();

            btnIzmeniZaposlenog2.Visible = false;
            Odgovor odgovor = KontrolerKIZaposleni.Instanca.VratiListuZaposlenih();
            if (odgovor.Uspesno)
            {
                dgvZaposleni.DataSource = (List<Zaposleni>)odgovor.Podaci;
            }
            odgovor = KontrolerKIPozicija.Instanca.VratiListuPozicija();
            if (odgovor.Uspesno)
            {
                comboBoxPozicije.DataSource = (List<Pozicija>)odgovor.Podaci;
            }
            ResetForme();
        }

        private void btnNapraviZaposlenog_Click(object sender, EventArgs e)
        {
            if (Validacija(txtIme.Text, txtPrezime.Text, txtJMBG.Text, txtKorIme.Text, txtLozinka.Text))
            {
                Odgovor odgovor = KontrolerKIZaposleni.Instanca.KreirajZaposlenog(new Zaposleni(0, txtJMBG.Text, txtIme.Text, txtPrezime.Text, txtKorIme.Text, txtLozinka.Text, pozicije));
                if (odgovor.Uspesno)
                {
                    MessageBox.Show("Uspesno kreiran zaposleni!");
                }
                else
                {
                    MessageBox.Show("Kreiranje objekta nije uspelo");
                }
            }
            else
            {
                MessageBox.Show("Molimo popunite polja validnim vrednostima");
            }
            ResetForme();
            Odgovor odg = KontrolerKIZaposleni.Instanca.VratiListuZaposlenih();
            if (odg.Uspesno)
            {
                dgvZaposleni.DataSource = (List<Zaposleni>)odg.Podaci;
            }
        }

        private void btnIzmeniZaposlenog2_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajPoziciju_Click(object sender, EventArgs e)
        {
            pozicije.Add(new PozicijaZaposlenog(new Zaposleni(), (Pozicija)comboBoxPozicije.SelectedItem, dateTimePocetak.Value, dateTimeKraj.Value));
            dgvZaposleni.DataSource = null;
            dgvZaposleni.DataSource = pozicije;
            dgvZaposleni.Columns["Zaposleni"].Visible = false;
        }

        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {

        }

        private void btnPromeniZaposlenog_Click(object sender, EventArgs e)
        {
            btnDodajPoziciju.Visible = false;

        }

        private bool Validacija(string ime, string prezime, string jmbg, string korIme, string lozinka)
        {
            if (ime == null || prezime == null || jmbg == null || korIme == null || lozinka == null ||
                ime == "" || prezime == "" || jmbg == "" || jmbg.Length != 13 || korIme == "" || lozinka == "")
            {
                return false;
            }

            return true;
        }

        private void ResetForme()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtJMBG.Text = "";
            txtKorIme.Text = "";
            txtLozinka.Text = "";
            comboBoxPozicije.SelectedIndex = 0;
        }
    }
}
