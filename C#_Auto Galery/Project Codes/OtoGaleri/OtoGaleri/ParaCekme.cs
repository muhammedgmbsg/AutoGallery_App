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
    public partial class ParaCekme : Form
    {

        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");

        string bakiye5;
        int tutar;
        public ParaCekme()
        {
            InitializeComponent();
        }

        private void pyparayukle_Click(object sender, EventArgs e)
        {





            if (pckartno.Text.Length == 0 || pckartsifre.Text.Length == 0 || pccvc.Text.Length == 0 || pcadsoyad.Text.Length == 0 || pctutar.Text.Length==0)
            {
                MessageBox.Show("Eksik bilgiler var tekrar deneyin.", "Bilgi Ekranı");
            }

            else { 

                if (pckartno.Text.Length == 16 && pccvc.Text.Length == 3 && pckartsifre.Text.Length == 4 && !(pcadsoyad.Text.Equals("")))
            {



                SqlConnection con = new SqlConnection(conStringh);
                con.Open();
                SqlCommand sql = new SqlCommand("select bakiye from SirketHesabı", con);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = sql;
                DataTable dt = new DataTable();
                adp.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Henüz Şirket Hesabı oluşturulmadı.", "Bilgi Ekranı");
                    }

                    else
                    {
                        String a = dt.Rows[0][0].ToString();
                        tutar = Convert.ToInt32(a);


                        if (Convert.ToInt32(pctutar.Text) <= tutar)
                        {
                            tutar -= Convert.ToInt32(pctutar.Text);

                            SqlCommand cmd = new SqlCommand("Update SirketHesabı set bakiye='" + tutar + "'", con);

                            cmd.ExecuteNonQuery();

                            con.Close();
                            string ad = pcadsoyad.Text.ToString();
                            MessageBox.Show("Paranız şirket hesabınızdan " + ad + " kişisine gönderildi.", "Bilgi Ekranı");
                            BakiyeIslem bi = new BakiyeIslem();
                            bi.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Yetersiz bakiye tekrar deneyin", "Bilgi Ekranı");
                        }




                    }
                
               


            }
            else
            {
                MessageBox.Show("Kart numarası 16, kart sifresi 4, cvc numarası 3 haneli ve ad soyad yazılı olduğundan emin olunuz.", "Bilgi Ekranı");

            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BakiyeIslem bi = new BakiyeIslem();
            bi.Show();
            this.Hide();
        }

        private void pccvc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParaCekme_Load(object sender, EventArgs e)
        {
           this.FormBorderStyle = FormBorderStyle.None;

        }

        private void pctutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pckartsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pckartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pccvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
