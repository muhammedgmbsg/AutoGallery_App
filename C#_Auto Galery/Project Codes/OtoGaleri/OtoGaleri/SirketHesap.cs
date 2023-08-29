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
    public partial class shcvc : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        public static int deger = 0;
        public shcvc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BakiyeIslem bi = new BakiyeIslem();
            bi.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void shkartno_TextChanged(object sender, EventArgs e)
        {

        }

        private void shcvc_Load(object sender, EventArgs e)
        {
           this.FormBorderStyle = FormBorderStyle.None;

        }

        private void shdevamet_Click(object sender, EventArgs e)
        {
            if (shkartno.Text.Length == 0 || shkartsifre.Text.Length == 0 || shkartcvc.Text.Length == 0 || shadsoyad.Text.Length == 0)
            {
                MessageBox.Show("Eksik bilgiler var tekrar deneyin.", "Bilgi Ekranı");
            }
            else
            {

                if (shkartno.Text.Length == 16 && shkartcvc.Text.Length == 3 && shkartsifre.Text.Length == 4 && !(shadsoyad.Text.Equals("")))
                {
                    SqlConnection con = new SqlConnection(conStringh);

                    con.Open();
                    SqlCommand sqlcntrl = new SqlCommand("Select * from SirketHesabı", con);
                    DataTable dt = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = sqlcntrl;
                    dataAdapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into SirketHesabı(adısoyadı,kartnumarası,kartsifresi,kartcvc,bakiye) values ('" + shadsoyad.Text + "','" + shkartno.Text + "','" + Convert.ToInt32(shkartsifre.Text) + "','" + Convert.ToInt32(shkartcvc.Text) + "','" + deger + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Şirket Hesabı oluşturuldu.Kart bilgilerinizle işlem yapabilirsiniz.", "Bilgi Ekranı");
                        BakiyeIslem b = new BakiyeIslem();
                        b.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Birden fazla şirket hesabı oluşturulamaz");
                    }
                }


                else
                {
                    MessageBox.Show("Kart numarası 16, kart sifresi 4, cvc numarası 3 haneli ve ad soyad yazılı olduğundan emin olunuz.", "Bilgi Ekranı");

                }
            }
        }

        private void shadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void shkartsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void shkartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void shkartsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void shkartcvc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
