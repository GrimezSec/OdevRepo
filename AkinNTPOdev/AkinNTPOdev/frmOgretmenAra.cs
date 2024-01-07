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
    public partial class frmOgretmenAra : Form
    {
        public frmOgretmenAra()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                OgretmenBL ogrtBL = new OgretmenBL();
                string tc = txtTC.Text.Trim();
                Ogretmen ogrt = ogrtBL.OgretmenBul(tc);

                if (ogrt != null)
                {
                    // Bulunan öğretmen bilgilerini form üzerinde göster
                    MessageBox.Show($"Ad: {ogrt.Ad}\nSoyad: {ogrt.Soyad}\nTC: {ogrt.TC}");
                }
                else
                {
                    MessageBox.Show("Öğretmen bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
