using Klijent.Kontroleri;
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
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.Forma
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            panelDogadjaj.Visible = false;
            panelNapraviDogadjaj.Visible = false;
        }

        private void dodajDogadjajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDogadjaj.Visible = false;
            panelNapraviDogadjaj.Visible = true;
            btnIzmeniDogadjaj2.Visible = false;
        }

        private void sviDogađajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNapraviDogadjaj.Visible = false;
            panelDogadjaj.Visible = true;

            Odgovor odgovor = KontrolerKIDogadjaj.Instanca.VratiListuDogadjaja();
            if (odgovor.Uspesno)
            {
                dgvDogadjaji.DataSource = (List<Dogadjaj>)odgovor.Podaci;
            }
        }

        private void btnNapraviDogadjaj_Click(object sender, EventArgs e)
        {
            if (ValidacijaDogadjaj(txtIzvodjac.Text, txtHala.Text, txtMesto.Text, txtDatum.Text, txtCena.Text))
            {
                Odgovor odgovor = KontrolerKIDogadjaj.Instanca.KreirajDogadjaj(new Dogadjaj(0, txtIzvodjac.Text, txtHala.Text, txtMesto.Text, DateTime.Parse(txtDatum.Text), Double.Parse(txtCena.Text)));
                if (odgovor.Uspesno)
                {
                    MessageBox.Show("Uspesno kreiran dogadjaj!");
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
        }

        private void btnPretraziDogadjaj_Click(object sender, EventArgs e)
        {
            Odgovor odgovor = KontrolerKIDogadjaj.Instanca.PretraziDogadjaj(txtPretraziDogađaj.Text);
            if (odgovor.Uspesno)
            {
                dgvDogadjaji.DataSource = (List<Dogadjaj>)odgovor.Podaci;
            }
        }

        private void btnObrisiDogadjaj_Click(object sender, EventArgs e)
        {
            if (dgvDogadjaji.SelectedRows.Count > 0)
            {
                Dogadjaj selektovani = (Dogadjaj)dgvDogadjaji.SelectedRows[0].DataBoundItem;
                Odgovor odg = KontrolerKIDogadjaj.Instanca.ObrisiDogadjaj(selektovani);
                Odgovor odgovor = KontrolerKIDogadjaj.Instanca.VratiListuDogadjaja();
                if (odgovor.Uspesno)
                {
                    dgvDogadjaji.DataSource = (List<Dogadjaj>)odgovor.Podaci;
                }
            }
        }

        private void btnPromeniDogadjaj_Click(object sender, EventArgs e)
        {
            if (dgvDogadjaji.SelectedRows.Count > 0)
            {
                panelNapraviDogadjaj.Visible = true;
                btnNapraviDogadjaj.Visible = false;
                btnIzmeniDogadjaj2.Visible = true;

                Dogadjaj selektovani = (Dogadjaj)dgvDogadjaji.SelectedRows[0].DataBoundItem;
                txtIzvodjac.Text = selektovani.Izvodjac;
                txtHala.Text = selektovani.Hala;
                txtMesto.Text = selektovani.Mesto;
                txtDatum.Text = selektovani.Datum.ToString();
                txtCena.Text = selektovani.Cena.ToString();
            }
        }

        private void btnIzmeniDogadjaj2_Click(object sender, EventArgs e)
        {
            if (dgvDogadjaji.SelectedRows.Count > 0)
            {
                Dogadjaj selektovani = (Dogadjaj)dgvDogadjaji.SelectedRows[0].DataBoundItem;
                if (ValidacijaDogadjaj(txtIzvodjac.Text, txtHala.Text, txtMesto.Text, txtDatum.Text, txtCena.Text))
                {
                    selektovani.Izvodjac = txtIzvodjac.Text;
                    selektovani.Hala = txtHala.Text;
                    selektovani.Mesto = txtMesto.Text;
                    selektovani.Datum = DateTime.Parse(txtDatum.Text);
                    selektovani.Cena = Double.Parse(txtCena.Text);
                    Odgovor odg = KontrolerKIDogadjaj.Instanca.PromeniDogadjaj(selektovani);
                    if (odg.Uspesno)
                    {
                        MessageBox.Show("Uspesno izmenjen dogadjaj");
                        Odgovor odgovor = KontrolerKIDogadjaj.Instanca.VratiListuDogadjaja();
                        if (odgovor.Uspesno)
                        {
                            dgvDogadjaji.DataSource = (List<Dogadjaj>)odgovor.Podaci;
                        }
                    }
                }
                ResetForme();
            }
        }

        private bool ValidacijaDogadjaj(string izvodjac, string hala, string mesto, string datum, string cena)
        {
            if (izvodjac == null || hala == null || mesto == null || datum == null || cena == null ||
                izvodjac == "" || hala == "" || mesto == "" || datum == "" || cena == "")
            {
                return false;
            }
            try
            {
                DateTime d = DateTime.Parse(datum);
                double c = double.Parse(cena);
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
            txtIzvodjac.Text = "";
            txtHala.Text = "";
            txtMesto.Text = "";
            txtDatum.Text = "";
            txtCena.Text = "";
            txtPretraziDogađaj.Text = "";
        }

    }
}
