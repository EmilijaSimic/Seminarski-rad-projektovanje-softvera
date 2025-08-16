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
            button1 = new Button();
            panelSkriveni = new Panel();
            txtPopust = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnObrisiDogadjaj = new Button();
            label4 = new Label();
            txtDatum = new TextBox();
            txtCena = new TextBox();
            txtIznosUkupno = new TextBox();
            btnPretraziDogadjaj = new Button();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnPretraziKupca = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            btnNapraviDogadjaj = new Button();
            txtPretraziDogađaj = new TextBox();
            dgvDogadjaji = new DataGridView();
            panelPotvrda.SuspendLayout();
            panelSkriveni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDogadjaji).BeginInit();
            SuspendLayout();
            // 
            // panelPotvrda
            // 
            panelPotvrda.Controls.Add(button1);
            panelPotvrda.Controls.Add(panelSkriveni);
            panelPotvrda.Controls.Add(label11);
            panelPotvrda.Controls.Add(comboBox3);
            panelPotvrda.Controls.Add(label10);
            panelPotvrda.Controls.Add(textBox1);
            panelPotvrda.Controls.Add(label9);
            panelPotvrda.Controls.Add(label8);
            panelPotvrda.Controls.Add(btnPretraziKupca);
            panelPotvrda.Controls.Add(label7);
            panelPotvrda.Controls.Add(comboBox2);
            panelPotvrda.Controls.Add(comboBox1);
            panelPotvrda.Controls.Add(label5);
            panelPotvrda.Controls.Add(btnNapraviDogadjaj);
            panelPotvrda.Controls.Add(txtPretraziDogađaj);
            panelPotvrda.Controls.Add(dgvDogadjaji);
            panelPotvrda.Location = new Point(19, 11);
            panelPotvrda.Name = "panelPotvrda";
            panelPotvrda.Size = new Size(954, 420);
            panelPotvrda.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(761, 270);
            button1.Name = "button1";
            button1.Size = new Size(99, 48);
            button1.TabIndex = 25;
            button1.Text = "Dodaj stavku";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelSkriveni
            // 
            panelSkriveni.Controls.Add(txtPopust);
            panelSkriveni.Controls.Add(label1);
            panelSkriveni.Controls.Add(label2);
            panelSkriveni.Controls.Add(label3);
            panelSkriveni.Controls.Add(btnObrisiDogadjaj);
            panelSkriveni.Controls.Add(label4);
            panelSkriveni.Controls.Add(txtDatum);
            panelSkriveni.Controls.Add(txtCena);
            panelSkriveni.Controls.Add(txtIznosUkupno);
            panelSkriveni.Controls.Add(btnPretraziDogadjaj);
            panelSkriveni.Location = new Point(469, 214);
            panelSkriveni.Name = "panelSkriveni";
            panelSkriveni.Size = new Size(460, 193);
            panelSkriveni.TabIndex = 12;
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
            // btnObrisiDogadjaj
            // 
            btnObrisiDogadjaj.BackColor = SystemColors.ButtonHighlight;
            btnObrisiDogadjaj.Location = new Point(364, 117);
            btnObrisiDogadjaj.Name = "btnObrisiDogadjaj";
            btnObrisiDogadjaj.Size = new Size(94, 50);
            btnObrisiDogadjaj.TabIndex = 4;
            btnObrisiDogadjaj.Text = "Obriši stavku";
            btnObrisiDogadjaj.UseVisualStyleBackColor = false;
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
            // btnPretraziDogadjaj
            // 
            btnPretraziDogadjaj.BackColor = SystemColors.ButtonHighlight;
            btnPretraziDogadjaj.Location = new Point(364, 16);
            btnPretraziDogadjaj.Name = "btnPretraziDogadjaj";
            btnPretraziDogadjaj.Size = new Size(94, 55);
            btnPretraziDogadjaj.TabIndex = 2;
            btnPretraziDogadjaj.Text = "Pretraži potvrdu";
            btnPretraziDogadjaj.UseVisualStyleBackColor = false;
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(580, 316);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 23;
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
            // textBox1
            // 
            textBox1.Location = new Point(577, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(497, 184);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 19;
            label9.Text = "Zaposleni";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 132);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 18;
            label8.Text = "Kupac";
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(577, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(577, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
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
            // btnNapraviDogadjaj
            // 
            btnNapraviDogadjaj.BackColor = SystemColors.ButtonHighlight;
            btnNapraviDogadjaj.Location = new Point(529, 362);
            btnNapraviDogadjaj.Name = "btnNapraviDogadjaj";
            btnNapraviDogadjaj.Size = new Size(299, 36);
            btnNapraviDogadjaj.TabIndex = 10;
            btnNapraviDogadjaj.Text = "Napravi";
            btnNapraviDogadjaj.UseVisualStyleBackColor = false;
            // 
            // txtPretraziDogađaj
            // 
            txtPretraziDogađaj.Location = new Point(511, 56);
            txtPretraziDogađaj.Name = "txtPretraziDogađaj";
            txtPretraziDogađaj.Size = new Size(217, 27);
            txtPretraziDogađaj.TabIndex = 3;
            // 
            // dgvDogadjaji
            // 
            dgvDogadjaji.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDogadjaji.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDogadjaji.Location = new Point(29, 56);
            dgvDogadjaji.Name = "dgvDogadjaji";
            dgvDogadjaji.RowHeadersWidth = 51;
            dgvDogadjaji.Size = new Size(416, 282);
            dgvDogadjaji.TabIndex = 0;
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
            panelSkriveni.ResumeLayout(false);
            panelSkriveni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDogadjaji).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPotvrda;
        private Button btnObrisiDogadjaj;
        private Button btnNapraviDogadjaj;
        private TextBox txtPretraziDogađaj;
        private TextBox txtCena;
        private Button btnPretraziDogadjaj;
        private TextBox txtIznosUkupno;
        private TextBox txtPopust;
        private TextBox txtDatum;
        private TextBox txtMesto;
        private DataGridView dgvDogadjaji;
        private TextBox txtHala;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelSkriveni;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Button btnPretraziKupca;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private TextBox textBox1;
        private Button button1;
        private Label label11;
        private ComboBox comboBox3;
    }
}
