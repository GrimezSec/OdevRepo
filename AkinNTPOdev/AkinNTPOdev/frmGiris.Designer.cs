namespace AkinNTPOdev
{
    partial class frmGiris
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
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.btnOgremtenKayıt = new System.Windows.Forms.Button();
            this.btnOgrenciAra = new System.Windows.Forms.Button();
            this.btnOgretmenAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.Location = new System.Drawing.Point(59, 72);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(153, 73);
            this.btnOgrenciKayit.TabIndex = 0;
            this.btnOgrenciKayit.Text = "Öğrenci Kayıt";
            this.btnOgrenciKayit.UseVisualStyleBackColor = true;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.btnOgrenciKayit_Click);
            // 
            // btnOgremtenKayıt
            // 
            this.btnOgremtenKayıt.Location = new System.Drawing.Point(276, 72);
            this.btnOgremtenKayıt.Name = "btnOgremtenKayıt";
            this.btnOgremtenKayıt.Size = new System.Drawing.Size(153, 73);
            this.btnOgremtenKayıt.TabIndex = 1;
            this.btnOgremtenKayıt.Text = "Öğretmen Kayıt";
            this.btnOgremtenKayıt.UseVisualStyleBackColor = true;
            this.btnOgremtenKayıt.Click += new System.EventHandler(this.btnOgremtenKayıt_Click);
            // 
            // btnOgrenciAra
            // 
            this.btnOgrenciAra.Location = new System.Drawing.Point(59, 178);
            this.btnOgrenciAra.Name = "btnOgrenciAra";
            this.btnOgrenciAra.Size = new System.Drawing.Size(153, 73);
            this.btnOgrenciAra.TabIndex = 2;
            this.btnOgrenciAra.Text = "Öğrenci Ara";
            this.btnOgrenciAra.UseVisualStyleBackColor = true;
            this.btnOgrenciAra.Click += new System.EventHandler(this.btnOgrenciAra_Click);
            // 
            // btnOgretmenAra
            // 
            this.btnOgretmenAra.Location = new System.Drawing.Point(276, 178);
            this.btnOgretmenAra.Name = "btnOgretmenAra";
            this.btnOgretmenAra.Size = new System.Drawing.Size(153, 73);
            this.btnOgretmenAra.TabIndex = 3;
            this.btnOgretmenAra.Text = "ÖğretmenAra";
            this.btnOgretmenAra.UseVisualStyleBackColor = true;
            this.btnOgretmenAra.Click += new System.EventHandler(this.btnOgretmenAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 333);
            this.Controls.Add(this.btnOgretmenAra);
            this.Controls.Add(this.btnOgrenciAra);
            this.Controls.Add(this.btnOgremtenKayıt);
            this.Controls.Add(this.btnOgrenciKayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Button btnOgremtenKayıt;
        private System.Windows.Forms.Button btnOgrenciAra;
        private System.Windows.Forms.Button btnOgretmenAra;
    }
}

