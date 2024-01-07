using AkinNTPOdev.BLL;
using AkinNTPOdev.OdevModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkinNTPOdev
{
    public partial class frmOgrenciAra : Form
    {
        public frmOgrenciAra()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL ogrBL = new OgrenciBL();
                string numara = txtOgrNo.Text.Trim();
                Ogrenci ogr = ogrBL.OgrenciBul(numara);

                if (ogr != null)
                {
                    // Bulunan öğrenci bilgilerini form üzerinde göster
                    MessageBox.Show($"Ad: {ogr.Ad}\nSoyad: {ogr.Soyad}\nNumara: {ogr.Numara}");
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}