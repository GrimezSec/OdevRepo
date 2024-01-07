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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            frmOgrenciKayit frm = new frmOgrenciKayit();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }

        private void btnOgremtenKayıt_Click(object sender, EventArgs e)
        {
            frmOgretmenKayit frm = new frmOgretmenKayit();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();    
        }

        private void btnOgrenciAra_Click(object sender, EventArgs e)
        {
            frmOgrenciAra frm = new frmOgrenciAra();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();

        }

        private void btnOgretmenAra_Click(object sender, EventArgs e)
        {
            frmOgretmenAra frm = new frmOgretmenAra();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            frmOgrenciGuncelle frm = new frmOgrenciGuncelle();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }

        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            frmOgretmenGuncelle frm = new frmOgretmenGuncelle();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }
    }
}
