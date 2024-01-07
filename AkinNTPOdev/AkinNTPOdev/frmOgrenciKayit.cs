using AkinNTPOdev.BLL;
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
    public partial class frmOgrenciKayit : Form
    {
        public frmOgrenciKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL ogrBL = new OgrenciBL();
                bool sonuc = ogrBL.OgrenciEkle(new OdevModel.Ogrenci
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Numara = txtNumara.Text.Trim()

                });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekelem Başarısız");
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Hata" +  ex.ToString());
            }
        }
    }
}
