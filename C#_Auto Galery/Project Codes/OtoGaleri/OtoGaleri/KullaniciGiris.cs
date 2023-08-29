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
    public partial class KullaniciGiris : Form 

    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");

        public static string b = "select * from OtoGaleri_giriş_bilgi";

       



        void Vtbaglanti()
        {
            


        }

        public KullaniciGiris()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            /* if (this.panel1.Controls.Count > 0)
                 this.panel1.Controls.RemoveAt(0);
             Form f = Form as Form;
             f.TopLevel = false;
             f.Dock = DockStyle.Fill;
             this.panel1.Controls.Add(f);
             this.panel1.Tag = f;
             f.Show(); */
        
        }
    /*    void formislem()
        {
            KullaniciKayit ik = new KullaniciKayit();
            ik.TopLevel = false;
            ik.Dock = DockStyle.Fill;
            ik.Show();
            this.Controls.Add(ik);

        }*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        public void button1_Click(object sender, EventArgs e)
        {
             
            

        bool sonuc = false;
            //
            SqlConnection con = new SqlConnection(conStringh);
            con.Open();
            SqlCommand cmd = new SqlCommand(b, con);
           
            
           
           SqlDataReader dr1 = cmd.ExecuteReader();
            
          
            while (dr1.Read())
            {

                if (dr1["name"].ToString().Trim()==boxKullaniciAdi.Text && dr1["password"].ToString().Trim() == boxSifre.Text && dr1["email"].ToString().Trim()==boxEposta.Text)
                {
                    sonuc = true;
              
                   
                }

                

            }
            if (sonuc)
            {

              
                İşlemler işlemler = new İşlemler();
                İşlemler.marka = boxKullaniciAdi.Text;
                işlemler.Show();
                this.Hide();    //Belirtilen form aynı sekme içerisinde açılır.

            }
            else
            {
                MessageBox.Show("Bilgileriniz hatalı tekrar deneyiniz.", "Bilgi Ekranı");
            }




        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           KayitOl kayit = new KayitOl();
         
            kayit.Show();
            Hide();

            //Belirtilen form aynı sekme içerisinde açılır.*/
            
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreYenile yenile = new SifreYenile();
            yenile.Show();
            this.Hide(); //Belirtilen form aynı sekme içerisinde açılır.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cıkıs_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
