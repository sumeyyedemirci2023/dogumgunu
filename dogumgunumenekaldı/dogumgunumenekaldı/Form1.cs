using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogumgunumenekaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            DateTime dogumGunu = new DateTime(2024,8,26);
            label1.Text = "Bugün: " + bugun.ToString();
            TimeSpan tarihFark = dogumGunu - bugun;
            label3.Text = "Gün Farkı: " + tarihFark.Days.ToString();
            label4.Text = "Saat Farkı: " + tarihFark.Hours.ToString();
            label5.Text = "Dakika Farkı: " + tarihFark.Minutes.ToString();
            label6.Text = "Saniye Farkı: " + tarihFark.Seconds.ToString();
            label7.Text = "MiliSaniye Farkı: " + tarihFark.Milliseconds.ToString();
        }
    }
}
