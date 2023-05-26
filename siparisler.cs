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
    public partial class siparisler : UserControl
    {
        private SqlConnection connection = null;
        public siparisler()
        {
            InitializeComponent();
        }

        private void siparisler_Load(object sender, EventArgs e)
        {
            siparisYukle();
            
        }

        public void siparisYukle()

        {

            anaForm anaForm = (anaForm)this.FindForm();

            int kullaniciID = Convert.ToInt32(anaForm.KullaniciID);

            try
            {
                connection = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
                connection.Open();

                string query = "SELECT tarih, yemekAdi, ucret, odemeyontemi, durum, adres FROM siparisler WHERE kullaniciID = @kullaniciID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView özelleştirmeleri
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dataTable;

                // Sütunlar
                DataGridViewTextBoxColumn tarihColumn = new DataGridViewTextBoxColumn();
                tarihColumn.DataPropertyName = "tarih";
                tarihColumn.HeaderText = "Tarih";
                tarihColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütun genişliği hücre içeriğine göre ayarlanacak
                dataGridView1.Columns.Add(tarihColumn);

                DataGridViewTextBoxColumn yemekAdiColumn = new DataGridViewTextBoxColumn();
                yemekAdiColumn.DataPropertyName = "yemekAdi";
                yemekAdiColumn.HeaderText = "Yemek Adı";
                yemekAdiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütun genişliği hücre içeriğine göre ayarlanacak
                dataGridView1.Columns.Add(yemekAdiColumn);

                DataGridViewTextBoxColumn ucretColumn = new DataGridViewTextBoxColumn();
                ucretColumn.DataPropertyName = "ucret";
                ucretColumn.HeaderText = "Ücret";
                ucretColumn.DefaultCellStyle.Format = "C2";
                ucretColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütun genişliği hücre içeriğine göre ayarlanacak
                dataGridView1.Columns.Add(ucretColumn);

                DataGridViewTextBoxColumn durumColumn = new DataGridViewTextBoxColumn();
                durumColumn.DataPropertyName = "durum";
                durumColumn.HeaderText = "Durum";
                durumColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütun genişliği hücre içeriğine göre ayarlanacak
                dataGridView1.Columns.Add(durumColumn);

                DataGridViewTextBoxColumn odemeYontemiColumn = new DataGridViewTextBoxColumn();
                odemeYontemiColumn.DataPropertyName = "odemeyontemi";
                odemeYontemiColumn.HeaderText = "Ödeme Yöntemi";
                odemeYontemiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütun genişliği hücre içeriğine göre ayarlanacak
                dataGridView1.Columns.Add(odemeYontemiColumn);

                

                DataGridViewTextBoxColumn adresColumn = new DataGridViewTextBoxColumn();
                adresColumn.DataPropertyName = "adres";
                adresColumn.HeaderText = "Adres";
                adresColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütun genişliği kalan boş alana yayılacak
                dataGridView1.Columns.Add(adresColumn);
                dataTable.DefaultView.Sort = "tarih DESC";
                dataGridView1.DataSource = dataTable.DefaultView;

                // DataGridView stil özelleştirmeleri
                dataGridView1.BackgroundColor = Color.FromArgb(237, 237, 233); // #E3D5CA
                dataGridView1.BorderStyle = BorderStyle.Fixed3D;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                // DataGridView hücre stil özelleştirmeleri
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = Color.FromArgb(227, 213, 202); // #EDEDE9
                cellStyle.ForeColor = Color.FromArgb(51, 51, 51); // Siyah renk
                cellStyle.SelectionBackColor = Color.FromArgb(186, 160, 143); // Koyu kahverengi renk
                cellStyle.SelectionForeColor = Color.White;
                cellStyle.WrapMode = DataGridViewTriState.True;

                dataGridView1.DefaultCellStyle = cellStyle;
                

                // DataGridView başlık stil özelleştirmeleri
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.BackColor = Color.FromArgb(237, 237, 233); // #EDEDE9
                headerStyle.ForeColor = Color.FromArgb(51, 51, 51); // Siyah renk
                headerStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;

                // Satır yükseklik ayarları
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dataGridView1.RowTemplate.Height = 70;

                                // Tüm satırları görüntüle
                dataGridView1.ScrollBars = ScrollBars.Both; // Hem yatay hem de dikey kaydırma çubukları
                dataGridView1.AllowUserToResizeRows = false;

                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: siparide " + ex.ToString());
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
