namespace Server
{
    public partial class ServerskaForma : Form
    {
        Server server;
        public ServerskaForma()
        {
            InitializeComponent();

            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;

            server = new Server();
            server.Osluskuj();
            Thread serverskaNit = new Thread(server.Pokreni);
            serverskaNit.IsBackground = true;
            serverskaNit.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled= true;
            server.Zaustavi();
        }
    }
}
