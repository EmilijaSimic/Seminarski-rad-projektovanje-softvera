namespace Klijent
{
    partial class LoginForma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKorIme = new Label();
            lblLozinka = new Label();
            txtKorIme = new TextBox();
            txtLozinka = new TextBox();
            btnPrijaviSe = new Button();
            SuspendLayout();
            // 
            // lblKorIme
            // 
            lblKorIme.AutoSize = true;
            lblKorIme.Location = new Point(89, 94);
            lblKorIme.Name = "lblKorIme";
            lblKorIme.Size = new Size(106, 20);
            lblKorIme.TabIndex = 0;
            lblKorIme.Text = "Korisnicko ime";
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Location = new Point(107, 157);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(59, 20);
            lblLozinka.TabIndex = 1;
            lblLozinka.Text = "Lozinka";
            // 
            // txtKorIme
            // 
            txtKorIme.Location = new Point(261, 89);
            txtKorIme.Name = "txtKorIme";
            txtKorIme.Size = new Size(173, 27);
            txtKorIme.TabIndex = 2;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(262, 158);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(172, 27);
            txtLozinka.TabIndex = 3;
            // 
            // btnPrijaviSe
            // 
            btnPrijaviSe.Location = new Point(204, 249);
            btnPrijaviSe.Name = "btnPrijaviSe";
            btnPrijaviSe.Size = new Size(94, 29);
            btnPrijaviSe.TabIndex = 4;
            btnPrijaviSe.Text = "Prijavi se";
            btnPrijaviSe.UseVisualStyleBackColor = true;
            btnPrijaviSe.Click += btnPrijaviSe_Click;
            // 
            // LoginForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 312);
            Controls.Add(btnPrijaviSe);
            Controls.Add(txtLozinka);
            Controls.Add(txtKorIme);
            Controls.Add(lblLozinka);
            Controls.Add(lblKorIme);
            Name = "LoginForma";
            Text = "Login forma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKorIme;
        private Label lblLozinka;
        private TextBox txtKorIme;
        private TextBox txtLozinka;
        private Button btnPrijaviSe;
    }
}
