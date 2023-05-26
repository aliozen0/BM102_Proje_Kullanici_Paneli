using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucuncuApp
{
    public partial class sepetim : UserControl
    {
        private string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
        private decimal toplamUcret = 0;

        public sepetim()
        {
            InitializeComponent();
        }

        private void sepetim_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public bool SepetBosMu()
        {
            return panelYemekler.Controls.Count == 0;
        }
        public void LoadData()
        {
            anaForm anaForm = (anaForm)this.FindForm();

            int kullaniciID = Convert.ToInt32(anaForm.KullaniciID);
            toplamUcret = 0;
            panelYemekler.Controls.Clear();
            List<Yemek1> yemekler = GetYemeklerByKullaniciID(kullaniciID);
            foreach (Yemek1 yemek in yemekler)
            {
                EkranaYemekEkle(yemek);
                toplamUcret += yemek.Ucret;
            }

            lblToplamUcret.Text = "Toplam Ücret: " + toplamUcret.ToString("C");
        }

        private List<Yemek1> GetYemeklerByKullaniciID(int kullaniciID)
        {
            List<Yemek1> yemekler = new List<Yemek1>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT yemekAdi, ucret, foto, yemekID FROM sepetim2 WHERE kullaniciID = @kullaniciID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string yemekAdi = reader.GetString(0);
                            decimal ucret = reader.GetDecimal(1);
                            byte[] fotoData = (byte[])reader.GetValue(2);
                            int yemekID = reader.GetInt32(3);

                            Yemek1 yemek = new Yemek1(yemekAdi, ucret, fotoData, yemekID);
                            yemekler.Add(yemek);
                        }
                    }
                }
            }

            return yemekler;
        }

        private void EkranaYemekEkle(Yemek1 yemek)
        {
            Panel panelYemek = new Panel();
            panelYemek.BorderStyle = BorderStyle.FixedSingle;
            panelYemek.Width = 340;
            panelYemek.Height = 70;

            PictureBox pictureBox = new PictureBox();
            using (MemoryStream ms = new MemoryStream(yemek.FotoData))
            {
                pictureBox.Image = Image.FromStream(ms);
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = 65;
            pictureBox.Height = 65;
            pictureBox.Top = (panelYemek.Height - pictureBox.Height) / 2;
            pictureBox.Left = 10;

            Label lblYemekAdi = new Label();
            lblYemekAdi.Text = yemek.YemekAdi;
            lblYemekAdi.AutoSize = true;
            lblYemekAdi.Font = new Font("Segoe UI Semibold", 10, FontStyle.Italic);
            lblYemekAdi.Left = pictureBox.Left + pictureBox.Width + 10;
            lblYemekAdi.Top = (panelYemek.Height - lblYemekAdi.Height - 30) / 2;

            Label lblUcret = new Label();
            lblUcret.Text = "Ücret: " + yemek.Ucret.ToString("C");
            lblUcret.AutoSize = true;
            lblUcret.Font = new Font("Segoe UI Semibold", 10, FontStyle.Italic);
            lblUcret.Left = pictureBox.Left + pictureBox.Width + 10;
            lblUcret.Top = lblYemekAdi.Top + lblYemekAdi.Height + 10;

            Button btnSepetIslem = new Button();
            btnSepetIslem.Text = "Sepetten Çıkar";
            btnSepetIslem.Font = new Font("Segoe UI Semibold", 9);
            btnSepetIslem.Width = 140;
            btnSepetIslem.Height = 28;
            btnSepetIslem.Left = lblUcret.Left + lblUcret.Width + 15;
            btnSepetIslem.Top = lblUcret.Top;
            btnSepetIslem.Click += (sender, e) =>
            {
                SepettenCikar(yemek.YemekID);
                panelYemekler.Controls.Remove(panelYemek);
                LoadData();
            };

            panelYemek.Controls.Add(pictureBox);
            panelYemek.Controls.Add(lblYemekAdi);
            panelYemek.Controls.Add(lblUcret);
            panelYemek.Controls.Add(btnSepetIslem);
            panelYemekler.AutoScroll = true;
            panelYemekler.Controls.Add(panelYemek);
        }

        private void SepettenCikar(int yemekID)
        {
            anaForm anaForm = (anaForm)this.FindForm();

            int kullaniciID = Convert.ToInt32(anaForm.KullaniciID);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE TOP(1) FROM sepetim2 WHERE kullaniciID = @kullaniciID AND yemekID = @yemekID";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                    command.Parameters.AddWithValue("@yemekID", yemekID);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Toplam ücreti güncelle
                    toplamUcret -= GetYemekUcret(yemekID);

                    lblToplamUcret.Text = "Toplam Ücret: " + toplamUcret.ToString("C");
                }
            }

           
        }

        private decimal GetYemekUcret(int yemekID)
        {
            decimal ucret = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ucret FROM sepetim2 WHERE yemekID = @yemekID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@yemekID", yemekID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ucret = reader.GetDecimal(0);
                        }
                    }
                }
            }

            return ucret;
        }

    }
}
