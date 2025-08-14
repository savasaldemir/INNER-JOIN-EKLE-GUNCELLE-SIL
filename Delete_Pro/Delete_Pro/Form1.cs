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
    public partial class Try : Form
    {
        public Try()
        {
            InitializeComponent();
        }
        //DataGrid de Veri Tabanı Bilgilerini Gösterme

        SqlConnection connection=new SqlConnection(@"Data Source=.;Initial Catalog=VT_Diagram;Integrated Security=True");
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
                dataGrid_Goster.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: \n" + ex.Message);
            }
        }

        private void Try_Load(object sender, EventArgs e)
        {

        }

        private void btn_Verileri_Goster_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                Verileri_Listele();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hataa Yüklemede Problem Oluştu \n" + ex);
            }
            finally 
            {
               connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekleme_işlemleri ekle = new Ekleme_işlemleri();
            ekle.ShowDialog();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.ShowDialog();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Personel_Sil personel_Sil = new Personel_Sil();
            personel_Sil.ShowDialog();
        }
    }
}
