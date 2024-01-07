namespace AkinNTPOdev
{
    partial class frmOgretmenGuncelle
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
            this.dtgOgretmen = new System.Windows.Forms.DataGridView();
            this.akinNTPOdevDataSet = new AkinNTPOdev.AkinNTPOdevDataSet();
            this.akinNTPOdevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.tblOgretmenlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOgretmenlerTableAdapter = new AkinNTPOdev.AkinNTPOdevDataSetTableAdapters.tblOgretmenlerTableAdapter();
            this.ogretmenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akinNTPOdevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akinNTPOdevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgretmenlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOgretmen
            // 
            this.dtgOgretmen.AutoGenerateColumns = false;
            this.dtgOgretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOgretmen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogretmenIdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn});
            this.dtgOgretmen.DataSource = this.tblOgretmenlerBindingSource;
            this.dtgOgretmen.Location = new System.Drawing.Point(72, 12);
            this.dtgOgretmen.Name = "dtgOgretmen";
            this.dtgOgretmen.Size = new System.Drawing.Size(424, 361);
            this.dtgOgretmen.TabIndex = 0;
            this.dtgOgretmen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOgretmen_CellContentClick);
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
            this.btnGuncelle.Location = new System.Drawing.Point(72, 392);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(421, 392);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(540, 62);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(119, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(540, 109);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(119, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(540, 159);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(119, 20);
            this.txtTC.TabIndex = 5;
            // 
            // tblOgretmenlerBindingSource
            // 
            this.tblOgretmenlerBindingSource.DataMember = "tblOgretmenler";
            this.tblOgretmenlerBindingSource.DataSource = this.akinNTPOdevDataSetBindingSource;
            // 
            // tblOgretmenlerTableAdapter
            // 
            this.tblOgretmenlerTableAdapter.ClearBeforeFill = true;
            // 
            // ogretmenIdDataGridViewTextBoxColumn
            // 
            this.ogretmenIdDataGridViewTextBoxColumn.DataPropertyName = "OgretmenId";
            this.ogretmenIdDataGridViewTextBoxColumn.HeaderText = "OgretmenId";
            this.ogretmenIdDataGridViewTextBoxColumn.Name = "ogretmenIdDataGridViewTextBoxColumn";
            this.ogretmenIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // frmOgretmenGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtgOgretmen);
            this.Name = "frmOgretmenGuncelle";
            this.Text = "Ogretmen Guncelle / Sil";
            this.Load += new System.EventHandler(this.frmOgretmenGuncelle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akinNTPOdevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akinNTPOdevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgretmenlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOgretmen;
        private System.Windows.Forms.BindingSource akinNTPOdevDataSetBindingSource;
        private AkinNTPOdevDataSet akinNTPOdevDataSet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.BindingSource tblOgretmenlerBindingSource;
        private AkinNTPOdevDataSetTableAdapters.tblOgretmenlerTableAdapter tblOgretmenlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
    }
}