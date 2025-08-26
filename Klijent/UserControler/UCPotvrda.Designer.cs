namespace Klijent.UserControler
{
    partial class UCPotvrda
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
            panelPotvrda = new Panel();
            label9 = new Label();
            label8 = new Label();
            comboBoxZaposleni = new ComboBox();
            comboBoxKupac = new ComboBox();
            btnDodajStavkuPotvrde = new Button();
            label11 = new Label();
            comboBoxDogadjaj = new ComboBox();
            label10 = new Label();
            txtKolicina = new TextBox();
            btnPretraziKupca = new Button();
            btnNapraviPotvrdu = new Button();
            label7 = new Label();
            label5 = new Label();
            txtPretraziKupca = new TextBox();
            dgvPotvrda = new DataGridView();
            panelPotvrda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPotvrda).BeginInit();
            SuspendLayout();
            // 
            // panelPotvrda
            // 
            panelPotvrda.Controls.Add(label9);
            panelPotvrda.Controls.Add(label8);
            panelPotvrda.Controls.Add(comboBoxZaposleni);
            panelPotvrda.Controls.Add(comboBoxKupac);
            panelPotvrda.Controls.Add(btnDodajStavkuPotvrde);
            panelPotvrda.Controls.Add(label11);
            panelPotvrda.Controls.Add(comboBoxDogadjaj);
            panelPotvrda.Controls.Add(label10);
            panelPotvrda.Controls.Add(txtKolicina);
            panelPotvrda.Controls.Add(btnPretraziKupca);
            panelPotvrda.Controls.Add(btnNapraviPotvrdu);
            panelPotvrda.Controls.Add(label7);
            panelPotvrda.Controls.Add(label5);
            panelPotvrda.Controls.Add(txtPretraziKupca);
            panelPotvrda.Controls.Add(dgvPotvrda);
            panelPotvrda.Location = new Point(19, 11);
            panelPotvrda.Name = "panelPotvrda";
            panelPotvrda.Size = new Size(954, 420);
            panelPotvrda.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(500, 188);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 35;
            label9.Text = "Zaposleni";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(500, 136);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 34;
            label8.Text = "Kupac";
            // 
            // comboBoxZaposleni
            // 
            comboBoxZaposleni.FormattingEnabled = true;
            comboBoxZaposleni.Location = new Point(580, 184);
            comboBoxZaposleni.Name = "comboBoxZaposleni";
            comboBoxZaposleni.Size = new Size(193, 28);
            comboBoxZaposleni.TabIndex = 33;
            // 
            // comboBoxKupac
            // 
            comboBoxKupac.FormattingEnabled = true;
            comboBoxKupac.Location = new Point(580, 133);
            comboBoxKupac.Name = "comboBoxKupac";
            comboBoxKupac.Size = new Size(193, 28);
            comboBoxKupac.TabIndex = 32;
            // 
            // btnDodajStavkuPotvrde
            // 
            btnDodajStavkuPotvrde.BackColor = SystemColors.ButtonHighlight;
            btnDodajStavkuPotvrde.Location = new Point(807, 274);
            btnDodajStavkuPotvrde.Name = "btnDodajStavkuPotvrde";
            btnDodajStavkuPotvrde.Size = new Size(99, 48);
            btnDodajStavkuPotvrde.TabIndex = 25;
            btnDodajStavkuPotvrde.Text = "Dodaj stavku";
            btnDodajStavkuPotvrde.UseVisualStyleBackColor = false;
            btnDodajStavkuPotvrde.Click += btnDodajStavkuPotvrde_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(497, 324);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 24;
            label11.Text = "Događaj";
            // 
            // comboBoxDogadjaj
            // 
            comboBoxDogadjaj.FormattingEnabled = true;
            comboBoxDogadjaj.Location = new Point(580, 316);
            comboBoxDogadjaj.Name = "comboBoxDogadjaj";
            comboBoxDogadjaj.Size = new Size(193, 28);
            comboBoxDogadjaj.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(496, 265);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 22;
            label10.Text = "Količina";
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(577, 260);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(196, 27);
            txtKolicina.TabIndex = 20;
            // 
            // btnPretraziKupca
            // 
            btnPretraziKupca.BackColor = SystemColors.ButtonHighlight;
            btnPretraziKupca.Location = new Point(785, 54);
            btnPretraziKupca.Name = "btnPretraziKupca";
            btnPretraziKupca.Size = new Size(133, 29);
            btnPretraziKupca.TabIndex = 17;
            btnPretraziKupca.Text = "Pretraži kupca";
            btnPretraziKupca.UseVisualStyleBackColor = false;
            btnPretraziKupca.Click += btnPretraziKupca_Click;
            // 
            // btnNapraviPotvrdu
            // 
            btnNapraviPotvrdu.BackColor = SystemColors.ButtonHighlight;
            btnNapraviPotvrdu.Location = new Point(89, 358);
            btnNapraviPotvrdu.Name = "btnNapraviPotvrdu";
            btnNapraviPotvrdu.Size = new Size(299, 36);
            btnNapraviPotvrdu.TabIndex = 10;
            btnNapraviPotvrdu.Text = "Napravi";
            btnNapraviPotvrdu.UseVisualStyleBackColor = false;
            btnNapraviPotvrdu.Click += btnNapraviPotvrdu_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(514, 28);
            label7.Name = "label7";
            label7.Size = new Size(160, 20);
            label7.TabIndex = 16;
            label7.Text = "Ime kupca za pretragu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 22);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 13;
            label5.Text = "Potvrda:";
            // 
            // txtPretraziKupca
            // 
            txtPretraziKupca.Location = new Point(511, 56);
            txtPretraziKupca.Name = "txtPretraziKupca";
            txtPretraziKupca.Size = new Size(217, 27);
            txtPretraziKupca.TabIndex = 3;
            // 
            // dgvPotvrda
            // 
            dgvPotvrda.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPotvrda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPotvrda.Location = new Point(29, 56);
            dgvPotvrda.Name = "dgvPotvrda";
            dgvPotvrda.RowHeadersWidth = 51;
            dgvPotvrda.Size = new Size(416, 282);
            dgvPotvrda.TabIndex = 0;
            // 
            // UCPotvrda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(panelPotvrda);
            Name = "UCPotvrda";
            Size = new Size(993, 443);
            panelPotvrda.ResumeLayout(false);
            panelPotvrda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPotvrda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPotvrda;
        private Button btnNapraviPotvrdu;
        private TextBox txtPretraziKupca;
        private TextBox txtMesto;
        private DataGridView dgvPotvrda;
        private TextBox txtHala;
        private Label label5;
        private Button btnPretraziKupca;
        private Label label7;
        private Label label10;
        private TextBox txtKolicina;
        private Button btnDodajStavkuPotvrde;
        private Label label11;
        private ComboBox comboBoxDogadjaj;
        private Label label9;
        private Label label8;
        private ComboBox comboBoxZaposleni;
        private ComboBox comboBoxKupac;
    }
}
