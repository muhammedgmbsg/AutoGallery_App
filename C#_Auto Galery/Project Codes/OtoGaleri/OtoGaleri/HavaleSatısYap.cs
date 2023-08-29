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
    public partial class HavaleSatısYap : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        string bakiye5;
        
        int tutar;
        public HavaleSatısYap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracSatısYontem asy = new AracSatısYontem();
            asy.Show();
            this.Hide();
        }

        private void Ssatısyap_Click(object sender, EventArgs e)
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

                if (Skartno.Text.Length == 0 || Skartsifre.Text.Length==0 || Scvc.Text.Length==0 || Sfiyat.Text.Length == 0 || Sadsoyad.Text.Length == 0)
                {


                    MessageBox.Show("Eksik bilgiler var tekrar deneyin.", "Bilgi Ekranı");

                }
                else
                {



                     {
                            

                                tutar += Convert.ToInt32(Sfiyat.Text);

                                SqlCommand cmd = new SqlCommand("Update SirketHesabı set bakiye='" + tutar + "'", con);

                                cmd.ExecuteNonQuery();

                                con.Close();
                                string ad = Sadsoyad.Text.ToString();
                        MessageBox.Show(ad + " kişisine araç satışı gerçekleşti,ücret şirket hesabınıza yatırıldı.", "Bilgi Ekranı");
                        AracSil bi = new AracSil();
                                bi.Show();
                                this.Hide();
                            
                           
                        }
                    
                   
                }
            }















        }

        private void HavaleSatısYap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Sfiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Skartsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Scvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Skartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
