namespace Klijent.Forma
{
    partial class GlavnaForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            dogadjajToolStripMenuItem = new ToolStripMenuItem();
            dodajDogadjajToolStripMenuItem = new ToolStripMenuItem();
            sviDogađajiToolStripMenuItem = new ToolStripMenuItem();
            kupacToolStripMenuItem = new ToolStripMenuItem();
            dodajKupcaToolStripMenuItem = new ToolStripMenuItem();
            sviKupciToolStripMenuItem = new ToolStripMenuItem();
            zaposleniToolStripMenuItem = new ToolStripMenuItem();
            dodajZaposlenogToolStripMenuItem = new ToolStripMenuItem();
            sviZaposleniToolStripMenuItem = new ToolStripMenuItem();
            povrdaToolStripMenuItem = new ToolStripMenuItem();
            novaPotvrdaToolStripMenuItem = new ToolStripMenuItem();
            svePotvrdeToolStripMenuItem = new ToolStripMenuItem();
            panelPrikaz = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.GhostWhite;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dogadjajToolStripMenuItem, kupacToolStripMenuItem, zaposleniToolStripMenuItem, povrdaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1081, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dogadjajToolStripMenuItem
            // 
            dogadjajToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajDogadjajToolStripMenuItem, sviDogađajiToolStripMenuItem });
            dogadjajToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            dogadjajToolStripMenuItem.Name = "dogadjajToolStripMenuItem";
            dogadjajToolStripMenuItem.Size = new Size(85, 24);
            dogadjajToolStripMenuItem.Text = "Dogadjaj";
            // 
            // dodajDogadjajToolStripMenuItem
            // 
            dodajDogadjajToolStripMenuItem.Name = "dodajDogadjajToolStripMenuItem";
            dodajDogadjajToolStripMenuItem.Size = new Size(193, 26);
            dodajDogadjajToolStripMenuItem.Text = "Dodaj događaj";
            dodajDogadjajToolStripMenuItem.Click += dodajDogadjajToolStripMenuItem_Click;
            // 
            // sviDogađajiToolStripMenuItem
            // 
            sviDogađajiToolStripMenuItem.Name = "sviDogađajiToolStripMenuItem";
            sviDogađajiToolStripMenuItem.Size = new Size(193, 26);
            sviDogađajiToolStripMenuItem.Text = "Svi događaji";
            sviDogađajiToolStripMenuItem.Click += sviDogađajiToolStripMenuItem_Click;
            // 
            // kupacToolStripMenuItem
            // 
            kupacToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajKupcaToolStripMenuItem, sviKupciToolStripMenuItem });
            kupacToolStripMenuItem.Name = "kupacToolStripMenuItem";
            kupacToolStripMenuItem.Size = new Size(64, 24);
            kupacToolStripMenuItem.Text = "Kupac";
            // 
            // dodajKupcaToolStripMenuItem
            // 
            dodajKupcaToolStripMenuItem.Name = "dodajKupcaToolStripMenuItem";
            dodajKupcaToolStripMenuItem.Size = new Size(176, 26);
            dodajKupcaToolStripMenuItem.Text = "Dodaj kupca";
            dodajKupcaToolStripMenuItem.Click += dodajKupcaToolStripMenuItem_Click;
            // 
            // sviKupciToolStripMenuItem
            // 
            sviKupciToolStripMenuItem.Name = "sviKupciToolStripMenuItem";
            sviKupciToolStripMenuItem.Size = new Size(176, 26);
            sviKupciToolStripMenuItem.Text = "Svi kupci";
            sviKupciToolStripMenuItem.Click += sviKupciToolStripMenuItem_Click;
            // 
            // zaposleniToolStripMenuItem
            // 
            zaposleniToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajZaposlenogToolStripMenuItem, sviZaposleniToolStripMenuItem });
            zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            zaposleniToolStripMenuItem.Size = new Size(88, 24);
            zaposleniToolStripMenuItem.Text = "Zaposleni";
            // 
            // dodajZaposlenogToolStripMenuItem
            // 
            dodajZaposlenogToolStripMenuItem.Name = "dodajZaposlenogToolStripMenuItem";
            dodajZaposlenogToolStripMenuItem.Size = new Size(224, 26);
            dodajZaposlenogToolStripMenuItem.Text = "Dodaj zaposlenog";
            dodajZaposlenogToolStripMenuItem.Click += dodajZaposlenogToolStripMenuItem_Click;
            // 
            // sviZaposleniToolStripMenuItem
            // 
            sviZaposleniToolStripMenuItem.Name = "sviZaposleniToolStripMenuItem";
            sviZaposleniToolStripMenuItem.Size = new Size(224, 26);
            sviZaposleniToolStripMenuItem.Text = "Svi zaposleni";
            sviZaposleniToolStripMenuItem.Click += sviZaposleniToolStripMenuItem_Click;
            // 
            // povrdaToolStripMenuItem
            // 
            povrdaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaPotvrdaToolStripMenuItem, svePotvrdeToolStripMenuItem });
            povrdaToolStripMenuItem.Name = "povrdaToolStripMenuItem";
            povrdaToolStripMenuItem.Size = new Size(73, 24);
            povrdaToolStripMenuItem.Text = "Potvrda";
            // 
            // novaPotvrdaToolStripMenuItem
            // 
            novaPotvrdaToolStripMenuItem.Name = "novaPotvrdaToolStripMenuItem";
            novaPotvrdaToolStripMenuItem.Size = new Size(224, 26);
            novaPotvrdaToolStripMenuItem.Text = "Nova potvrda";
            novaPotvrdaToolStripMenuItem.Click += novaPotvrdaToolStripMenuItem_Click;
            // 
            // svePotvrdeToolStripMenuItem
            // 
            svePotvrdeToolStripMenuItem.Name = "svePotvrdeToolStripMenuItem";
            svePotvrdeToolStripMenuItem.Size = new Size(224, 26);
            svePotvrdeToolStripMenuItem.Text = "Sve potvrde";
            svePotvrdeToolStripMenuItem.Click += svePotvrdeToolStripMenuItem_Click;
            // 
            // panelPrikaz
            // 
            panelPrikaz.Location = new Point(12, 46);
            panelPrikaz.Name = "panelPrikaz";
            panelPrikaz.Size = new Size(1046, 489);
            panelPrikaz.TabIndex = 4;
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1081, 547);
            Controls.Add(panelPrikaz);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GlavnaForma";
            Text = "Glavna forma";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dogadjajToolStripMenuItem;
        private ToolStripMenuItem kupacToolStripMenuItem;
        private ToolStripMenuItem zaposleniToolStripMenuItem;
        private ToolStripMenuItem povrdaToolStripMenuItem;
        private ToolStripMenuItem dodajDogadjajToolStripMenuItem;
        private ToolStripMenuItem sviDogađajiToolStripMenuItem;
        private ToolStripMenuItem dodajKupcaToolStripMenuItem;
        private ToolStripMenuItem sviKupciToolStripMenuItem;
        private ToolStripMenuItem dodajZaposlenogToolStripMenuItem;
        private ToolStripMenuItem sviZaposleniToolStripMenuItem;
        private ToolStripMenuItem novaPotvrdaToolStripMenuItem;
        private ToolStripMenuItem svePotvrdeToolStripMenuItem;
        private Panel panelPrikaz;
    }
}