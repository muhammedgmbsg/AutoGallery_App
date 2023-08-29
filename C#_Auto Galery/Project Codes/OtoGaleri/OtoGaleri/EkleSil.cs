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
    public partial class EkleSil : Form
    {

        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        public EkleSil()
        {
            InitializeComponent();
        }

        private void EkleSil_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonAracalsat_Click(object sender, EventArgs e)
        {
            AracBilgi aracbilgi = new AracBilgi();
            aracbilgi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            İşlemler islemler = new İşlemler();
            islemler.Show();
            this.Hide();
        }

        private void aracsil_Click(object sender, EventArgs e)
        {
            AracSil aracsil = new AracSil();
            aracsil.Show();
            this.Hide();
        }
    }
}
