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
using System.Security.Cryptography.X509Certificates;

namespace OtoGaleri
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        private void boxKkullanici_TextChanged(object sender, EventArgs e)
        {

        }
       

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
            bool sonuc = true;
            

            if (sonuc)
            {
                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                String tarih = DateTime.Now.ToLongDateString();
                String mailadresin = ("scream.muhammedfethi@gmail.com");
                String sifre = ("sdcdknzzkfnkiehp");
                String smptserver = "smtp.gmail.com";
                String kime = (boxKeposta.Text.ToString());
                String konu = ("Kayıt E posta Onay Bağlantısı");
                String yaz = (tarih + " Eposta Onay Bağlantısı:" + "\n" + "Merhaba " + boxKkullanici.Text + "\nOnay kodunuz:" + onaykodu);
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


                MessageBox.Show("Girdiğiniz e posta adresiniz doğru ise onay kodu gönderildi", "Bilgi");

            }
            else
            {
                MessageBox.Show("Bilgileriniz uyuşmuyor lütfen tekrar deneyin", "Bilgi");

            }
        }
        private void buttonKkayıtol_Click(object sender, EventArgs e)
        {
            if (boxKkullanici.Text.Equals("") || boxKsifree.Text.Equals("") || boxKeposta.Text.Equals("") || boxKonayy.Text.Equals(""))
            {
                MessageBox.Show("Kayıt başarısız boş alanlar var", "Bilgi Ekranı");
            }
            else if (boxKonayy.Text != onaykodu2)
            {
                MessageBox.Show("Onay kodu eşleşmiyor tekrar deneyin", "Bilgi Ekranı");
            }
            else
            {
               

                SqlConnection con = new SqlConnection(conStringh);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into OtoGaleri_giriş_bilgi(name,password,email) values ('" + boxKkullanici.Text + "','" + boxKsifree.Text + "','" + boxKeposta.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt başarılı sisteme giriş yapabilirsiniz.", "Bilgi Ekranı");




                KullaniciGiris kullaniciGiris = new KullaniciGiris();
                kullaniciGiris.ShowDialog();
                this.Hide();


            }


        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
           this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            kullaniciGiris.Show();
            this.Hide();
        }

        private void boxKsifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
