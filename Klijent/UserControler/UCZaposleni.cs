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
        Zaposleni selektovani;
        public UCZaposleni()
        {
            InitializeComponent();

            btnIzmeniZaposlenog2.Visible = false;
            Odgovor odgovor = KontrolerKIZaposleni.Instanca.VratiListuZaposlenih();
            if (odgovor.Uspesno)
            {
                dgvZaposleni.DataSource = (List<Zaposleni>)odgovor.Podaci;
                List<Zaposleni> z = (List<Zaposleni>)odgovor.Podaci;
                //MessageBox.Show("" + z[1].Pozicije[1].Pozicija.Id);
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
            pozicije = new List<PozicijaZaposlenog>();
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
            if (dgvZaposleni.SelectedRows.Count > 0)
            {
                try
                {
                    Zaposleni selektovani = (Zaposleni)dgvZaposleni.SelectedRows[0].DataBoundItem;
                    Odgovor odg = KontrolerKIZaposleni.Instanca.ObrisiZaposlenog(selektovani);
                    Odgovor odgovor = KontrolerKIZaposleni.Instanca.VratiListuZaposlenih();
                    if (odgovor.Uspesno)
                    {
                        dgvZaposleni.DataSource = (List<Zaposleni>)odgovor.Podaci;
                    }
                }
                catch (InvalidCastException) {
                    MessageBox.Show("Morate selektovati zaposlenog");
                    return;
                }
            }
        }

        private void btnPromeniZaposlenog_Click(object sender, EventArgs e)
        {
            //btnDodajPoziciju.Visible = false;
            if (dgvZaposleni.SelectedRows.Count > 0)
            {
                btnNapraviZaposlenog.Visible = false;
                btnIzmeniZaposlenog2.Visible = true;

                try
                {
                    Zaposleni selektovani = (Zaposleni)dgvZaposleni.SelectedRows[0].DataBoundItem;
                    this.selektovani = selektovani;
                    txtIme.Text = selektovani.Ime;
                    txtIme.Enabled = false;
                    txtPrezime.Text = selektovani.Prezime;
                    txtPrezime.Enabled = false;
                    txtJMBG.Text = selektovani.Jmbg;
                    txtJMBG.Enabled = false;
                    txtKorIme.Text = selektovani.KorisnickoIme;
                    txtKorIme.Enabled = false;
                    txtLozinka.Text = selektovani.Lozinka;
                    txtLozinka.Enabled = false;

                    Odgovor odgovor = KontrolerKIPozicija.Instanca.VratiListuPozicija();
                    if (odgovor.Uspesno)
                    {
                        List<Pozicija> poz = (List<Pozicija>)odgovor.Podaci;
                        foreach (PozicijaZaposlenog pz in selektovani.Pozicije)
                        {
                            var punaPozicija = poz.FirstOrDefault(p => p.Id == pz.Pozicija.Id);
                            if (punaPozicija != null)
                            {
                                pz.Pozicija = punaPozicija;
                            }
                        }
                    }
                        dgvZaposleni.DataSource = null;
                        dgvZaposleni.DataSource = selektovani.Pozicije;
                        dgvZaposleni.Columns["Zaposleni"].Visible = false;
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Morate selektovati zaposlenog");
                }
            }
        }

        private void btnIzmeniZaposlenog2_Click(object sender, EventArgs e)
        {
             selektovani.Pozicije = pozicije;
             Odgovor odgovor = KontrolerKIZaposleni.Instanca.PromeniZaposlenog(selektovani);
             
             if (odgovor.Uspesno)
             {
                MessageBox.Show("Uspesno izmenjen zaposleni!");
             }
             else
             {
                MessageBox.Show("Menjanje objekta nije uspelo");
             }
            
            pozicije = new List<PozicijaZaposlenog>();
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
