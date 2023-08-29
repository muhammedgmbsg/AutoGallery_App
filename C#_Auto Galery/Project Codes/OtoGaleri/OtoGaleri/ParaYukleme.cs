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
    public partial class ParaYukleme : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");

        string bakiye5;
        int tutar;




        public ParaYukleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BakiyeIslem bi = new BakiyeIslem();
            bi.Show();
            this.Hide();
        }

        private void pyadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void pycvc_TextChanged(object sender, EventArgs e)
        {

        }

        private void pyparayukle_Click(object sender, EventArgs e)
        {



            if (pykartno.Text.Length == 0 || pykartsifre.Text.Length == 0 || pycvc.Text.Length == 0 || pyadsoyad.Text.Length == 0 || pytutar.Text.Length == 0)
            {
                MessageBox.Show("Eksik bilgiler var tekrar deneyin.", "Bilgi Ekranı");
            }

            else
            {

                if (pykartno.Text.Length == 16 && pycvc.Text.Length == 3 && pykartsifre.Text.Length == 4 && !(pyadsoyad.Text.Equals("")))
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


                       
                            tutar += Convert.ToInt32(pytutar.Text);

                            SqlCommand cmd = new SqlCommand("Update SirketHesabı set bakiye='" + tutar + "'", con);

                            cmd.ExecuteNonQuery();

                            con.Close();
                            string ad = pyadsoyad.Text.ToString();
                        MessageBox.Show(ad + " kişisinden şirket hesabına para yüklendi.", "Bilgi Ekranı");


                        BakiyeIslem bi = new BakiyeIslem();
                            bi.Show();
                            this.Hide();

                        
                        



                    }




                }
                else
                {
                    MessageBox.Show("Kart numarası 16, kart sifresi 4, cvc numarası 3 haneli ve ad soyad yazılı olduğundan emin olunuz.", "Bilgi Ekranı");

                }
            }


        }

        private void ParaYukleme_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void pytutar_TextChanged(object sender, EventArgs e)
        {


        }

        private void pycvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pykartsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pykartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pycvc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pytutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pyadsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
