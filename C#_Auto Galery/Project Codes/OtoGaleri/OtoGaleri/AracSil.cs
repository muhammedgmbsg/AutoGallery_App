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

    public partial class AracSil : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        public AracSil()
        {
            InitializeComponent();
        }

        private void AracSil_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkleSil eklesil = new EkleSil();
            eklesil.Show();
            this.Hide();
            
        }
       
        private void ASsil_Click(object sender, EventArgs e)
        {
            if (ASserino.Text.Equals(""))
            {
                MessageBox.Show("Seri numarası girilmedi", "Bilgi Ekranı");
            }
            else { 
             SqlConnection con = new SqlConnection(conStringh);
           con.Open();
           SqlCommand kmt = new SqlCommand("delete from OtoGaleri_arac_bilgi where serino =@p", con);
            kmt.Parameters.AddWithValue("@p", ASserino.Text);
            kmt.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Girilen seri numarasında araç mevcut ise kaldırıldı","Bilgi Ekranı");
                İşlemler islem = new İşlemler();
                islem.Show();
                this.Hide();
            }
        }

        private void ASserino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
