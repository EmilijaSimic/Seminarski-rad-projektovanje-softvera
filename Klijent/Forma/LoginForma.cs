using Klijent.Forma;
using Klijent.Kontroleri;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent
{
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            Zaposleni zaposleni = new Zaposleni();
            zaposleni.KorisnickoIme = txtKorIme.Text;
            zaposleni.Lozinka = txtLozinka.Text;
            Odgovor odgovor = KontrolerKILogin.Instanca.IzvrsiLogin(zaposleni);
            if (odgovor.Uspesno)
            {
                GlavnaForma forma = new GlavnaForma();
                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Netacni kredencijali");
            }
        }
    }
}
