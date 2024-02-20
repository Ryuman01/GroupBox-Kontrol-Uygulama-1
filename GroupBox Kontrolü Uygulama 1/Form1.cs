using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_Kontrolü_Uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double tabanFiyat = 500;
            double cpuFiyat = 0;
            if (rbCpuI7.Checked)
                cpuFiyat = 300;
            else if (rbCpuI5.Checked)
                cpuFiyat = 200;
            else if (rbCpuI3.Checked)
                cpuFiyat = 100;
            else if (rbCpuR5.Checked)
                cpuFiyat = 250;
            else if (rbCpuR3.Checked)
                cpuFiyat = 150;
            tabanFiyat += cpuFiyat;
          //-----------------------------
            double ramFiyat = 0;
            if (rbRam16.Checked)
                ramFiyat = 125;
            else if (rbRam8.Checked)
                ramFiyat = 75;
            else if (rbRam4.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;
          //-----------------------------
            double ssdFiyat = 0;
            if (rbHdd1000.Checked)
                ssdFiyat = 1000;
            else if (rbHdd500.Checked)
                ssdFiyat = 500;
            else if (rbHdd320.Checked)
                ssdFiyat = 320;
            tabanFiyat += ssdFiyat;
            //-----------------------------
            double ekdonanim = 0;
            if (CbDVD.Checked)
                ekdonanim += 350;
            if (CbWebcam.Checked)
                ekdonanim += 600;
            if (CbWifi.Checked)
                ekdonanim += 450;
            tabanFiyat += ekdonanim;
            MessageBox.Show(string.Format("Toplam Fiyat ={0:C}", tabanFiyat));
        }
    }
    
}

