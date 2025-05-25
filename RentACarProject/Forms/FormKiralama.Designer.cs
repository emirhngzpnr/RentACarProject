namespace RentACarProject.Forms
{
    partial class FormKiralama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.krlmgster = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKirala = new System.Windows.Forms.Button();
            this.btnUcretHesapla = new System.Windows.Forms.Button();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.dgvKiralama = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 55);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(637, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ücret farkı alınmaktadır!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(313, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Kamyonet araçlar için : Günlük ücretin %50 fazlası";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.OrangeRed;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(210, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Uyarı !";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(313, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "SUV araçlar için : Günlük ücretin %20 fazlası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Kiralama";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.krlmgster);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKirala);
            this.panel2.Controls.Add(this.btnUcretHesapla);
            this.panel2.Controls.Add(this.txtUcret);
            this.panel2.Controls.Add(this.dtpBitis);
            this.panel2.Controls.Add(this.dtpBaslangic);
            this.panel2.Controls.Add(this.cmbMusteri);
            this.panel2.Controls.Add(this.cmbArac);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(1, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 287);
            this.panel2.TabIndex = 1;
            // 
            // krlmgster
            // 
            this.krlmgster.Location = new System.Drawing.Point(150, 238);
            this.krlmgster.Name = "krlmgster";
            this.krlmgster.Size = new System.Drawing.Size(225, 38);
            this.krlmgster.TabIndex = 12;
            this.krlmgster.Text = "Kiralama Listesini Goster";
            this.krlmgster.UseVisualStyleBackColor = true;
            this.krlmgster.Click += new System.EventHandler(this.krlmgster_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Toplam Ücret :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bitiş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Başlangıç Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Müşteri Seçimi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Araç Seçimi :";
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(533, 98);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(198, 38);
            this.btnKirala.TabIndex = 6;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // btnUcretHesapla
            // 
            this.btnUcretHesapla.Location = new System.Drawing.Point(167, 184);
            this.btnUcretHesapla.Name = "btnUcretHesapla";
            this.btnUcretHesapla.Size = new System.Drawing.Size(198, 38);
            this.btnUcretHesapla.TabIndex = 5;
            this.btnUcretHesapla.Text = "Hesapla";
            this.btnUcretHesapla.UseVisualStyleBackColor = true;
            this.btnUcretHesapla.Click += new System.EventHandler(this.btnUcretHesapla_Click);
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(533, 41);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.ReadOnly = true;
            this.txtUcret.Size = new System.Drawing.Size(198, 31);
            this.txtUcret.TabIndex = 4;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.dtpBitis.Location = new System.Drawing.Point(167, 142);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(198, 25);
            this.dtpBitis.TabIndex = 3;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.dtpBaslangic.Location = new System.Drawing.Point(167, 111);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(198, 25);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(167, 72);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(198, 33);
            this.cmbMusteri.TabIndex = 1;
            // 
            // cmbArac
            // 
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(167, 33);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(198, 33);
            this.cmbArac.TabIndex = 0;
            // 
            // dgvKiralama
            // 
            this.dgvKiralama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKiralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralama.Location = new System.Drawing.Point(1, 334);
            this.dgvKiralama.Name = "dgvKiralama";
            this.dgvKiralama.RowHeadersWidth = 51;
            this.dgvKiralama.RowTemplate.Height = 24;
            this.dgvKiralama.Size = new System.Drawing.Size(801, 197);
            this.dgvKiralama.TabIndex = 2;
            // 
            // FormKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.dgvKiralama);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormKiralama";
            this.Text = "FormKiralama";
            this.Load += new System.EventHandler(this.FormKiralama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.Button btnUcretHesapla;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DataGridView dgvKiralama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button krlmgster;
    }
}