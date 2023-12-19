namespace GECTİ_KALDI
{
    partial class Form1
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
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtYazili2 = new System.Windows.Forms.TextBox();
            this.txtYazili1 = new System.Windows.Forms.TextBox();
            this.lblYazili2 = new System.Windows.Forms.Label();
            this.lblYazili1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(306, 256);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(90, 29);
            this.lblDurum.TabIndex = 13;
            this.lblDurum.Text = "Durum:";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(288, 203);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(117, 29);
            this.lblOrtalama.TabIndex = 12;
            this.lblOrtalama.Text = "Ortalama:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(342, 79);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 71);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtYazili2
            // 
            this.txtYazili2.Location = new System.Drawing.Point(153, 130);
            this.txtYazili2.Name = "txtYazili2";
            this.txtYazili2.Size = new System.Drawing.Size(100, 20);
            this.txtYazili2.TabIndex = 10;
            // 
            // txtYazili1
            // 
            this.txtYazili1.Location = new System.Drawing.Point(153, 50);
            this.txtYazili1.Name = "txtYazili1";
            this.txtYazili1.Size = new System.Drawing.Size(100, 20);
            this.txtYazili1.TabIndex = 9;
            // 
            // lblYazili2
            // 
            this.lblYazili2.AutoSize = true;
            this.lblYazili2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazili2.Location = new System.Drawing.Point(36, 117);
            this.lblYazili2.Name = "lblYazili2";
            this.lblYazili2.Size = new System.Drawing.Size(111, 33);
            this.lblYazili2.TabIndex = 8;
            this.lblYazili2.Text = "2.Yazılı";
            // 
            // lblYazili1
            // 
            this.lblYazili1.AutoSize = true;
            this.lblYazili1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazili1.Location = new System.Drawing.Point(36, 37);
            this.lblYazili1.Name = "lblYazili1";
            this.lblYazili1.Size = new System.Drawing.Size(111, 33);
            this.lblYazili1.TabIndex = 7;
            this.lblYazili1.Text = "1.Yazılı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtYazili2);
            this.Controls.Add(this.txtYazili1);
            this.Controls.Add(this.lblYazili2);
            this.Controls.Add(this.lblYazili1);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtYazili2;
        private System.Windows.Forms.TextBox txtYazili1;
        private System.Windows.Forms.Label lblYazili2;
        private System.Windows.Forms.Label lblYazili1;
    }
}

