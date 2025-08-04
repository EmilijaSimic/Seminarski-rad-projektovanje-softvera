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
    public partial class UCKupac : UserControl
    {
        public UCKupac()
        {
            InitializeComponent();

            btnIzmeniKupca2.Visible = false;
            Odgovor odgovor = KontrolerKIKupac.Instanca.VratiListuKupaca();
            if (odgovor.Uspesno)
            {
                dgvKupci.DataSource = (List<Kupac>)odgovor.Podaci;
            }
            odgovor = KontrolerKITipKupca.Instanca.VratiListuTipKupaca();
            if (odgovor.Uspesno)
            {
                comboBoxTip.DataSource = (List<TipKupca>)odgovor.Podaci;
            }
            ResetForme();
        }

        private void btnNapraviKupca_Click(object sender, EventArgs e)
        {
            if (Validacija(txtIme.Text, txtPrezime.Text, txtTelefon.Text, txtBrojPlatneKartice.Text))
            {
                Odgovor odgovor = KontrolerKIKupac.Instanca.KreirajKupca(new Kupac(0, txtIme.Text, txtPrezime.Text, txtTelefon.Text, txtBrojPlatneKartice.Text, checkBoxAktivan.Checked, (TipKupca)comboBoxTip.SelectedItem));
                if (odgovor.Uspesno)
                {
                    MessageBox.Show("Uspesno kreiran kupac!");
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
            Odgovor odg = KontrolerKIKupac.Instanca.VratiListuKupaca();
            if (odg.Uspesno)
            {
                dgvKupci.DataSource = (List<Kupac>)odg.Podaci;
            }
        }
        
        private void btnPretraziKupca_Click(object sender, EventArgs e)
        {
            Odgovor odgovor = KontrolerKIKupac.Instanca.PretraziKupca(txtPretraziKupca.Text);
            if (odgovor.Uspesno)
            {
                dgvKupci.DataSource = (List<Kupac>)odgovor.Podaci;
            }
        }

        private void btnObrisiKupca_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                Kupac selektovani = (Kupac)dgvKupci.SelectedRows[0].DataBoundItem;
                Odgovor odg = KontrolerKIKupac.Instanca.ObrisiKupca(selektovani);
                Odgovor odgovor = KontrolerKIKupac.Instanca.VratiListuKupaca();
                if (odgovor.Uspesno)
                {
                    dgvKupci.DataSource = (List<Kupac>)odgovor.Podaci;
                }
            }
        }

        private void btnPromeniKupca_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                btnNapraviKupca.Visible = false;
                btnIzmeniKupca2.Visible = true;

                Kupac selektovani = (Kupac)dgvKupci.SelectedRows[0].DataBoundItem;
                txtIme.Text = selektovani.Ime;
                txtPrezime.Text = selektovani.Prezime;
                txtTelefon.Text = selektovani.Telefon;
                txtBrojPlatneKartice.Text = selektovani.BrojPlatneKartice;
                checkBoxAktivan.Checked = selektovani.Aktivan;
                comboBoxTip.SelectedItem = selektovani.TipKupca;

                btnIzmeniKupca2.Visible = true;
                btnNapraviKupca.Visible = false;
            }
        }

        private void btnIzmeniKupca2_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                Kupac selektovani = (Kupac)dgvKupci.SelectedRows[0].DataBoundItem;
                if (Validacija(txtIme.Text, txtPrezime.Text, txtTelefon.Text, txtBrojPlatneKartice.Text))
                {
                    selektovani.Ime = txtIme.Text;
                    selektovani.Prezime = txtPrezime.Text;
                    selektovani.BrojPlatneKartice = txtBrojPlatneKartice.Text;
                    selektovani.Telefon = txtTelefon.Text;
                    selektovani.Aktivan = checkBoxAktivan.Checked;
                    selektovani.TipKupca = (TipKupca)comboBoxTip.SelectedItem;
                    Odgovor odg = KontrolerKIKupac.Instanca.PromeniKupca(selektovani);
                    if (odg.Uspesno)
                    {
                        MessageBox.Show("Uspesno izmenjen kupac");
                        Odgovor odgovor = KontrolerKIKupac.Instanca.VratiListuKupaca();
                        if (odgovor.Uspesno)
                        {
                            dgvKupci.DataSource = (List<Kupac>)odgovor.Podaci;
                        }
                    }
                }
                ResetForme();
            }
        }

        private bool Validacija(string ime, string prezime, string telefon, string brojPlatneKartice)
        {
            if (ime == null || prezime == null || telefon == null || 
                ime == "" || prezime == "" || telefon == "" )
            {
                return false;
            }
            if (!telefon.StartsWith("+381")) { return false; }
            if (brojPlatneKartice != null && brojPlatneKartice != "" && brojPlatneKartice.Length != 16) {  return false; }
            return true;
        }

        private void ResetForme()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtTelefon.Text = "+381 xx xxxxxxx";
            txtBrojPlatneKartice.Text = "";
            txtPretraziKupca.Text = "";
            comboBoxTip.SelectedIndex = 0;
            checkBoxAktivan.Checked = false;
        }
    }
}
