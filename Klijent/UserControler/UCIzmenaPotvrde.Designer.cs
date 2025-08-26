namespace Klijent.UserControler
{
    partial class UCIzmenaPotvrde
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSkriveni = new Panel();
            txtPopust = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnObrisiStavkuPotvrde = new Button();
            txtDatum = new TextBox();
            txtCena = new TextBox();
            txtIznosUkupno = new TextBox();
            label5 = new Label();
            dgvPotvrda = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            btnPretraziPotvrdu = new Button();
            comboBoxZaposleni = new ComboBox();
            comboBoxKupac = new ComboBox();
            btnDodajStavkuPotvrde = new Button();
            label11 = new Label();
            comboBoxDogadjaj = new ComboBox();
            label10 = new Label();
            txtKolicina = new TextBox();
            btnPotvrdiIzmenu = new Button();
            panelSkriveni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPotvrda).BeginInit();
            SuspendLayout();
            // 
            // panelSkriveni
            // 
            panelSkriveni.Controls.Add(txtPopust);
            panelSkriveni.Controls.Add(label1);
            panelSkriveni.Controls.Add(label2);
            panelSkriveni.Controls.Add(label3);
            panelSkriveni.Controls.Add(label4);
            panelSkriveni.Controls.Add(btnObrisiStavkuPotvrde);
            panelSkriveni.Controls.Add(txtDatum);
            panelSkriveni.Controls.Add(txtCena);
            panelSkriveni.Controls.Add(txtIznosUkupno);
            panelSkriveni.Location = new Point(463, 157);
            panelSkriveni.Name = "panelSkriveni";
            panelSkriveni.Size = new Size(460, 193);
            panelSkriveni.TabIndex = 13;
            // 
            // txtPopust
            // 
            txtPopust.Location = new Point(151, 101);
            txtPopust.Name = "txtPopust";
            txtPopust.ReadOnly = true;
            txtPopust.Size = new Size(170, 27);
            txtPopust.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 11);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Datum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Cena";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 104);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Popust";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 147);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 3;
            label4.Text = "Iznos ukupno";
            // 
            // btnObrisiStavkuPotvrde
            // 
            btnObrisiStavkuPotvrde.BackColor = SystemColors.ButtonHighlight;
            btnObrisiStavkuPotvrde.Location = new Point(358, 78);
            btnObrisiStavkuPotvrde.Name = "btnObrisiStavkuPotvrde";
            btnObrisiStavkuPotvrde.Size = new Size(99, 50);
            btnObrisiStavkuPotvrde.TabIndex = 4;
            btnObrisiStavkuPotvrde.Text = "Obriši stavku";
            btnObrisiStavkuPotvrde.UseVisualStyleBackColor = false;
            btnObrisiStavkuPotvrde.Click += btnObrisiStavkuPotvrde_Click;
            // 
            // txtDatum
            // 
            txtDatum.Location = new Point(150, 13);
            txtDatum.Name = "txtDatum";
            txtDatum.ReadOnly = true;
            txtDatum.Size = new Size(171, 27);
            txtDatum.TabIndex = 5;
            // 
            // txtCena
            // 
            txtCena.Location = new Point(151, 55);
            txtCena.Name = "txtCena";
            txtCena.ReadOnly = true;
            txtCena.Size = new Size(170, 27);
            txtCena.TabIndex = 6;
            // 
            // txtIznosUkupno
            // 
            txtIznosUkupno.Location = new Point(149, 147);
            txtIznosUkupno.Name = "txtIznosUkupno";
            txtIznosUkupno.ReadOnly = true;
            txtIznosUkupno.Size = new Size(172, 27);
            txtIznosUkupno.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 56);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 15;
            label5.Text = "Potvrda:";
            // 
            // dgvPotvrda
            // 
            dgvPotvrda.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPotvrda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPotvrda.Location = new Point(14, 95);
            dgvPotvrda.Name = "dgvPotvrda";
            dgvPotvrda.RowHeadersWidth = 51;
            dgvPotvrda.Size = new Size(416, 282);
            dgvPotvrda.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(480, 99);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 31;
            label9.Text = "Zaposleni";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(480, 47);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 30;
            label8.Text = "Kupac";
            // 
            // btnPretraziPotvrdu
            // 
            btnPretraziPotvrdu.BackColor = SystemColors.ButtonHighlight;
            btnPretraziPotvrdu.Location = new Point(821, 47);
            btnPretraziPotvrdu.Name = "btnPretraziPotvrdu";
            btnPretraziPotvrdu.Size = new Size(94, 55);
            btnPretraziPotvrdu.TabIndex = 27;
            btnPretraziPotvrdu.Text = "Pretraži potvrdu";
            btnPretraziPotvrdu.UseVisualStyleBackColor = false;
            btnPretraziPotvrdu.Click += btnPretraziPotvrdu_Click;
            // 
            // comboBoxZaposleni
            // 
            comboBoxZaposleni.FormattingEnabled = true;
            comboBoxZaposleni.Location = new Point(560, 95);
            comboBoxZaposleni.Name = "comboBoxZaposleni";
            comboBoxZaposleni.Size = new Size(151, 28);
            comboBoxZaposleni.TabIndex = 29;
            // 
            // comboBoxKupac
            // 
            comboBoxKupac.FormattingEnabled = true;
            comboBoxKupac.Location = new Point(560, 44);
            comboBoxKupac.Name = "comboBoxKupac";
            comboBoxKupac.Size = new Size(151, 28);
            comboBoxKupac.TabIndex = 28;
            // 
            // btnDodajStavkuPotvrde
            // 
            btnDodajStavkuPotvrde.BackColor = SystemColors.ButtonHighlight;
            btnDodajStavkuPotvrde.Location = new Point(821, 405);
            btnDodajStavkuPotvrde.Name = "btnDodajStavkuPotvrde";
            btnDodajStavkuPotvrde.Size = new Size(99, 48);
            btnDodajStavkuPotvrde.TabIndex = 31;
            btnDodajStavkuPotvrde.Text = "Dodaj stavku";
            btnDodajStavkuPotvrde.UseVisualStyleBackColor = false;
            btnDodajStavkuPotvrde.Click += btnDodajStavkuPotvrde_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(467, 447);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 30;
            label11.Text = "Događaj";
            // 
            // comboBoxDogadjaj
            // 
            comboBoxDogadjaj.FormattingEnabled = true;
            comboBoxDogadjaj.Location = new Point(550, 439);
            comboBoxDogadjaj.Name = "comboBoxDogadjaj";
            comboBoxDogadjaj.Size = new Size(184, 28);
            comboBoxDogadjaj.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(466, 388);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 28;
            label10.Text = "Količina";
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(547, 383);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(187, 27);
            txtKolicina.TabIndex = 27;
            // 
            // btnPotvrdiIzmenu
            // 
            btnPotvrdiIzmenu.BackColor = SystemColors.ButtonHighlight;
            btnPotvrdiIzmenu.Location = new Point(112, 417);
            btnPotvrdiIzmenu.Name = "btnPotvrdiIzmenu";
            btnPotvrdiIzmenu.Size = new Size(213, 50);
            btnPotvrdiIzmenu.TabIndex = 32;
            btnPotvrdiIzmenu.Text = "Potvrdi izmene";
            btnPotvrdiIzmenu.UseVisualStyleBackColor = false;
            btnPotvrdiIzmenu.Click += btnPotvrdiIzmenu_Click;
            // 
            // UCIzmenaPotvrde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(btnPotvrdiIzmenu);
            Controls.Add(btnDodajStavkuPotvrde);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(comboBoxDogadjaj);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(dgvPotvrda);
            Controls.Add(txtKolicina);
            Controls.Add(btnPretraziPotvrdu);
            Controls.Add(panelSkriveni);
            Controls.Add(comboBoxZaposleni);
            Controls.Add(comboBoxKupac);
            Name = "UCIzmenaPotvrde";
            Size = new Size(966, 502);
            panelSkriveni.ResumeLayout(false);
            panelSkriveni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPotvrda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSkriveni;
        private TextBox txtPopust;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnObrisiStavkuPotvrde;
        private Label label4;
        private TextBox txtDatum;
        private TextBox txtCena;
        private TextBox txtIznosUkupno;
        private Label label5;
        private DataGridView dgvPotvrda;
        private Label label9;
        private Label label8;
        private Button btnPretraziPotvrdu;
        private ComboBox comboBoxZaposleni;
        private ComboBox comboBoxKupac;
        private Button btnDodajStavkuPotvrde;
        private Label label11;
        private ComboBox comboBoxDogadjaj;
        private Label label10;
        private TextBox txtKolicina;
        private Button btnPotvrdiIzmenu;
    }
}
