namespace Class_Ders_Ort
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
            this.lblYazili1 = new System.Windows.Forms.Label();
            this.lblYazili2 = new System.Windows.Forms.Label();
            this.lblYazili3 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.txtYazili3 = new System.Windows.Forms.TextBox();
            this.txtYazili1 = new System.Windows.Forms.TextBox();
            this.txtYazili2 = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYazili1
            // 
            this.lblYazili1.AutoSize = true;
            this.lblYazili1.Location = new System.Drawing.Point(20, 32);
            this.lblYazili1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYazili1.Name = "lblYazili1";
            this.lblYazili1.Size = new System.Drawing.Size(54, 18);
            this.lblYazili1.TabIndex = 0;
            this.lblYazili1.Text = "1.Yazılı";
            // 
            // lblYazili2
            // 
            this.lblYazili2.AutoSize = true;
            this.lblYazili2.Location = new System.Drawing.Point(20, 78);
            this.lblYazili2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYazili2.Name = "lblYazili2";
            this.lblYazili2.Size = new System.Drawing.Size(54, 18);
            this.lblYazili2.TabIndex = 1;
            this.lblYazili2.Text = "2.Yazılı";
            // 
            // lblYazili3
            // 
            this.lblYazili3.AutoSize = true;
            this.lblYazili3.Location = new System.Drawing.Point(20, 123);
            this.lblYazili3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYazili3.Name = "lblYazili3";
            this.lblYazili3.Size = new System.Drawing.Size(54, 18);
            this.lblYazili3.TabIndex = 2;
            this.lblYazili3.Text = "3.Yazılı";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(20, 168);
            this.lblOrtalama.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(69, 18);
            this.lblOrtalama.TabIndex = 3;
            this.lblOrtalama.Text = "Ortalama";
            // 
            // txtYazili3
            // 
            this.txtYazili3.Location = new System.Drawing.Point(102, 120);
            this.txtYazili3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYazili3.Name = "txtYazili3";
            this.txtYazili3.Size = new System.Drawing.Size(148, 24);
            this.txtYazili3.TabIndex = 4;
            // 
            // txtYazili1
            // 
            this.txtYazili1.Location = new System.Drawing.Point(102, 28);
            this.txtYazili1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYazili1.Name = "txtYazili1";
            this.txtYazili1.Size = new System.Drawing.Size(148, 24);
            this.txtYazili1.TabIndex = 5;
            // 
            // txtYazili2
            // 
            this.txtYazili2.Location = new System.Drawing.Point(102, 74);
            this.txtYazili2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYazili2.Name = "txtYazili2";
            this.txtYazili2.Size = new System.Drawing.Size(148, 24);
            this.txtYazili2.TabIndex = 6;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(102, 164);
            this.txtOrtalama.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(148, 24);
            this.txtOrtalama.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(102, 222);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(150, 36);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 293);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtYazili2);
            this.Controls.Add(this.txtYazili1);
            this.Controls.Add(this.txtYazili3);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblYazili3);
            this.Controls.Add(this.lblYazili2);
            this.Controls.Add(this.lblYazili1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYazili1;
        private System.Windows.Forms.Label lblYazili2;
        private System.Windows.Forms.Label lblYazili3;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.TextBox txtYazili3;
        private System.Windows.Forms.TextBox txtYazili1;
        private System.Windows.Forms.TextBox txtYazili2;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Button btnHesapla;
    }
}

