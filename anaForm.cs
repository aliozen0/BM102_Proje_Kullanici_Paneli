using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucuncuApp
{
    public partial class anaForm : Form
    {
        private string kullaniciID;
        public string KullaniciID { get => kullaniciID; set => kullaniciID = value; }
        private SqlConnection baglanti = null;
        private string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";

        public anaForm(string kullaniciID)
        {
            InitializeComponent();
            this.KullaniciID = kullaniciID;
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
            anasayfa1.Visible = true;
            panelYemekler.Visible = false;
            siparisler1.Visible = false;
            baglanti = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
            bilgiGetir();
        }
        private void bilgiGetir()
        {
            string ad = "";
            string soyad = "";

            try
            {

                baglanti.Open();

                SqlCommand sqlKomut = new SqlCommand("SELECT ad, soyad FROM Kullanicilar WHERE KullaniciID = @kullaniciID\r\n", baglanti);
                sqlKomut.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                SqlDataReader sqlDR = sqlKomut.ExecuteReader();

                if (sqlDR.Read())
                {
                    ad = sqlDR["ad"].ToString();
                    soyad = sqlDR["soyad"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.ToString());

            }

            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }

            }
            lblKullanici.Text = "Hosgeldin " + ad + " " + soyad;

        }
        private void gizle()
        {
            sepetim1.Visible = false;
            ayarlar1.Visible = false;
            siparisler1.Visible = false;
            anasayfa1.Visible = false;
            odeme1.Visible = false;
            btnSiparisVer.Visible = false;
            panelYemekler.Visible = true;
        }
        private void btnPizza_Click(object sender, EventArgs e)
        {
            panelYemekler.Visible = true;
            List<Yemek> yemekler = GetYemeklerByKategori(1); // KategoriID'ye göre değiştirin

            panelYemekler.Controls.Clear();

            foreach (Yemek yemek in yemekler)
            {
                EkranaYemekEkle(yemek.YemekAdi, yemek.Ucret, yemek.FotoData, yemek.YemekID);
            }
            gizle();

        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            List<Yemek> yemekler = GetYemeklerByKategori(2); // KategoriID'ye göre değiştirin

            panelYemekler.Controls.Clear();

            foreach (Yemek yemek in yemekler)
            {
                EkranaYemekEkle(yemek.YemekAdi, yemek.Ucret, yemek.FotoData, yemek.YemekID);
            }
            gizle();
        }

        private void btnDoner_Click(object sender, EventArgs e)
        {
            List<Yemek> yemekler = GetYemeklerByKategori(3); // KategoriID'ye göre değiştirin

            panelYemekler.Controls.Clear();

            foreach (Yemek yemek in yemekler)
            {
                EkranaYemekEkle(yemek.YemekAdi, yemek.Ucret, yemek.FotoData, yemek.YemekID);
            }
            gizle();
        }

        private void btnMakarna_Click(object sender, EventArgs e)
        {
            List<Yemek> yemekler = GetYemeklerByKategori(4); // KategoriID'ye göre değiştirin

            panelYemekler.Controls.Clear();

            foreach (Yemek yemek in yemekler)
            {
                EkranaYemekEkle(yemek.YemekAdi, yemek.Ucret, yemek.FotoData, yemek.YemekID);
            }
            gizle();
        }

        private void btnSogukIcecek_Click(object sender, EventArgs e)
        {
            List<Yemek> yemekler = GetYemeklerByKategori(5); // KategoriID'ye göre değiştirin

            panelYemekler.Controls.Clear();

            foreach (Yemek yemek in yemekler)
            {
                EkranaYemekEkle(yemek.YemekAdi, yemek.Ucret, yemek.FotoData, yemek.YemekID);
            }
            gizle();
        }

        private void btnSicakIcecek_Click(object sender, EventArgs e)
        {
            List<Yemek> yemekler = GetYemeklerByKategori(6); // KategoriID'ye göre değiştirin

            panelYemekler.Controls.Clear();

            foreach (Yemek yemek in yemekler)
            {
                EkranaYemekEkle(yemek.YemekAdi, yemek.Ucret, yemek.FotoData, yemek.YemekID);
            }
            gizle();
        }

        private void btnTatli_Click(object sender, EventArgs e)
        {
            List<Yemek> yemekler = GetYemeklerByKategori(7); // KategoriID'ye göre değiştirin

            panelYemekler.Controls.Clear();

            foreach (Yemek yemek in yemekler)
            {
                EkranaYemekEkle(yemek.YemekAdi, yemek.Ucret, yemek.FotoData, yemek.YemekID);
            }
            gizle();
        }

        private List<Yemek> GetYemeklerByKategori(int kategoriID)
        {
            List<Yemek> yemekler = new List<Yemek>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT yemekAdi, ucret, foto, yemekID FROM yemekTablosu WHERE kategoriID = @kategoriID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kategoriID", kategoriID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string yemekAdi = reader.GetString(0);
                            decimal ucret = reader.GetDecimal(1);
                            byte[] fotoData = (byte[])reader.GetValue(2);
                            int yemekID = reader.GetInt32(3);

                            Yemek yemek = new Yemek(yemekAdi, ucret, fotoData, yemekID);
                            yemekler.Add(yemek);
                        }
                    }
                }
            }

            return yemekler;
        }

        private void EkranaYemekEkle(string yemekAdi, decimal ucret, byte[] fotoData, int yemekID)
        {
            Panel panelYemek = new Panel();
            panelYemek.BorderStyle = BorderStyle.FixedSingle;
            panelYemek.Width = 300;
            panelYemek.Height = 190;

            PictureBox pictureBox = new PictureBox();
            using (MemoryStream ms = new MemoryStream(fotoData))
            {
                pictureBox.Image = Image.FromStream(ms);
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = 100;
            pictureBox.Height = 100;
            pictureBox.Top = (panelYemek.Height - pictureBox.Height) / 2;
            pictureBox.Left = 10;

            Label lblYemekAdi = new Label();
            lblYemekAdi.Text = yemekAdi;
            lblYemekAdi.AutoSize = true;
            lblYemekAdi.Font = new Font("Segoe UI Semibold", 10, FontStyle.Italic);
            lblYemekAdi.Left = pictureBox.Left + pictureBox.Width + 10;
            lblYemekAdi.Top = (panelYemek.Height - lblYemekAdi.Height - 30) / 2;

            Label lblUcret = new Label();
            lblUcret.Text = "Ücret: " + ucret.ToString("C");
            lblUcret.AutoSize = true;
            lblUcret.Font = new Font("Segoe UI Semibold", 10, FontStyle.Italic);
            lblUcret.Left = pictureBox.Left + pictureBox.Width + 10;
            lblUcret.Top = lblYemekAdi.Top + lblYemekAdi.Height + 10;


            Button btnSepeteEkle = new Button();
            btnSepeteEkle.Text = "Sepete Ekle";
            btnSepeteEkle.Tag = yemekID;
            btnSepeteEkle.Width = 115;
            btnSepeteEkle.Height = 50;
            btnSepeteEkle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Italic);
            btnSepeteEkle.Click += BtnSepeteEkle_Click;
            btnSepeteEkle.Left = pictureBox.Left + pictureBox.Width + 10;
            btnSepeteEkle.Top = lblUcret.Top + lblUcret.Height + 10;

            panelYemek.Controls.Add(pictureBox);
            panelYemek.Controls.Add(lblYemekAdi);
            panelYemek.Controls.Add(lblUcret);
            panelYemek.Controls.Add(btnSepeteEkle);

            panelYemekler.AutoScroll = true;
            panelYemekler.Controls.Add(panelYemek);
        }

        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {
            Button btnSepeteEkle = (Button)sender;
            int yemekID = (int)btnSepeteEkle.Tag;

            Yemek yemek = GetYemekByID(yemekID);

            if (yemek != null)
            {
                SepeteEkle(yemek);
                MessageBox.Show("sepete eklendi");
            }
        }

        private Yemek GetYemekByID(int yemekID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT yemekAdi, ucret, foto FROM yemekTablosu WHERE yemekID = @yemekID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@yemekID", yemekID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string yemekAdi = reader.GetString(0);
                            decimal ucret = reader.GetDecimal(1);
                            byte[] fotoData = (byte[])reader.GetValue(2);

                            return new Yemek(yemekAdi, ucret, fotoData, yemekID);
                        }
                    }
                }
            }

            return null;
        }

        private void SepeteEkle(Yemek yemek)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO sepetim2 (yemekID, yemekAdi, ucret,islem, kullaniciID,foto) VALUES (@yemekID, @yemekAdi, @ucret, 1,@kullaniciID,@foto)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@yemekID", yemek.YemekID);
                    command.Parameters.AddWithValue("@yemekAdi", yemek.YemekAdi);
                    command.Parameters.AddWithValue("@ucret", yemek.Ucret);
                    command.Parameters.AddWithValue("@kullaniciID", Convert.ToInt32(kullaniciID));
                    command.Parameters.AddWithValue("@foto", yemek.FotoData);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            panelYemekler.Visible = false;
            ayarlar1.Visible = false;
            siparisler1.Visible = false;
            anasayfa1.Visible = false;
            odeme1.Visible = false;
            sepetim1.Visible = true;
            btnSiparisVer.Visible = true;
            sepetim1.LoadData();

        }

        private void sepetim1_Load(object sender, EventArgs e)
        {
            sepetim1.Refresh();
        }

        private void ayarlar1_Load(object sender, EventArgs e)
        {
            ayarlar1.Refresh();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            panelYemekler.Visible = false;
            sepetim1.Visible = false;
            btnSiparisVer.Visible = false;
            anasayfa1.Visible = false;
            odeme1.Visible = false;
            ayarlar1.Visible = true;
            siparisler1.Visible = false;

        }

        private void anaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (sepetim1.SepetBosMu())
            {
                MessageBox.Show("Sepetiniz Boş Lütfen Sepetinizi Kontrol Edin!");
                return;

            }

            panelYemekler.Visible = false;
            sepetim1.Visible = false;
            btnSiparisVer.Visible = false;
            ayarlar1.Visible = false;
            anasayfa1.Visible = false;
            odeme1.Visible = true;
            siparisler1.Visible = false;
            odeme1.yazıGetir();
        }

        public void anasayfaGetir()
        {
            odeme1.Visible = false;
            siparisler1.Visible = true;
            anasayfa1.Visible = false;
            siparisler1.siparisYukle();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            panelYemekler.Visible = false;
            sepetim1.Visible = false;
            btnSiparisVer.Visible = false;
            ayarlar1.Visible = false;
            odeme1.Visible = false;
            anasayfa1.Visible = false;
            siparisler1.Visible = true;
            siparisler1.siparisYukle();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            panelYemekler.Visible = false;
            sepetim1.Visible = false;
            btnSiparisVer.Visible = false;
            ayarlar1.Visible = false;
            odeme1.Visible = false;
            anasayfa1.Visible = true;
            siparisler1.Visible = false;
        }
    }
}
