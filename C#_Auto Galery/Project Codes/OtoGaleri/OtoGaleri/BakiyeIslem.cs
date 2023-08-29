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
    public partial class BakiyeIslem : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");

        // ŞİRKET BAKİYESİ---------------  
        public static int bakiye = 0;
        public static int bakiyem { get { return bakiye; } set { bakiye = value; } } 
        //-------------------------------
        public BakiyeIslem()
        {
            InitializeComponent();
        }

        private void sirkethesapolustur_Click(object sender, EventArgs e)
        {
            shcvc sh = new shcvc();
            sh.Show();
            this.Hide();
        }

        private void parayukle_Click(object sender, EventArgs e)
        {
            ParaYukleme py = new ParaYukleme();
            py.Show();
            this.Hide();
        }

        private void bakiyekontrol_Click(object sender, EventArgs e)
        {
            BakiyeKontrol bk = new BakiyeKontrol();
          


            

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


                bk.bkbakiye.Text = a;
                bk.bkparabirimi.Text = "TL";





                //  BakiyeKontrol bk = new BakiyeKontrol();
                bk.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İşlemler İSLEM = new İşlemler();
            İSLEM.Show();
            this.Hide();
        }

        private void paracek_Click(object sender, EventArgs e)
        {
            ParaCekme pc = new ParaCekme();
            pc.Show();
            this.Hide();
        }

        private void BakiyeIslem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void sirkethesapgüncelle_Click(object sender, EventArgs e)
        {
            SirketHesapGuncelle shg = new SirketHesapGuncelle();
            shg.Show();
            this.Hide();
        }
    }
}
