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
    public partial class AracGoruntuSeri : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        public static string b = "select * from OtoGaleri_arac_bilgi where serino=@p";
        public AracGoruntuSeri()
        {
            InitializeComponent();
        }

        private void AracGoruntuSeri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void AGSaracgoster_Click(object sender, EventArgs e)
        {
            AracGoruntuleme arc = new AracGoruntuleme();

            SqlConnection con = new SqlConnection(conStringh);
            con.Open();
            SqlCommand cmd = new SqlCommand(b, con);
            cmd.Parameters.AddWithValue("@p",AGSserino.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            bool sonuc = false;
            while (dr.Read())
            {
                if (dr["serino"].ToString().Trim() == AGSserino.Text)
                {
                    sonuc = true;
                    arc.lblmarka.Text = dr["marka"].ToString();
                    arc.lblmodel.Text = dr["model"].ToString();
                    arc.lblşanzıman.Text = dr["şanzıman"].ToString();
                    arc.lblmotorgücü.Text = dr["motorgücü"].ToString();
                    arc.lblkm.Text = dr["kilometre"].ToString();
                    arc.lblkapı.Text = dr["kapılar"].ToString();
                    arc.lblkaput.Text = dr["kaput"].ToString();
                    arc.lbltavan.Text = dr["tavan"].ToString();
                    arc.lblbagaj.Text = dr["bagajkapağı"].ToString();
                    arc.lbltampon.Text = dr["tamponlar"].ToString();
                    arc.lblşase.Text = dr["şase"].ToString();
                    arc.lblmotor.Text = dr["motor"].ToString();
                    arc.lblmuayene.Text = dr["muayenetarihi"].ToString();
                    arc.lblacıklama.Text = dr["acıklama"].ToString();
                    arc.pictureBox1.ImageLocation = dr["aracresim"].ToString();

                }

               




            }

            if (sonuc)
            {
                arc.Show();
                this.Hide();


            }
            else if (AGSserino.Text.Equals(""))
            {
                MessageBox.Show("Girilen seri numarasında araç bulunamadı tekrar deneyin","Bilgi Ekranı");
            }
            else
            {
                MessageBox.Show("Girilen seri numarasında araç bulunamadı tekrar deneyin","Bilgi Ekranı");

            }



        }

        private void AGSserino_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            İşlemler işlem = new İşlemler();
            işlem.Show();
            this.Hide();
        }
    }
}
