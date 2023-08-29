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
    public partial class SirketHesapGuncelle : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        public SirketHesapGuncelle()
        {
            InitializeComponent();
        }
          // asıl proje
        private void shgdevamet_Click(object sender, EventArgs e)
        {
            if (shgkartno.Text.Length == 0 || shgkartsifre.Text.Length == 0 || shgkartcvc.Text.Length == 0 || shgadsoyad.Text.Length == 0)
            {
                MessageBox.Show("Eksik bilgiler var tekrar deneyin.", "Bilgi Ekranı");
            }

            else {
                if (shgkartno.Text.Length == 16 && shgkartcvc.Text.Length == 3 && shgkartsifre.Text.Length == 4 && !(shgadsoyad.Text.Equals("")))
                {
                    string sshgsifre = shgkartsifre.Text.ToString(); int shgsifre = Convert.ToInt32(sshgsifre);
                    string sshgcvc = shgkartcvc.Text.ToString(); int shgcvc = Convert.ToInt32(sshgcvc);

                    SqlConnection con = new SqlConnection(conStringh);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Update SirketHesabı set adısoyadı='" + shgadsoyad.Text + "',kartnumarası='" + shgkartno.Text + "',kartsifresi='" + shgsifre + "',kartcvc='" + shgcvc + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Var olan bir şirket hesabınız var ise şirket hesabı bilgileriniz güncellendi.", "Bilgi Ekranı");


                }
                else
                {
                    MessageBox.Show("Kart numarası 16, kart sifresi 4, cvc numarası 3 haneli ve ad soyad yazılı olduğundan emin olunuz.", "Bilgi Ekranı");
                }
            }
        }

        private void SirketHesapGuncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BakiyeIslem bi = new BakiyeIslem();
            bi.Show();
            this.Hide();
        }

        private void shgkartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void shgkartsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void shgkartcvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
