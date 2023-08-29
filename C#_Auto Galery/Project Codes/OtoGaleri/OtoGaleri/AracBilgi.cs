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
    public partial class AracBilgi : Form
    {
        AracYukleme aracyukleme = new AracYukleme();
        public AracBilgi()
        {
            InitializeComponent();
        }

        private void boxKkullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adevam_Click(object sender, EventArgs e)
        {
            



            AracDegisen aracdegisen = new AracDegisen();
            aracdegisen.lbl1.Text = ABserino.Text;
            aracdegisen.lbl2.Text = ABmarka.Text;
            aracdegisen.lbl3.Text = ABmodel.Text;
            aracdegisen.lbl4.Text = ABşanzıman.Text;
            aracdegisen.lbl5.Text = ABmotorgücü.Text;
            aracdegisen.lbl6.Text = ABkilometre.Text;
            aracdegisen.lbl7.Text = ABmuayene.Text;



            aracdegisen.Show();
            this.Hide();
        }

        private void Amarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aşanzıman_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkleSil eklesil = new EkleSil();
            eklesil.Show();
            this.Hide();
        }

        private void AracBilgi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
