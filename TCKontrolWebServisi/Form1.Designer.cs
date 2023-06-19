
namespace TCKontrolWebServisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_DogumTarihi = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(217, 56);
            this.txt_TC.Multiline = true;
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(406, 51);
            this.txt_TC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "DOĞUM TARİHİ:";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_Kaydet.Location = new System.Drawing.Point(217, 364);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(406, 46);
            this.btn_Kaydet.TabIndex = 8;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_DogumTarihi
            // 
            this.txt_DogumTarihi.Location = new System.Drawing.Point(217, 296);
            this.txt_DogumTarihi.Multiline = true;
            this.txt_DogumTarihi.Name = "txt_DogumTarihi";
            this.txt_DogumTarihi.Size = new System.Drawing.Size(406, 51);
            this.txt_DogumTarihi.TabIndex = 9;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(217, 219);
            this.txt_Soyad.Multiline = true;
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(406, 51);
            this.txt_Soyad.TabIndex = 10;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(217, 136);
            this.txt_Ad.Multiline = true;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(406, 51);
            this.txt_Ad.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 453);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_DogumTarihi);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_DogumTarihi;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
    }
}

