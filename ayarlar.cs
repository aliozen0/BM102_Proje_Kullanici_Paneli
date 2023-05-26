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
    public partial class ayarlar : UserControl
    {
        private SqlConnection connection = null;
        public ayarlar()
        {
            InitializeComponent();
        }

        private void buttonEpostaDegistir_Click(object sender, EventArgs e)
        {
            string yeniEposta = textBoxYeniEposta.Text;

            // E-posta değiştirme işlemleri
            try
            {

                if (string.IsNullOrEmpty(yeniEposta) )
                {
                    MessageBox.Show("E-Posta Boş Olamaz! Lütfen E-Posta Giriniz.");
                    return;
                }
                // Veritabanına bağlantıyı aç
                string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı ID'yi al
                    anaForm anaForm = (anaForm)this.FindForm();

                    int kullaniciID = Convert.ToInt32(anaForm.KullaniciID);

                    // E-postayı güncelle
                    string query = "UPDATE kullanicilar SET mail = @yeniEposta WHERE kullaniciID = @kullaniciID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@yeniEposta", yeniEposta);
                        command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        command.ExecuteNonQuery();
                    }
                    textBoxYeniEposta.Clear();
                    MessageBox.Show("E-posta başarıyla değiştirildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }
        }
    

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {

            string yeniSifre = textBoxYeniSifre.Text;
            string yeniSifreTekrar = textBoxYeniSifreTekrar.Text;

            // Şifre değiştirme işlemleri
            try
            {
                if (string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(yeniSifreTekrar))
                {
                    MessageBox.Show("Şifre Boş Olamaz ! Lütfen Şifrenizi Giriniz.");
                    return;
                }
                if (yeniSifre != yeniSifreTekrar)
                {
                    MessageBox.Show("Yeni şifreler eşleşmiyor.");
                    return;
                }

                // Veritabanına bağlantıyı aç
                string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı ID'yi al
                    anaForm anaForm = (anaForm)this.FindForm();

                    int kullaniciID = Convert.ToInt32(anaForm.KullaniciID);

                    // Şifreyi güncelle
                    string query = "UPDATE kullanicilar SET sifre = @yeniSifre WHERE kullaniciID = @kullaniciID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                        command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        command.ExecuteNonQuery();
                    }
                    textBoxYeniSifre.Clear();
                    textBoxYeniSifreTekrar.Clear();
                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();   
            frmGiris.Show();
            this.FindForm().Hide();

        }
    }
}
