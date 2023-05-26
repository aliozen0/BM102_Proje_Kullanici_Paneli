namespace ucuncuApp
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            labelMail = new Label();
            labelSifre = new Label();
            label3 = new Label();
            textBoxSifre = new TextBox();
            textBoxMail = new TextBox();
            btnGiris = new Button();
            panelGiris = new Panel();
            button1 = new Button();
            labelAd = new Label();
            labelSoyad = new Label();
            labelTel = new Label();
            labelEposta = new Label();
            labelSifreyeni = new Label();
            labelSifretekrar = new Label();
            textBoxSifreTekrar = new TextBox();
            textBoxSifreyeni = new TextBox();
            textBoxEposta = new TextBox();
            textBoxTel = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxAd = new TextBox();
            btnUyeol = new Button();
            btnGeri = new Button();
            panelUye = new Panel();
            label1 = new Label();
            panelGiris.SuspendLayout();
            panelUye.SuspendLayout();
            SuspendLayout();
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.BackColor = Color.Transparent;
            labelMail.Location = new Point(20, 51);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(105, 32);
            labelMail.TabIndex = 0;
            labelMail.Text = "E Posta :";
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.BackColor = Color.Transparent;
            labelSifre.Location = new Point(50, 161);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(75, 32);
            labelSifre.TabIndex = 0;
            labelSifre.Text = "Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Algerian", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(167, 150);
            label3.Name = "label3";
            label3.Size = new Size(254, 41);
            label3.TabIndex = 1;
            label3.Text = "hosgeldiniz";
            // 
            // textBoxSifre
            // 
            textBoxSifre.BackColor = SystemColors.Control;
            textBoxSifre.Location = new Point(154, 158);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.PasswordChar = '*';
            textBoxSifre.Size = new Size(332, 39);
            textBoxSifre.TabIndex = 2;
            // 
            // textBoxMail
            // 
            textBoxMail.BackColor = SystemColors.Control;
            textBoxMail.Location = new Point(154, 48);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(332, 39);
            textBoxMail.TabIndex = 2;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = SystemColors.ButtonFace;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.ForeColor = Color.CadetBlue;
            btnGiris.Location = new Point(340, 271);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(146, 53);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // panelGiris
            // 
            panelGiris.BackColor = Color.Transparent;
            panelGiris.Controls.Add(btnGiris);
            panelGiris.Controls.Add(textBoxMail);
            panelGiris.Controls.Add(textBoxSifre);
            panelGiris.Controls.Add(labelSifre);
            panelGiris.Controls.Add(labelMail);
            panelGiris.Location = new Point(475, 251);
            panelGiris.Name = "panelGiris";
            panelGiris.Size = new Size(505, 331);
            panelGiris.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(317, 649);
            button1.Name = "button1";
            button1.Size = new Size(154, 40);
            button1.TabIndex = 5;
            button1.Text = "Üye Ol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.BackColor = Color.Transparent;
            labelAd.Location = new Point(121, 40);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(57, 32);
            labelAd.TabIndex = 6;
            labelAd.Text = "Ad :";
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.BackColor = Color.Transparent;
            labelSoyad.Location = new Point(86, 94);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(92, 32);
            labelSoyad.TabIndex = 6;
            labelSoyad.Text = "Soyad :";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.BackColor = Color.Transparent;
            labelTel.Location = new Point(33, 157);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(145, 32);
            labelTel.TabIndex = 6;
            labelTel.Text = "Telefon No :";
            // 
            // labelEposta
            // 
            labelEposta.AutoSize = true;
            labelEposta.BackColor = Color.Transparent;
            labelEposta.Location = new Point(73, 218);
            labelEposta.Name = "labelEposta";
            labelEposta.Size = new Size(105, 32);
            labelEposta.TabIndex = 6;
            labelEposta.Text = "E Posta :";
            // 
            // labelSifreyeni
            // 
            labelSifreyeni.AutoSize = true;
            labelSifreyeni.BackColor = Color.Transparent;
            labelSifreyeni.Location = new Point(103, 280);
            labelSifreyeni.Name = "labelSifreyeni";
            labelSifreyeni.Size = new Size(75, 32);
            labelSifreyeni.TabIndex = 6;
            labelSifreyeni.Text = "Şifre :";
            // 
            // labelSifretekrar
            // 
            labelSifretekrar.AutoSize = true;
            labelSifretekrar.BackColor = Color.Transparent;
            labelSifretekrar.Location = new Point(26, 342);
            labelSifretekrar.Name = "labelSifretekrar";
            labelSifretekrar.Size = new Size(152, 32);
            labelSifretekrar.TabIndex = 6;
            labelSifretekrar.Text = "Şifre Tekrar :";
            // 
            // textBoxSifreTekrar
            // 
            textBoxSifreTekrar.BackColor = SystemColors.Control;
            textBoxSifreTekrar.Location = new Point(184, 339);
            textBoxSifreTekrar.Name = "textBoxSifreTekrar";
            textBoxSifreTekrar.PasswordChar = '*';
            textBoxSifreTekrar.Size = new Size(274, 39);
            textBoxSifreTekrar.TabIndex = 7;
            // 
            // textBoxSifreyeni
            // 
            textBoxSifreyeni.BackColor = SystemColors.Control;
            textBoxSifreyeni.Location = new Point(184, 277);
            textBoxSifreyeni.Name = "textBoxSifreyeni";
            textBoxSifreyeni.PasswordChar = '*';
            textBoxSifreyeni.Size = new Size(274, 39);
            textBoxSifreyeni.TabIndex = 7;
            // 
            // textBoxEposta
            // 
            textBoxEposta.BackColor = SystemColors.Control;
            textBoxEposta.Location = new Point(184, 215);
            textBoxEposta.Name = "textBoxEposta";
            textBoxEposta.Size = new Size(274, 39);
            textBoxEposta.TabIndex = 7;
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = SystemColors.Control;
            textBoxTel.Location = new Point(184, 154);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(274, 39);
            textBoxTel.TabIndex = 7;
            textBoxTel.KeyPress += textBoxTel_KeyPress;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.BackColor = SystemColors.Control;
            textBoxSoyad.Location = new Point(184, 91);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(274, 39);
            textBoxSoyad.TabIndex = 7;
            // 
            // textBoxAd
            // 
            textBoxAd.BackColor = SystemColors.Control;
            textBoxAd.Location = new Point(184, 37);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(274, 39);
            textBoxAd.TabIndex = 7;
            // 
            // btnUyeol
            // 
            btnUyeol.BackColor = SystemColors.ControlLightLight;
            btnUyeol.FlatStyle = FlatStyle.Flat;
            btnUyeol.ForeColor = Color.ForestGreen;
            btnUyeol.Location = new Point(319, 409);
            btnUyeol.Name = "btnUyeol";
            btnUyeol.Size = new Size(139, 50);
            btnUyeol.TabIndex = 8;
            btnUyeol.Text = "Üye Ol";
            btnUyeol.UseVisualStyleBackColor = false;
            btnUyeol.Click += btnUyeol_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = SystemColors.ControlLightLight;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.ForeColor = Color.IndianRed;
            btnGeri.Location = new Point(69, 409);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(109, 50);
            btnGeri.TabIndex = 9;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // panelUye
            // 
            panelUye.BackColor = Color.Transparent;
            panelUye.Controls.Add(btnGeri);
            panelUye.Controls.Add(btnUyeol);
            panelUye.Controls.Add(textBoxAd);
            panelUye.Controls.Add(textBoxSoyad);
            panelUye.Controls.Add(textBoxTel);
            panelUye.Controls.Add(textBoxEposta);
            panelUye.Controls.Add(textBoxSifreyeni);
            panelUye.Controls.Add(textBoxSifreTekrar);
            panelUye.Controls.Add(labelSifretekrar);
            panelUye.Controls.Add(labelSifreyeni);
            panelUye.Controls.Add(labelEposta);
            panelUye.Controls.Add(labelTel);
            panelUye.Controls.Add(labelSoyad);
            panelUye.Controls.Add(labelAd);
            panelUye.Location = new Point(475, 135);
            panelUye.Name = "panelUye";
            panelUye.Size = new Size(480, 467);
            panelUye.TabIndex = 10;
            panelUye.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(167, 258);
            label1.Name = "label1";
            label1.Size = new Size(275, 44);
            label1.TabIndex = 11;
            label1.Text = "Lezzetlere ulasmak için \r\nGiris Yapin\r\n";
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Orange_Gray_Simple_Blo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 701);
            Controls.Add(label1);
            Controls.Add(panelUye);
            Controls.Add(panelGiris);
            Controls.Add(button1);
            Controls.Add(label3);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GAZİ CAFE";
            FormClosing += frmGiris_FormClosing;
            Load += frmGiris_Load;
            panelGiris.ResumeLayout(false);
            panelGiris.PerformLayout();
            panelUye.ResumeLayout(false);
            panelUye.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMail;
        private Label labelSifre;
        private Label label3;
        private TextBox textBoxSifre;
        private TextBox textBoxMail;
        private Button btnGiris;
        private Panel panelGiris;
        private Button button1;
        private Label labelAd;
        private Label labelSoyad;
        private Label labelTel;
        private Label labelEposta;
        private Label labelSifreyeni;
        private Label labelSifretekrar;
        private TextBox textBoxSifreTekrar;
        private TextBox textBoxSifreyeni;
        private TextBox textBoxEposta;
        private TextBox textBoxTel;
        private TextBox textBoxSoyad;
        private TextBox textBoxAd;
        private Button btnUyeol;
        private Button btnGeri;
        private Panel panelUye;
        private Label label1;
    }
}