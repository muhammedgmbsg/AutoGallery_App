using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoGaleri
{
    public partial class SİfreTekrar : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");

        public static string b = "select * from OtoGaleri_giriş_bilgi";


        public SİfreTekrar()
        {
            InitializeComponent();
        }

        private void sifretekrar_Click(object sender, EventArgs e)
        {
            
            

            bool sonuc = false;
            //
            SqlConnection con = new SqlConnection(conStringh);
            con.Open();
            SqlCommand cmd = new SqlCommand(b, con);
            
            


            SqlDataReader dr1 = cmd.ExecuteReader();


            while (dr1.Read())
            {

                if (dr1["name"].ToString().Trim() == boxKullaniciAdi.Text && dr1["password"].ToString().Trim() == boxSifre.Text)
                {
                    sonuc = true;


                }



            }
            if (sonuc)
            {
                BakiyeIslem bi = new BakiyeIslem();
                bi.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgiler hatalı tekrar deneyiniz.", "Bilgi Ekranı");
            }

















           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İşlemler islem = new İşlemler();
            islem.Show();
            this.Hide();
        }

        private void boxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void SİfreTekrar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }
    }
}
