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

namespace Delete_Pro
{
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=VT_Diagram;Integrated Security=True");
        DataTable dt = new DataTable();
        void Guncelleme_Bilgileri()
        {
            try
            {
                connection.Open();
                int isimID = Convert.ToInt32(lbl_ID.Text); // Güncelleme işlemi için ID değeri

                // Soyisim Güncelleme
                string guncelle_Soyisim = "UPDATE Soyisim SET soyisim=@soyisim WHERE isim_Id=@isim_Id";
                SqlCommand cmd = new SqlCommand(guncelle_Soyisim, connection);
                cmd.Parameters.AddWithValue("@soyisim", txt_soyisim.Text);
                cmd.Parameters.AddWithValue("@isim_Id", isimID);
                cmd.ExecuteNonQuery();

                // İsim Güncelleme
                string guncelle_isim = "UPDATE isim SET isim=@isim WHERE isim_Id=@isim_Id";
                SqlCommand cmd_isim = new SqlCommand(guncelle_isim, connection);
                cmd_isim.Parameters.AddWithValue("@isim", txt_Isim.Text);
                cmd_isim.Parameters.AddWithValue("@isim_Id", isimID);
                cmd_isim.ExecuteNonQuery();

                MessageBox.Show("Güncelleme başarılı!");
                Verileri_Listele(); // Güncel verileri tekrar yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata \n" + ex.Message);
            }
        }

        void Verileri_Listele()
        {
            //Veri Tabanından Verileri Getirme
            try
            {
                string sql = @"SELECT i.isim_Id, i.isim, s.soyisim
                       FROM isim i
                       INNER JOIN soyisim s ON i.isim_Id = s.isim_Id";

                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid_Bilgiler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: \n" + ex.Message);
            }
        }
        private void Guncelle_Load(object sender, EventArgs e)
        {
            Verileri_Listele();   
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {                
                Guncelleme_Bilgileri();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Guncelleme Esnasında bir problem oldu " + ex.Message);
                return;
            }
            finally 
            {
                connection.Close();
            }
        }

        private void dataGrid_Bilgiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGrid seçilen verilerin text 'lere aktarılması
            txt_Isim.Text = dataGrid_Bilgiler.CurrentRow.Cells["isim"].Value.ToString();
            txt_soyisim.Text = dataGrid_Bilgiler.CurrentRow.Cells["soyisim"].Value.ToString();
            //id ye göre işlemlerin gerçekleşmesi
            lbl_ID.Text = Convert.ToString(dataGrid_Bilgiler.CurrentRow.Cells["isim_Id"].Value);
            int isim_Id = Convert.ToInt32(lbl_ID.Text);
        }
    }
}
