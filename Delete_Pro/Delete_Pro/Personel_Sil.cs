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
    public partial class Personel_Sil : Form
    {
        public Personel_Sil()
        {
            InitializeComponent();
        }
        //DataGrid de Veri Tabanı Bilgilerini Gösterme

        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=VT_Diagram;Integrated Security=True");
        DataTable dt = new DataTable();

        //Veri tabanı Bilgileri
        void Verileri_Listele()
        {
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
        void Personel_Silme() 
        {
            try
            {
                connection.Open();

                int sil = Convert.ToInt32(lbl_ID.Text);

                //Personel Soyisim tablosundan silme işlemi için
                string personel_Sil_soyisim = "DELETE FROM Soyisim WHERE isim_Id=@isim_Id";
                SqlCommand cmd = new SqlCommand(personel_Sil_soyisim,connection);
                cmd.Parameters.AddWithValue("@isim_Id",sil);

                //Personel İsim tablosundan silme işlemi için
                string personel_Sil_isim = "DELETE FROM isim WHERE isim_Id=@isim_Id";
                SqlCommand cmd_isim = new SqlCommand(personel_Sil_isim,connection);
                cmd_isim.Parameters.AddWithValue("@isim_Id",sil);

                cmd.ExecuteNonQuery();

                Verileri_Listele();//Silme işleminden sonra DataGrid yenile

                MessageBox.Show("Silme İşlemi Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel Silme işleminde Hataa \n"+ex.Message);
                return;
            }
        }

        private void Personel_Sil_Load(object sender, EventArgs e)
        {
            Verileri_Listele();
        }

        private void btn_Personelsil_Click(object sender, EventArgs e)
        {
            try
            {
                Personel_Silme();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işleminde Hata Oluştu \n" + ex.Message);
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
            txt_isim.Text = dataGrid_Bilgiler.CurrentRow.Cells["isim"].Value.ToString();
            txt_Soyisim.Text = dataGrid_Bilgiler.CurrentRow.Cells["soyisim"].Value.ToString();
            //id ye göre işlemlerin gerçekleşmesi
            lbl_ID.Text = Convert.ToString(dataGrid_Bilgiler.CurrentRow.Cells["isim_Id"].Value);
            int isim_Id = Convert.ToInt32(lbl_ID.Text);
        }
    }
}
