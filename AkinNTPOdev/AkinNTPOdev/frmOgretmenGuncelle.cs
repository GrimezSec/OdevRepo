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
    public partial class frmOgretmenGuncelle : Form
    {

        private OgretmenBL ogretmenBL;
        private Ogretmen selectedOgretmen;
        public frmOgretmenGuncelle()
        {
            InitializeComponent();
            ogretmenBL = new OgretmenBL();
        }

        private void frmOgretmenGuncelle_Load (object sender, EventArgs e)
        {
            RefreshDataGridView();
            dtgOgretmen.CellClick += (s, ce) => ShowOgretmenDetails(dtgOgretmen.CurrentRow);
        }

        private void RefreshDataGridView()
        {
            dtgOgretmen.DataSource = ogretmenBL.OgretmenListele();
            
        }
        private void dtgOgretmen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgOgretmen.Rows[e.RowIndex];
                ShowOgretmenDetails(row);
                
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            selectedOgretmen = GetSelectedOgretmen();

            if (selectedOgretmen != null)
            {
                selectedOgretmen.Ad = txtAd.Text;
                selectedOgretmen.Soyad = txtSoyad.Text;
                selectedOgretmen.TC = txtTC.Text;

                ogretmenBL.OgretmenGuncelle(selectedOgretmen);
                RefreshDataGridView();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            selectedOgretmen = GetSelectedOgretmen();

            if (selectedOgretmen != null)
            {
                ogretmenBL.OgretmenSil(selectedOgretmen.OgretmenId);
                RefreshDataGridView();
            }
        }


        private Ogretmen GetSelectedOgretmen()
        {
            if (dtgOgretmen.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgOgretmen.SelectedRows[0];
                return new Ogretmen
                {
                    OgretmenId = Convert.ToInt32(row.Cells["OgretmenId"].Value),
                    Ad = row.Cells["Ad"].Value.ToString(),
                    Soyad = row.Cells["Soyad"].Value.ToString(),
                    TC = row.Cells["TC"].Value.ToString()
                };
            }

            return null;
        }

        private void ShowOgretmenDetails(DataGridViewRow row)
        {
            if (row != null)
            {
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtTC.Text = row.Cells["TC"].Value.ToString();
            }
        }

        private void frmOgretmenGuncelle_Load_1(object sender, EventArgs e)
        {
            this.tblOgretmenlerTableAdapter.Fill(this.akinNTPOdevDataSet.tblOgretmenler);

        }
    }

}
