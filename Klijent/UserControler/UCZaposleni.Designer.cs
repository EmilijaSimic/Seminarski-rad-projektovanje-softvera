namespace Klijent.UserControler
{
    partial class UCZaposleni
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
            panelZaposleni = new Panel();
            dateTimeKraj = new DateTimePicker();
            dateTimePocetak = new DateTimePicker();
            comboBoxPozicije = new ComboBox();
            btnPromeniZaposlenog = new Button();
            btnIzmeniZaposlenog2 = new Button();
            btnObrisiZaposlenog = new Button();
            btnNapraviZaposlenog = new Button();
            txtLozinka = new TextBox();
            btnDodajPoziciju = new Button();
            txtKorIme = new TextBox();
            txtPrezime = new TextBox();
            dgvZaposleni = new DataGridView();
            txtIme = new TextBox();
            txtJMBG = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelZaposleni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            SuspendLayout();
            // 
            // panelZaposleni
            // 
            panelZaposleni.Controls.Add(dateTimeKraj);
            panelZaposleni.Controls.Add(dateTimePocetak);
            panelZaposleni.Controls.Add(comboBoxPozicije);
            panelZaposleni.Controls.Add(btnPromeniZaposlenog);
            panelZaposleni.Controls.Add(btnIzmeniZaposlenog2);
            panelZaposleni.Controls.Add(btnObrisiZaposlenog);
            panelZaposleni.Controls.Add(btnNapraviZaposlenog);
            panelZaposleni.Controls.Add(txtLozinka);
            panelZaposleni.Controls.Add(btnDodajPoziciju);
            panelZaposleni.Controls.Add(txtKorIme);
            panelZaposleni.Controls.Add(txtPrezime);
            panelZaposleni.Controls.Add(dgvZaposleni);
            panelZaposleni.Controls.Add(txtIme);
            panelZaposleni.Controls.Add(txtJMBG);
            panelZaposleni.Controls.Add(label5);
            panelZaposleni.Controls.Add(label4);
            panelZaposleni.Controls.Add(label3);
            panelZaposleni.Controls.Add(label2);
            panelZaposleni.Controls.Add(label1);
            panelZaposleni.Location = new Point(5, 3);
            panelZaposleni.Name = "panelZaposleni";
            panelZaposleni.Size = new Size(954, 420);
            panelZaposleni.TabIndex = 4;
            // 
            // dateTimeKraj
            // 
            dateTimeKraj.Location = new Point(577, 62);
            dateTimeKraj.Name = "dateTimeKraj";
            dateTimeKraj.Size = new Size(250, 27);
            dateTimeKraj.TabIndex = 14;
            // 
            // dateTimePocetak
            // 
            dateTimePocetak.Location = new Point(577, 23);
            dateTimePocetak.Name = "dateTimePocetak";
            dateTimePocetak.Size = new Size(250, 27);
            dateTimePocetak.TabIndex = 13;
            // 
            // comboBoxPozicije
            // 
            comboBoxPozicije.FormattingEnabled = true;
            comboBoxPozicije.Location = new Point(390, 46);
            comboBoxPozicije.Name = "comboBoxPozicije";
            comboBoxPozicije.Size = new Size(151, 28);
            comboBoxPozicije.TabIndex = 12;
            // 
            // btnPromeniZaposlenog
            // 
            btnPromeniZaposlenog.BackColor = SystemColors.ButtonHighlight;
            btnPromeniZaposlenog.Location = new Point(843, 354);
            btnPromeniZaposlenog.Name = "btnPromeniZaposlenog";
            btnPromeniZaposlenog.Size = new Size(94, 44);
            btnPromeniZaposlenog.TabIndex = 5;
            btnPromeniZaposlenog.Text = "Izmeni";
            btnPromeniZaposlenog.UseVisualStyleBackColor = false;
            btnPromeniZaposlenog.Click += btnPromeniZaposlenog_Click;
            // 
            // btnIzmeniZaposlenog2
            // 
            btnIzmeniZaposlenog2.BackColor = SystemColors.ButtonHighlight;
            btnIzmeniZaposlenog2.Location = new Point(29, 319);
            btnIzmeniZaposlenog2.Name = "btnIzmeniZaposlenog2";
            btnIzmeniZaposlenog2.Size = new Size(299, 48);
            btnIzmeniZaposlenog2.TabIndex = 11;
            btnIzmeniZaposlenog2.Text = "Izmeni";
            btnIzmeniZaposlenog2.UseVisualStyleBackColor = false;
            btnIzmeniZaposlenog2.Click += btnIzmeniZaposlenog2_Click;
            // 
            // btnObrisiZaposlenog
            // 
            btnObrisiZaposlenog.BackColor = SystemColors.ButtonHighlight;
            btnObrisiZaposlenog.Location = new Point(843, 294);
            btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            btnObrisiZaposlenog.Size = new Size(94, 44);
            btnObrisiZaposlenog.TabIndex = 4;
            btnObrisiZaposlenog.Text = "Obriši";
            btnObrisiZaposlenog.UseVisualStyleBackColor = false;
            btnObrisiZaposlenog.Click += btnObrisiZaposlenog_Click;
            // 
            // btnNapraviZaposlenog
            // 
            btnNapraviZaposlenog.BackColor = SystemColors.ButtonHighlight;
            btnNapraviZaposlenog.Location = new Point(27, 290);
            btnNapraviZaposlenog.Name = "btnNapraviZaposlenog";
            btnNapraviZaposlenog.Size = new Size(299, 48);
            btnNapraviZaposlenog.TabIndex = 10;
            btnNapraviZaposlenog.Text = "Napravi";
            btnNapraviZaposlenog.UseVisualStyleBackColor = false;
            btnNapraviZaposlenog.Click += btnNapraviZaposlenog_Click;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(156, 212);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(172, 27);
            txtLozinka.TabIndex = 9;
            // 
            // btnDodajPoziciju
            // 
            btnDodajPoziciju.BackColor = SystemColors.ButtonHighlight;
            btnDodajPoziciju.Location = new Point(839, 102);
            btnDodajPoziciju.Name = "btnDodajPoziciju";
            btnDodajPoziciju.Size = new Size(108, 84);
            btnDodajPoziciju.TabIndex = 2;
            btnDodajPoziciju.Text = "Dodaj poziciju zaposlenom";
            btnDodajPoziciju.UseVisualStyleBackColor = false;
            btnDodajPoziciju.Click += btnDodajPoziciju_Click;
            // 
            // txtKorIme
            // 
            txtKorIme.Location = new Point(156, 166);
            txtKorIme.Name = "txtKorIme";
            txtKorIme.Size = new Size(172, 27);
            txtKorIme.TabIndex = 8;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(158, 120);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(170, 27);
            txtPrezime.TabIndex = 7;
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.BackgroundColor = SystemColors.ButtonHighlight;
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZaposleni.Location = new Point(390, 116);
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.RowHeadersWidth = 51;
            dgvZaposleni.Size = new Size(416, 282);
            dgvZaposleni.TabIndex = 0;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(158, 74);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(170, 27);
            txtIme.TabIndex = 6;
            // 
            // txtJMBG
            // 
            txtJMBG.Location = new Point(157, 32);
            txtJMBG.Name = "txtJMBG";
            txtJMBG.Size = new Size(171, 27);
            txtJMBG.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 215);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Lozinka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 166);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 3;
            label4.Text = "Korisnicko ime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 123);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Prezime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 74);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Ime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "JMBG";
            // 
            // UCZaposleni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(panelZaposleni);
            Name = "UCZaposleni";
            Size = new Size(964, 430);
            panelZaposleni.ResumeLayout(false);
            panelZaposleni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelZaposleni;
        private Button btnPromeniZaposlenog;
        private Button btnIzmeniZaposlenog2;
        private Button btnObrisiZaposlenog;
        private Button btnNapraviZaposlenog;
        private TextBox txtLozinka;
        private Button btnDodajPoziciju;
        private TextBox txtKorIme;
        private TextBox txtPrezime;
        private DataGridView dgvZaposleni;
        private TextBox txtIme;
        private TextBox txtJMBG;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxPozicije;
        private DateTimePicker dateTimeKraj;
        private DateTimePicker dateTimePocetak;
    }
}
