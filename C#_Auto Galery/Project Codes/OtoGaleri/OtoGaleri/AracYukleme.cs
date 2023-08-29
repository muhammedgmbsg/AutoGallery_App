using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OtoGaleri
{
    public partial class AracYukleme : Form
    {

        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");

        public AracYukleme()
        {
            InitializeComponent();
        }

        private void ADtavan_TextChanged(object sender, EventArgs e)
        {

        }

        private void AYucnokta_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            AYresimyolu.Text = openFileDialog1.FileName;
        }

        private void AracYukleme_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
            AracDegisen aracdegisenn = new AracDegisen();
            aracdegisenn.Show();
            this.Hide();
        }

        private void AYaracıekle_Click(object sender, EventArgs e)
        {

            if (lbl15.Text.Equals("") || lbl16.Text.Equals("") || lbl17.Text.Equals("") || lbl18.Text.Equals("") || lbl19.Text.Equals("") || lbl20.Text.Equals("") || lbl21.Text.Equals("") || lbl8.Text.Equals("") ||
                lbl9.Text.Equals("") || lbl10.Text.Equals("") || lbl11.Text.Equals("") || lbl12.Text.Equals("") || lbl13.Text.Equals("") ||lbl14.Text.Equals("")  || AYacıklama.Text.Equals("") ||
                AYresimyolu.Text.Equals(""))
            {
                MessageBox.Show("Lütfen boş alanları doldurun", "Bilgi Ekranı");
            }
            else
            {

                SqlConnection con = new SqlConnection(conStringh);

                con.Open();
                SqlCommand kmt = new SqlCommand("insert into OtoGaleri_arac_bilgi (serino,marka,model,şanzıman,motorgücü,kilometre,muayenetarihi,kapılar,kaput,tavan,bagajkapağı,tamponlar,şase,motor,acıklama,aracresim) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16)", con);
                kmt.Parameters.AddWithValue("@p1", lbl15.Text.Trim());
                kmt.Parameters.AddWithValue("@p2", lbl16.Text.Trim());
                kmt.Parameters.AddWithValue("@p3", lbl17.Text.Trim());
                kmt.Parameters.AddWithValue("@p4", lbl18.Text.Trim());
                kmt.Parameters.AddWithValue("@p5", lbl19.Text.Trim());
                kmt.Parameters.AddWithValue("@p6", lbl20.Text.Trim());
                kmt.Parameters.AddWithValue("@p7", lbl21.Text.Trim());
                kmt.Parameters.AddWithValue("@p8", lbl8.Text.Trim());
                kmt.Parameters.AddWithValue("@p9", lbl9.Text.Trim());
                kmt.Parameters.AddWithValue("@p10", lbl10.Text.Trim());
                kmt.Parameters.AddWithValue("@p11", lbl11.Text.Trim());
                kmt.Parameters.AddWithValue("@p12", lbl12.Text.Trim());
                kmt.Parameters.AddWithValue("@p13", lbl13.Text.Trim());
                kmt.Parameters.AddWithValue("@p14", lbl14.Text.Trim());
                kmt.Parameters.AddWithValue("@p15", AYacıklama.Text.Trim());
                kmt.Parameters.AddWithValue("@p16", AYresimyolu.Text.Trim());
                kmt.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Araç Eklendi", "Bilgi Ekranı");

                İşlemler işlem = new İşlemler();
                işlem.Show();
                this.Hide();
            }

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
       
        private void AYacıklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
