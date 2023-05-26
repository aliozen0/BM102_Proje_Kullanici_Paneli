namespace ucuncuApp
{
    partial class anaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaForm));
            btnPizza = new Button();
            btnBurger = new Button();
            btnDoner = new Button();
            btnMakarna = new Button();
            btnSogukIcecek = new Button();
            btnSicakIcecek = new Button();
            btnTatli = new Button();
            btnAnasayfa = new Button();
            btnSiparis = new Button();
            btnSepet = new Button();
            btnAyarlar = new Button();
            lblKullanici = new Label();
            panelYemekler = new FlowLayoutPanel();
            sepetim1 = new sepetim();
            ayarlar1 = new ayarlar();
            btnSiparisVer = new Button();
            odeme1 = new odeme();
            siparisler1 = new siparisler();
            anasayfa1 = new anasayfa();
            SuspendLayout();
            // 
            // btnPizza
            // 
            btnPizza.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPizza.Location = new Point(3, 135);
            btnPizza.Name = "btnPizza";
            btnPizza.Size = new Size(128, 48);
            btnPizza.TabIndex = 0;
            btnPizza.Text = "Pizza";
            btnPizza.UseVisualStyleBackColor = true;
            btnPizza.Click += btnPizza_Click;
            // 
            // btnBurger
            // 
            btnBurger.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBurger.Location = new Point(3, 205);
            btnBurger.Name = "btnBurger";
            btnBurger.Size = new Size(128, 48);
            btnBurger.TabIndex = 0;
            btnBurger.Text = "Hamburger";
            btnBurger.UseVisualStyleBackColor = true;
            btnBurger.Click += btnBurger_Click;
            // 
            // btnDoner
            // 
            btnDoner.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDoner.Location = new Point(3, 280);
            btnDoner.Name = "btnDoner";
            btnDoner.Size = new Size(128, 48);
            btnDoner.TabIndex = 0;
            btnDoner.Text = "Döner";
            btnDoner.UseVisualStyleBackColor = true;
            btnDoner.Click += btnDoner_Click;
            // 
            // btnMakarna
            // 
            btnMakarna.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMakarna.Location = new Point(3, 357);
            btnMakarna.Name = "btnMakarna";
            btnMakarna.Size = new Size(128, 48);
            btnMakarna.TabIndex = 0;
            btnMakarna.Text = "Makarna";
            btnMakarna.UseVisualStyleBackColor = true;
            btnMakarna.Click += btnMakarna_Click;
            // 
            // btnSogukIcecek
            // 
            btnSogukIcecek.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSogukIcecek.Location = new Point(3, 437);
            btnSogukIcecek.Name = "btnSogukIcecek";
            btnSogukIcecek.Size = new Size(128, 48);
            btnSogukIcecek.TabIndex = 0;
            btnSogukIcecek.Text = "Soğuk İçecek";
            btnSogukIcecek.UseVisualStyleBackColor = true;
            btnSogukIcecek.Click += btnSogukIcecek_Click;
            // 
            // btnSicakIcecek
            // 
            btnSicakIcecek.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSicakIcecek.Location = new Point(3, 511);
            btnSicakIcecek.Name = "btnSicakIcecek";
            btnSicakIcecek.Size = new Size(128, 48);
            btnSicakIcecek.TabIndex = 0;
            btnSicakIcecek.Text = "Sıcak İçecek";
            btnSicakIcecek.UseVisualStyleBackColor = true;
            btnSicakIcecek.Click += btnSicakIcecek_Click;
            // 
            // btnTatli
            // 
            btnTatli.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTatli.Location = new Point(3, 587);
            btnTatli.Name = "btnTatli";
            btnTatli.Size = new Size(128, 48);
            btnTatli.TabIndex = 0;
            btnTatli.Text = "Tatlı";
            btnTatli.UseVisualStyleBackColor = true;
            btnTatli.Click += btnTatli_Click;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAnasayfa.Location = new Point(253, 67);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(131, 38);
            btnAnasayfa.TabIndex = 1;
            btnAnasayfa.Text = "Anasayfa";
            btnAnasayfa.UseVisualStyleBackColor = true;
            btnAnasayfa.Click += btnAnasayfa_Click;
            // 
            // btnSiparis
            // 
            btnSiparis.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSiparis.Location = new Point(421, 67);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(131, 38);
            btnSiparis.TabIndex = 1;
            btnSiparis.Text = "Siparişlerim";
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // btnSepet
            // 
            btnSepet.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSepet.Location = new Point(586, 67);
            btnSepet.Name = "btnSepet";
            btnSepet.Size = new Size(131, 38);
            btnSepet.TabIndex = 1;
            btnSepet.Text = "Sepetim";
            btnSepet.UseVisualStyleBackColor = true;
            btnSepet.Click += btnSepet_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAyarlar.Location = new Point(756, 67);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(131, 38);
            btnAyarlar.TabIndex = 1;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = true;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.BackColor = Color.Transparent;
            lblKullanici.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKullanici.Location = new Point(12, 80);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(0, 25);
            lblKullanici.TabIndex = 2;
            // 
            // panelYemekler
            // 
            panelYemekler.BackColor = Color.Transparent;
            panelYemekler.Location = new Point(253, 130);
            panelYemekler.Name = "panelYemekler";
            panelYemekler.Size = new Size(708, 490);
            panelYemekler.TabIndex = 3;
            // 
            // sepetim1
            // 
            sepetim1.BackColor = Color.Transparent;
            sepetim1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            sepetim1.Location = new Point(365, 135);
            sepetim1.Margin = new Padding(4);
            sepetim1.Name = "sepetim1";
            sepetim1.Size = new Size(408, 559);
            sepetim1.TabIndex = 0;
            sepetim1.Visible = false;
            sepetim1.Load += sepetim1_Load;
            // 
            // ayarlar1
            // 
            ayarlar1.BackColor = Color.Transparent;
            ayarlar1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ayarlar1.Location = new Point(174, 124);
            ayarlar1.Margin = new Padding(4);
            ayarlar1.Name = "ayarlar1";
            ayarlar1.Size = new Size(863, 532);
            ayarlar1.TabIndex = 4;
            ayarlar1.Visible = false;
            ayarlar1.Load += ayarlar1_Load;
            // 
            // btnSiparisVer
            // 
            btnSiparisVer.BackColor = Color.Transparent;
            btnSiparisVer.FlatStyle = FlatStyle.Flat;
            btnSiparisVer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSiparisVer.Location = new Point(780, 507);
            btnSiparisVer.Name = "btnSiparisVer";
            btnSiparisVer.Size = new Size(142, 52);
            btnSiparisVer.TabIndex = 5;
            btnSiparisVer.Text = "Sipariş Ver";
            btnSiparisVer.UseVisualStyleBackColor = false;
            btnSiparisVer.Visible = false;
            btnSiparisVer.Click += btnSiparisVer_Click;
            // 
            // odeme1
            // 
            odeme1.BackColor = Color.Transparent;
            odeme1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            odeme1.Location = new Point(174, 112);
            odeme1.Margin = new Padding(4);
            odeme1.Name = "odeme1";
            odeme1.Size = new Size(839, 527);
            odeme1.TabIndex = 6;
            odeme1.Visible = false;
            // 
            // siparisler1
            // 
            siparisler1.BackColor = Color.Transparent;
            siparisler1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            siparisler1.Location = new Point(210, 118);
            siparisler1.Margin = new Padding(4);
            siparisler1.Name = "siparisler1";
            siparisler1.Size = new Size(771, 517);
            siparisler1.TabIndex = 7;
            // 
            // anasayfa1
            // 
            anasayfa1.BackColor = Color.Transparent;
            anasayfa1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            anasayfa1.Location = new Point(230, 124);
            anasayfa1.Margin = new Padding(4);
            anasayfa1.Name = "anasayfa1";
            anasayfa1.Size = new Size(731, 496);
            anasayfa1.TabIndex = 8;
            // 
            // anaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.arkaplan1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 701);
            Controls.Add(anasayfa1);
            Controls.Add(siparisler1);
            Controls.Add(odeme1);
            Controls.Add(btnSiparisVer);
            Controls.Add(ayarlar1);
            Controls.Add(sepetim1);
            Controls.Add(panelYemekler);
            Controls.Add(lblKullanici);
            Controls.Add(btnAyarlar);
            Controls.Add(btnSepet);
            Controls.Add(btnSiparis);
            Controls.Add(btnAnasayfa);
            Controls.Add(btnTatli);
            Controls.Add(btnSicakIcecek);
            Controls.Add(btnSogukIcecek);
            Controls.Add(btnMakarna);
            Controls.Add(btnDoner);
            Controls.Add(btnBurger);
            Controls.Add(btnPizza);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "anaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GAZİ CAFE";
            FormClosing += anaForm_FormClosing;
            Load += anaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPizza;
        private Button btnBurger;
        private Button btnDoner;
        private Button btnMakarna;
        private Button btnSogukIcecek;
        private Button btnSicakIcecek;
        private Button btnTatli;
        private Button btnAnasayfa;
        private Button btnSiparis;
        private Button btnSepet;
        private Button btnAyarlar;
        private Label lblKullanici;
        private FlowLayoutPanel panelYemekler;
        private sepetim sepetim1;
        private ayarlar ayarlar1;
        private Button btnSiparisVer;
        private odeme odeme1;
        private siparisler siparisler1;
        private anasayfa anasayfa1;
    }
}