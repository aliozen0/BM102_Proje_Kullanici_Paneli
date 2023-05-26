namespace ucuncuApp
{
    partial class odeme
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
            btnSiparisOlustur = new Button();
            radioNakit = new RadioButton();
            radioPos = new RadioButton();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblYemekler = new Label();
            lblUcret = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSiparisOlustur
            // 
            btnSiparisOlustur.BackColor = Color.Transparent;
            btnSiparisOlustur.FlatStyle = FlatStyle.Flat;
            btnSiparisOlustur.Location = new Point(532, 462);
            btnSiparisOlustur.Name = "btnSiparisOlustur";
            btnSiparisOlustur.Size = new Size(151, 56);
            btnSiparisOlustur.TabIndex = 13;
            btnSiparisOlustur.Text = "SİPARİŞ VER";
            btnSiparisOlustur.UseVisualStyleBackColor = false;
            btnSiparisOlustur.Click += btnSiparisOlustur_Click;
            // 
            // radioNakit
            // 
            radioNakit.AutoSize = true;
            radioNakit.Location = new Point(293, 431);
            radioNakit.Name = "radioNakit";
            radioNakit.Size = new Size(85, 29);
            radioNakit.TabIndex = 11;
            radioNakit.TabStop = true;
            radioNakit.Text = "NAKİT";
            radioNakit.UseVisualStyleBackColor = true;
            // 
            // radioPos
            // 
            radioPos.AutoSize = true;
            radioPos.Location = new Point(293, 382);
            radioPos.Name = "radioPos";
            radioPos.Size = new Size(190, 29);
            radioPos.TabIndex = 12;
            radioPos.TabStop = true;
            radioPos.Text = "POS CİHAZI (KART)";
            radioPos.UseVisualStyleBackColor = true;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = SystemColors.Control;
            txtAdSoyad.Location = new Point(293, 138);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(347, 32);
            txtAdSoyad.TabIndex = 8;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = SystemColors.Control;
            txtTelefon.Location = new Point(293, 205);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(347, 32);
            txtTelefon.TabIndex = 9;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = SystemColors.Control;
            txtAdres.Location = new Point(293, 283);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(347, 64);
            txtAdres.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 382);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 4;
            label4.Text = "ÖDEME YÖNTEMİ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 286);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 5;
            label3.Text = "ADRES :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 208);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 6;
            label2.Text = "TELEFON NO :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 141);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 7;
            label1.Text = "AD SOYAD :";
            // 
            // lblYemekler
            // 
            lblYemekler.AutoSize = true;
            lblYemekler.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblYemekler.Location = new Point(89, 55);
            lblYemekler.Name = "lblYemekler";
            lblYemekler.Size = new Size(0, 19);
            lblYemekler.TabIndex = 14;
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblUcret.Location = new Point(89, 101);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new Size(0, 19);
            lblUcret.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(293, 12);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 16;
            label5.Text = "ÖDEME EKRANI";
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label5);
            Controls.Add(lblUcret);
            Controls.Add(lblYemekler);
            Controls.Add(btnSiparisOlustur);
            Controls.Add(radioNakit);
            Controls.Add(radioPos);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdres);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "odeme";
            Size = new Size(778, 530);
            Load += odeme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiparisOlustur;
        private RadioButton radioNakit;
        private RadioButton radioPos;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblYemekler;
        private Label lblUcret;
        private Label label5;
    }
}
