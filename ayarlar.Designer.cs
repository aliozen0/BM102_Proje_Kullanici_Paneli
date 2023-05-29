namespace ucuncuApp
{
    partial class ayarlar
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            btnCikis = new Button();
            btnSifreDegistir = new Button();
            buttonEpostaDegistir = new Button();
            textBoxYeniSifreTekrar = new TextBox();
            textBoxYeniSifre = new TextBox();
            textBoxYeniEposta = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Brown;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = SystemColors.Control;
            btnCikis.Location = new Point(266, 462);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(104, 36);
            btnCikis.TabIndex = 14;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.FlatStyle = FlatStyle.Flat;
            btnSifreDegistir.Location = new Point(438, 362);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(135, 40);
            btnSifreDegistir.TabIndex = 15;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = true;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // buttonEpostaDegistir
            // 
            buttonEpostaDegistir.FlatStyle = FlatStyle.Flat;
            buttonEpostaDegistir.Location = new Point(603, 105);
            buttonEpostaDegistir.Name = "buttonEpostaDegistir";
            buttonEpostaDegistir.Size = new Size(153, 38);
            buttonEpostaDegistir.TabIndex = 16;
            buttonEpostaDegistir.Text = "E-Posta Değiştir";
            buttonEpostaDegistir.UseVisualStyleBackColor = true;
            buttonEpostaDegistir.Click += buttonEpostaDegistir_Click;
            // 
            // textBoxYeniSifreTekrar
            // 
            textBoxYeniSifreTekrar.BackColor = SystemColors.Control;
            textBoxYeniSifreTekrar.Location = new Point(219, 300);
            textBoxYeniSifreTekrar.Name = "textBoxYeniSifreTekrar";
            textBoxYeniSifreTekrar.PasswordChar = '*';
            textBoxYeniSifreTekrar.Size = new Size(354, 32);
            textBoxYeniSifreTekrar.TabIndex = 12;
            // 
            // textBoxYeniSifre
            // 
            textBoxYeniSifre.BackColor = SystemColors.Control;
            textBoxYeniSifre.Location = new Point(219, 235);
            textBoxYeniSifre.Name = "textBoxYeniSifre";
            textBoxYeniSifre.PasswordChar = '*';
            textBoxYeniSifre.Size = new Size(354, 32);
            textBoxYeniSifre.TabIndex = 13;
            // 
            // textBoxYeniEposta
            // 
            textBoxYeniEposta.BackColor = SystemColors.Control;
            textBoxYeniEposta.Location = new Point(219, 109);
            textBoxYeniEposta.Name = "textBoxYeniEposta";
            textBoxYeniEposta.Size = new Size(354, 32);
            textBoxYeniEposta.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 468);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 6;
            label6.Text = "HESAPTAN CIKIŞ YAP:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 303);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 7;
            label5.Text = "Yeni Şifre Tekrar :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 235);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 8;
            label4.Text = "Yeni Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 187);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 9;
            label3.Text = "ŞİFRE DEĞİŞTİR :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 116);
            label2.Name = "label2";
            label2.Size = new Size(173, 25);
            label2.TabIndex = 10;
            label2.Text = "E-POSTA DEĞİŞTİR :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(327, 11);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 5;
            label1.Text = "AYARLAR:";
            // 
            // ayarlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnCikis);
            Controls.Add(btnSifreDegistir);
            Controls.Add(buttonEpostaDegistir);
            Controls.Add(textBoxYeniSifreTekrar);
            Controls.Add(textBoxYeniSifre);
            Controls.Add(textBoxYeniEposta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ayarlar";
            Size = new Size(778, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCikis;
        private Button btnSifreDegistir;
        private Button buttonEpostaDegistir;
        private TextBox textBoxYeniSifreTekrar;
        private TextBox textBoxYeniSifre;
        private TextBox textBoxYeniEposta;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
