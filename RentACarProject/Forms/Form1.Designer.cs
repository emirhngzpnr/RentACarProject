namespace RentACarProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAracYonetimi = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnKiralama = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(213, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Kiralama Otomasyonu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAracYonetimi
            // 
            this.btnAracYonetimi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAracYonetimi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracYonetimi.Location = new System.Drawing.Point(198, 119);
            this.btnAracYonetimi.Name = "btnAracYonetimi";
            this.btnAracYonetimi.Size = new System.Drawing.Size(177, 66);
            this.btnAracYonetimi.TabIndex = 1;
            this.btnAracYonetimi.Text = "Araç Yönetimi";
            this.btnAracYonetimi.UseVisualStyleBackColor = false;
            this.btnAracYonetimi.Click += new System.EventHandler(this.btnAracYonetimi_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMusteriYonetimi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(198, 204);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(177, 66);
            this.btnMusteriYonetimi.TabIndex = 2;
            this.btnMusteriYonetimi.Text = "Müşteri Kaydı";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = false;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnKiralama
            // 
            this.btnKiralama.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKiralama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralama.Location = new System.Drawing.Point(398, 119);
            this.btnKiralama.Name = "btnKiralama";
            this.btnKiralama.Size = new System.Drawing.Size(175, 66);
            this.btnKiralama.TabIndex = 3;
            this.btnKiralama.Text = "Kira Sözleşmesi";
            this.btnKiralama.UseVisualStyleBackColor = false;
            this.btnKiralama.Click += new System.EventHandler(this.btnKiralama_Click);
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRaporlama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlama.Location = new System.Drawing.Point(398, 204);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(175, 66);
            this.btnRaporlama.TabIndex = 4;
            this.btnRaporlama.Text = "Raporlama";
            this.btnRaporlama.UseVisualStyleBackColor = false;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Coral;
            this.btnCikis.Location = new System.Drawing.Point(660, 357);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(115, 45);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 423);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.btnKiralama);
            this.Controls.Add(this.btnMusteriYonetimi);
            this.Controls.Add(this.btnAracYonetimi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAracYonetimi;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnKiralama;
        private System.Windows.Forms.Button btnRaporlama;
        private System.Windows.Forms.Button btnCikis;
    }
}

