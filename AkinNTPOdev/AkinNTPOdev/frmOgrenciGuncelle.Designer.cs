namespace AkinNTPOdev
{
    partial class frmOgrenciGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgOgrenci = new System.Windows.Forms.DataGridView();
            this.akinNTPOdevDataSet = new AkinNTPOdev.AkinNTPOdevDataSet();
            this.akinNTPOdevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tblOgrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOgrencilerTableAdapter = new AkinNTPOdev.AkinNTPOdevDataSetTableAdapters.tblOgrencilerTableAdapter();
            this.ogrenciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akinNTPOdevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akinNTPOdevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrencilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOgrenci
            // 
            this.dtgOgrenci.AutoGenerateColumns = false;
            this.dtgOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOgrenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.numaraDataGridViewTextBoxColumn});
            this.dtgOgrenci.DataSource = this.tblOgrencilerBindingSource;
            this.dtgOgrenci.Location = new System.Drawing.Point(47, 24);
            this.dtgOgrenci.Name = "dtgOgrenci";
            this.dtgOgrenci.Size = new System.Drawing.Size(445, 334);
            this.dtgOgrenci.TabIndex = 0;
            this.dtgOgrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOgrenci_CellContentClick);
            // 
            // akinNTPOdevDataSet
            // 
            this.akinNTPOdevDataSet.DataSetName = "AkinNTPOdevDataSet";
            this.akinNTPOdevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akinNTPOdevDataSetBindingSource
            // 
            this.akinNTPOdevDataSetBindingSource.DataSource = this.akinNTPOdevDataSet;
            this.akinNTPOdevDataSetBindingSource.Position = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(74, 389);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(417, 379);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tblOgrencilerBindingSource
            // 
            this.tblOgrencilerBindingSource.DataMember = "tblOgrenciler";
            this.tblOgrencilerBindingSource.DataSource = this.akinNTPOdevDataSetBindingSource;
            // 
            // tblOgrencilerTableAdapter
            // 
            this.tblOgrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciIdDataGridViewTextBoxColumn
            // 
            this.ogrenciIdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.HeaderText = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.Name = "ogrenciIdDataGridViewTextBoxColumn";
            this.ogrenciIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "Numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "Numara";
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(545, 73);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(545, 119);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(545, 177);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 5;
            // 
            // frmOgrenciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtgOgrenci);
            this.Name = "frmOgrenciGuncelle";
            this.Text = "OgrenciGuncelle";
            this.Load += new System.EventHandler(this.frmOgrenciGuncelle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akinNTPOdevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akinNTPOdevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrencilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOgrenci;
        private System.Windows.Forms.BindingSource akinNTPOdevDataSetBindingSource;
        private AkinNTPOdevDataSet akinNTPOdevDataSet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.BindingSource tblOgrencilerBindingSource;
        private AkinNTPOdevDataSetTableAdapters.tblOgrencilerTableAdapter tblOgrencilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
    }
}