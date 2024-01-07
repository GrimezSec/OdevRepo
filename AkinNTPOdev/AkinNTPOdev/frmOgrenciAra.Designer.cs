namespace AkinNTPOdev
{
    partial class frmOgrenciAra
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
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Location = new System.Drawing.Point(17, 52);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(91, 13);
            this.lblOgrNo.TabIndex = 0;
            this.lblOgrNo.Text = "Öğrenci Numarası";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(114, 49);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(100, 20);
            this.txtOgrNo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txtOgrNo);
            this.groupBox1.Controls.Add(this.lblOgrNo);
            this.groupBox1.Location = new System.Drawing.Point(29, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(74, 98);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmOgrenciAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 243);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrenciAra";
            this.Text = "frmOgrenciAra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
    }
}