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
    public partial class frmOgrenciGuncelle : Form
    {

        private OgrenciBL ogrenciBL;
        private Ogrenci selectedOgrenci;
        public frmOgrenciGuncelle()
        {
            InitializeComponent();
            ogrenciBL = new OgrenciBL();
        }

        private void frmOgrenciGuncelle_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            dtgOgrenci.CellClick += (s, ce) => ShowOgrenciDetails(dtgOgrenci.CurrentRow);
        }

        private void RefreshDataGridView()
        {
            dtgOgrenci.DataSource = ogrenciBL.OgrenciListele();
        }

        private void dtgOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgOgrenci.Rows[e.RowIndex];
                ShowOgrenciDetails(row);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            selectedOgrenci = GetSelectedOgrenci();

            if (selectedOgrenci != null)
            {
                selectedOgrenci.Ad = txtAd.Text;
                selectedOgrenci.Soyad = txtSoyad.Text;
                selectedOgrenci.Numara = txtNumara.Text;

                ogrenciBL.OgrenciGuncelle(selectedOgrenci);
                RefreshDataGridView();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            selectedOgrenci = GetSelectedOgrenci();

            if (selectedOgrenci != null)
            {
                ogrenciBL.OgrenciSil(selectedOgrenci.OgrenciId);
                RefreshDataGridView();
            }
        }

        private Ogrenci GetSelectedOgrenci()
        {
            if (dtgOgrenci.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgOgrenci.SelectedRows[0];
                return new Ogrenci
                {
                    OgrenciId = Convert.ToInt32(row.Cells["OgrenciID"].Value),
                    Ad = row.Cells["Ad"].Value.ToString(),
                    Soyad = row.Cells["Soyad"].Value.ToString(),
                    Numara = row.Cells["Numara"].Value.ToString()
                };
            }

            return null;
        }

        private void ShowOgrenciDetails(DataGridViewRow row)
        {
            if (row != null)
            {
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtNumara.Text = row.Cells["Numara"].Value.ToString();
            }
        }

        private void frmOgrenciGuncelle_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'akinNTPOdevDataSet.tblOgrenciler' table. You can move, or remove it, as needed.
            this.tblOgrencilerTableAdapter.Fill(this.akinNTPOdevDataSet.tblOgrenciler);

        }
    }

}
