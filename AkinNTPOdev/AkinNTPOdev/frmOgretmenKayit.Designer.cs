namespace AkinNTPOdev
{
    partial class frmOgretmenKayit
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
            this.lblOgretmenAd = new System.Windows.Forms.Label();
            this.lblOgretmenSoyad = new System.Windows.Forms.Label();
            this.lblOgretmenTC = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOgretmenAd
            // 
            this.lblOgretmenAd.AutoSize = true;
            this.lblOgretmenAd.Location = new System.Drawing.Point(60, 37);
            this.lblOgretmenAd.Name = "lblOgretmenAd";
            this.lblOgretmenAd.Size = new System.Drawing.Size(20, 13);
            this.lblOgretmenAd.TabIndex = 0;
            this.lblOgretmenAd.Text = "Ad";
            // 
            // lblOgretmenSoyad
            // 
            this.lblOgretmenSoyad.AutoSize = true;
            this.lblOgretmenSoyad.Location = new System.Drawing.Point(43, 92);
            this.lblOgretmenSoyad.Name = "lblOgretmenSoyad";
            this.lblOgretmenSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblOgretmenSoyad.TabIndex = 1;
            this.lblOgretmenSoyad.Text = "Soyad";
            // 
            // lblOgretmenTC
            // 
            this.lblOgretmenTC.AutoSize = true;
            this.lblOgretmenTC.Location = new System.Drawing.Point(59, 155);
            this.lblOgretmenTC.Name = "lblOgretmenTC";
            this.lblOgretmenTC.Size = new System.Drawing.Size(21, 13);
            this.lblOgretmenTC.TabIndex = 2;
            this.lblOgretmenTC.Text = "TC";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(100, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(100, 89);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(100, 152);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.lblOgretmenAd);
            this.groupBox1.Controls.Add(this.lblOgretmenSoyad);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.lblOgretmenTC);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Location = new System.Drawing.Point(34, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Kayıt";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(111, 301);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmOgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 386);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgretmenKayit";
            this.Text = "frmOgretmenKayit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOgretmenAd;
        private System.Windows.Forms.Label lblOgretmenSoyad;
        private System.Windows.Forms.Label lblOgretmenTC;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
    }
}