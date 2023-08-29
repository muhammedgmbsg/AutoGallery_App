using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleri
{
    public partial class İşlemler : Form
    {
       
        public İşlemler()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            AracGoruntuSeri a = new AracGoruntuSeri();
            a.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SİfreTekrar st = new SİfreTekrar();
            st.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void İşlemler_Load(object sender, EventArgs e)
        {
          label1.Text = marka;
            this.FormBorderStyle = FormBorderStyle.None;



        }
        static public string marka;

        public void Hosgeldin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CıkısYap_Click(object sender, EventArgs e)
        {


            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            kullaniciGiris.ShowDialog();
            this.Hide();
            

        }

        public void buttonAracalsat_Click(object sender, EventArgs e)
        {

            AlSat alsat = new AlSat();
            alsat.Show();
            this.Hide();
        }

        private void butonaracEkle_Click(object sender, EventArgs e)
        {
            EkleSil eklesil = new EkleSil();
            eklesil.Show();
            this.Hide();
        }
    }
}
