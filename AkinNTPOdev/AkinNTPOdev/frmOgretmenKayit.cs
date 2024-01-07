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
    public partial class frmOgretmenKayit : Form
    {
        public frmOgretmenKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                OgretmenBL ogrtBL = new OgretmenBL();
                bool sonuc = ogrtBL.OgretmenEkle(new OdevModel.Ogretmen
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    TC = txtTC.Text.Trim(),
                });

                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız");
            } catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.ToString());
            }
        }
    }
}
