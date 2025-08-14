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
    public partial class Ekleme_işlemleri : Form
    {
        public Ekleme_işlemleri()
        {
            InitializeComponent();
        }
        //İki Farklı Veri Tabanında Kayıt İşlemleri

        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=VT_Diagram;Integrated Security=True");

        void Verileri_Ekle()
        {
            try
            {
                connection.Open();

                // soyisim ekle, ID'sini al
                string ekleSoyisim = @"INSERT INTO Soyisim(soyisim) VALUES(@soyisim); 
                               SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(ekleSoyisim, connection);
                cmd.Parameters.AddWithValue("@soyisim", txt_Soyisim.Text);

                int isim_Id = Convert.ToInt32(cmd.ExecuteScalar());

                // isim ekle
                string ekleIsim = "INSERT INTO isim(isim, isim_Id) VALUES(@isim, @isim_Id)";
                SqlCommand cmdIsim = new SqlCommand(ekleIsim, connection);
                cmdIsim.Parameters.AddWithValue("@isim", txt_isim.Text);
                cmdIsim.Parameters.AddWithValue("@isim_Id", isim_Id);

                cmdIsim.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: \n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txt_isim.Text == "" || txt_Soyisim.Text == "")
                {
                    MessageBox.Show("Textler Boş Bırakılamaz");
                    return;
                }
                Verileri_Ekle();               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hataa Ekleme Esnasında Bir Problem Oluştu " + ex.Message);
                return;
            }
            finally 
            {
                connection.Close();
            }
        }
    }
}
