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
    public partial class NakitSatısYap : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        string bakiye5;

        int tutar;
        public NakitSatısYap()
        {
            InitializeComponent();
        }

        private void SsatısYapnakit_Click(object sender, EventArgs e)
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

                if (Sadsoyadnakit.Text.Length == 0 || Sfiyatnakit.Text.Length == 0)
                {


                    MessageBox.Show("Eksik bilgiler var tekrar deneyin.", "Bilgi Ekranı");

                }
                else
                {

                   
                        



                            tutar += Convert.ToInt32(Sfiyatnakit.Text);

                            SqlCommand cmd = new SqlCommand("Update SirketHesabı set bakiye='" + tutar + "'", con);

                            cmd.ExecuteNonQuery();

                            con.Close();
                            string ad = Sadsoyadnakit.Text.ToString();
                            MessageBox.Show(ad + " kişisine araç satışı nakit olarak gerçekleşti.Şirket hesabı bakiyesi güncellendi ve paranız hesaba eklendi.", "Bilgi Ekranı");
                            AracSil bi = new AracSil();
                            bi.Show();
                            this.Hide();


                        
                    
                    
                }
            }


















        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracSatısYontem asy = new AracSatısYontem();
            asy.Show();
            this.Hide();
        }

        private void NakitSatısYap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void Sfiyatnakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
