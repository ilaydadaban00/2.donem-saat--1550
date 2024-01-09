using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_1
{
    public partial class Form1 : Form
    {
        int sayac = 10;
        DateTime zaman2 = new DateTime(2024, 01, 9, 11, 30, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Blue;
            this.ForeColor = Color.White;
            btnBaslat.ForeColor = Color.Black;


          
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {// bu direk 0 dan baslıyor saymaya
           // sayac--;
           // label1.Text=sayac.ToString();
          //  if(sayac <= 0)
           // {
           //     timer1.Stop();
          //      this.BackColor = Color.Yellow;
         //   }
          TimeSpan fark= zaman2- DateTime.Now;
            label1.Text = fark.ToString();
           
        }
    }
}
