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

    public partial class odeme : UserControl
    {
        private SqlConnection connection = null;


        public odeme()
        {
            InitializeComponent();

        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {

            SiparisVer();
            anaForm anaform = (anaForm)FindForm();
            anaform.anasayfaGetir();
             
        }

        private void SiparisVer()
        {
            // Kullanıcı bilgilerini al
            string adSoyad = txtAdSoyad.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;
            string odemeYontemi = "";
            

            if (radioNakit.Checked)
            {
                odemeYontemi = "Nakit";
            }
            else if (radioPos.Checked)
            {
                odemeYontemi = "Pos";
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçin.");
                return;
            }

            try
            {
                if( string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(adres))
                {
                    MessageBox.Show("Lütfen Gerekli Alanların Hepsini Doldurunuz!");
                    return;
                }
                connection = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
                connection.Open();

                SqlCommand sepetCommand = new SqlCommand("SELECT * FROM sepetim2 WHERE kullaniciID = @kullaniciID", connection);
                anaForm anaForm = (anaForm)this.FindForm();

                int kullaniciID = Convert.ToInt32(anaForm.KullaniciID);
                sepetCommand.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                SqlDataReader sepetReader = sepetCommand.ExecuteReader();

                List<int> yemekIDListesi = new List<int>();
                List<string> yemekAdiListesi = new List<string>();
                decimal toplamUcret = 0;

                while (sepetReader.Read())
                {
                    int yemekID = Convert.ToInt32(sepetReader["yemekID"]);
                    string yemekAdi = sepetReader["yemekAdi"].ToString();
                    decimal ucret = Convert.ToDecimal(sepetReader["ucret"]);

                    yemekIDListesi.Add(yemekID);
                    yemekAdiListesi.Add(yemekAdi);
                    toplamUcret += ucret;
                }

                sepetReader.Close();

                if (yemekIDListesi.Count > 0)
                {
                    string yemekIDConcatenated = string.Join(",", yemekIDListesi);
                    string yemekAdiConcatenated = string.Join(", ", yemekAdiListesi);

                    string query = "INSERT INTO siparisler (kullaniciID, yemekID, yemekAdi, ucret, durum, odemeyontemi, adsoyad, adres, telefon, tarih) " +
                                    "VALUES (@kullaniciID, @yemekID, @yemekAdi, @ucret, @durum, @odemeyontemi, @adsoyad, @adres, @telefon, @tarih)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                    command.Parameters.AddWithValue("@yemekID", yemekIDConcatenated);
                    command.Parameters.AddWithValue("@yemekAdi", yemekAdiConcatenated);
                    command.Parameters.AddWithValue("@ucret", toplamUcret);
                    command.Parameters.AddWithValue("@durum", "Sipariş Alındı");
                    command.Parameters.AddWithValue("@odemeyontemi", odemeYontemi);
                    command.Parameters.AddWithValue("@adsoyad", adSoyad);
                    command.Parameters.AddWithValue("@adres", adres);
                    command.Parameters.AddWithValue("@telefon", telefon);
                    command.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Siparişiniz başarıyla verildi.");

                    SqlCommand sepetTemizleCommand = new SqlCommand("DELETE FROM sepetim2 WHERE kullaniciID = @kullaniciID", connection);
                    sepetTemizleCommand.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                    sepetTemizleCommand.ExecuteNonQuery();

                    // Yemeklerin ve toplam ücretin label'lara yazılması
                   // lblYemekler.Text = yemekAdiConcatenated;
                    //lblUcret.Text = toplamUcret.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: surada " + ex.ToString());
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void odeme_Load(object sender, EventArgs e)
        {
            yazıGetir();
        }


        public  void yazıGetir()
        {
            anaForm anaForm = (anaForm)this.TopLevelControl;
            int kullaniciID = Convert.ToInt32(anaForm.KullaniciID);
            // Sepetteki yemekleri ve toplam fiyatı label'lara yazdır
            try
            {
                connection = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
                connection.Open();

                SqlCommand sepetCommand = new SqlCommand("SELECT yemekAdi, ucret FROM sepetim2 WHERE kullaniciID = @kullaniciID", connection);

                

                sepetCommand.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                SqlDataReader sepetReader = sepetCommand.ExecuteReader();

                List<string> yemekAdiListesi = new List<string>();
                decimal toplamUcret = 0;

                while (sepetReader.Read())
                {
                    string yemekAdi = sepetReader["yemekAdi"].ToString();
                    decimal ucret = Convert.ToDecimal(sepetReader["ucret"]);

                    yemekAdiListesi.Add(yemekAdi);
                    toplamUcret += ucret;
                }

                sepetReader.Close();

                if (yemekAdiListesi.Count > 0)
                {
                    string yemekAdiConcatenated = string.Join(", ", yemekAdiListesi);

                    lblYemekler.Text = "Sipariş İçeriği : " + yemekAdiConcatenated;
                    lblUcret.Text = "Toplam Ücret : " + toplamUcret.ToString("C2");
                }
                else
                {
                    lblYemekler.Text = "";
                    lblUcret.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: burada " + ex.ToString());
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
