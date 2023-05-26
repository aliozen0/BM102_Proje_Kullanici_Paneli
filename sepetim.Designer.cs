namespace ucuncuApp
{
    partial class sepetim
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
            panelYemekler = new FlowLayoutPanel();
            label1 = new Label();
            lblToplamUcret = new Label();
            SuspendLayout();
            // 
            // panelYemekler
            // 
            panelYemekler.Location = new Point(19, 35);
            panelYemekler.Name = "panelYemekler";
            panelYemekler.Size = new Size(370, 444);
            panelYemekler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(145, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 1;
            label1.Text = "Sepetim";
            // 
            // lblToplamUcret
            // 
            lblToplamUcret.AutoSize = true;
            lblToplamUcret.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblToplamUcret.Location = new Point(93, 491);
            lblToplamUcret.Name = "lblToplamUcret";
            lblToplamUcret.Size = new Size(0, 28);
            lblToplamUcret.TabIndex = 2;
            // 
            // sepetim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblToplamUcret);
            Controls.Add(label1);
            Controls.Add(panelYemekler);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "sepetim";
            Size = new Size(532, 530);
            Load += sepetim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelYemekler;
        private Label label1;
        private Label lblToplamUcret;
    }
}
