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
    public partial class AracDegisen : Form
    {

        AracYukleme aracyükleme = new AracYukleme();
        AracBilgi aracbilgi = new AracBilgi();


        public AracDegisen()
        {
            InitializeComponent();
        }
       
        private void Adevam_Click(object sender, EventArgs e)
        {
            AracYukleme aracyukleme = new AracYukleme();
            aracyukleme.lbl15.Text = lbl1.Text;
            aracyukleme.lbl16.Text = lbl2.Text;
            aracyukleme.lbl17.Text = lbl3.Text;
            aracyukleme.lbl18.Text = lbl4.Text;
            aracyukleme.lbl19.Text = lbl5.Text;
            aracyukleme.lbl20.Text = lbl6.Text;
            aracyukleme.lbl21.Text = lbl7.Text;

            aracyukleme.lbl8.Text = ADkapı.Text;
            aracyukleme.lbl9.Text = ADkaput.Text;
            aracyukleme.lbl10.Text = ADtavan.Text;
            aracyukleme.lbl11.Text = ADbagajkapısı.Text;
            aracyukleme.lbl12.Text = ADtamponlar.Text;
            aracyukleme.lbl13.Text = ADşase.Text;
            aracyukleme.lbl14.Text = ADmotor.Text;



            aracyukleme.Show();
           this.Hide();
        }

        private void AracDegisen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracBilgi aracbilgi = new AracBilgi();
            aracbilgi.Show();
            this.Hide();
        }

        private void ADtavan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
