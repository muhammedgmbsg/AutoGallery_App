using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleri
{
    public partial class SifreYenile : Form
    {
        public SifreYenile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            kullaniciGiris.Show();
            this.Hide();
        }
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");

        public static string b = "select * from OtoGaleri_giriş_bilgi";
        public static string onaykodu2;
        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random random = new Random();
            string onaykodu;
            onaykodu = random.Next(10000, 100000).ToString();
            onaykodu2 = onaykodu;
            SqlConnection con = new SqlConnection(conStringh);
            con.Open();


            SqlCommand cmd = new SqlCommand(b, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool sonuc = false;
            while (dr.Read())
            {
                if (dr["name"].ToString().Trim() == boxSkullanici.Text && dr["email"].ToString().Trim() == boxSeposta.Text)
                {
                    sonuc = true;
                    break;
                }
            }
            if (sonuc)
            {
                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                String tarih = DateTime.Now.ToLongDateString();
                String mailadresin = ("scream.muhammedfethi@gmail.com");
                String sifre = ("sdcdknzzkfnkiehp");
                String smptserver = "smtp.gmail.com";
                String kime = (dr["email"].ToString());
                String konu = ("Şifre Yenileme Bağlantısı");
                String yaz = (tarih + " Şifre Yenileme Bağlantısı:" + "\n" + "Merhaba " + dr["name"] + "\nOnay kodunuz:" + onaykodu);
                smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                smtpserver.Port = 587;
                smtpserver.Host = smptserver;
                smtpserver.EnableSsl = true;
                mail.From = new MailAddress(mailadresin);
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.Body = yaz;
                smtpserver.Send(mail);
                DialogResult bilgi = new DialogResult();


                MessageBox.Show("Onay kodu e posta adresinize gönderildi", "Bilgi");

            }
            else
            {
                MessageBox.Show("Bilgileriniz uyuşmuyor lütfen tekrar deneyin", "Bilgi");

            }

        }

        private void buttonSsifreYenile_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStringh);
            con.Open();


            SqlCommand cmd = new SqlCommand(b, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool sonuc = false;
            while (dr.Read())
            {
                if (dr["name"].ToString().Trim() == boxSkullanici.Text && dr["email"].ToString().Trim() == boxSeposta.Text)
                {
                    sonuc = true;
                    con.Close();
                    break;
                }
            }
            if (sonuc)
            {

                if (boxSonaykod.Text == onaykodu2)
                {
                    SqlConnection cone = new SqlConnection(conStringh);
                    cone.Open();
                    cmd = new SqlCommand();
                    ;
                    cmd.Connection = cone;
                    cmd.CommandText = "update OtoGaleri_giriş_bilgi set password='" + boxSyeniSifre.Text + "'";
                    cmd.ExecuteNonQuery();
                    cone.Close();

                    MessageBox.Show("Şifre yenileme başarılı,yeni şifreniz ile sisteme giriş yapabilirsiniz.", "Bilgi Ekranı");
                    KullaniciGiris kullaniciGiris = new KullaniciGiris();
                    kullaniciGiris.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre yenilenemedi bilgiler eşleşmedi lütfen tekrar deneyin", "Bilgi Ekranı");
                }
            }
            else
            {
                MessageBox.Show("Şifre yenilenemedi bilgiler eşleşmedi lütfen tekrar deneyin", "Bilgi Ekranı");
            }
        }

        private void SifreYenile_Load(object sender, EventArgs e)
        {
           this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
