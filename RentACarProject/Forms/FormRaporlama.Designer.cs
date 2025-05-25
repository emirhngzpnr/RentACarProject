namespace RentACarProject.Forms
{
    partial class FormRaporlama
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnCokKiralanan = new System.Windows.Forms.TextBox();
            this.txtToplamKiralama = new System.Windows.Forms.TextBox();
            this.txtToplamCiro = new System.Windows.Forms.TextBox();
            this.dgvTumKiralamalar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumKiralamalar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(286, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstatistiskler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.txtToplamCiro);
            this.panel2.Controls.Add(this.txtToplamKiralama);
            this.panel2.Controls.Add(this.txtEnCokKiralanan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 267);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "En Çok Kiralanan Araç :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toplam Kiralama Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(134, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toplam Ciro :";
            // 
            // txtEnCokKiralanan
            // 
            this.txtEnCokKiralanan.Location = new System.Drawing.Point(273, 34);
            this.txtEnCokKiralanan.Name = "txtEnCokKiralanan";
            this.txtEnCokKiralanan.Size = new System.Drawing.Size(208, 22);
            this.txtEnCokKiralanan.TabIndex = 3;
            // 
            // txtToplamKiralama
            // 
            this.txtToplamKiralama.Location = new System.Drawing.Point(273, 81);
            this.txtToplamKiralama.Name = "txtToplamKiralama";
            this.txtToplamKiralama.Size = new System.Drawing.Size(208, 22);
            this.txtToplamKiralama.TabIndex = 4;
            // 
            // txtToplamCiro
            // 
            this.txtToplamCiro.Location = new System.Drawing.Point(273, 123);
            this.txtToplamCiro.Name = "txtToplamCiro";
            this.txtToplamCiro.Size = new System.Drawing.Size(208, 22);
            this.txtToplamCiro.TabIndex = 5;
            // 
            // dgvTumKiralamalar
            // 
            this.dgvTumKiralamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumKiralamalar.Location = new System.Drawing.Point(1, 326);
            this.dgvTumKiralamalar.Name = "dgvTumKiralamalar";
            this.dgvTumKiralamalar.RowHeadersWidth = 51;
            this.dgvTumKiralamalar.RowTemplate.Height = 24;
            this.dgvTumKiralamalar.Size = new System.Drawing.Size(803, 179);
            this.dgvTumKiralamalar.TabIndex = 2;
            // 
            // FormRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.dgvTumKiralamalar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRaporlama";
            this.Text = "FormRaporlama";
            this.Load += new System.EventHandler(this.FormRaporlama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumKiralamalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtToplamCiro;
        private System.Windows.Forms.TextBox txtToplamKiralama;
        private System.Windows.Forms.TextBox txtEnCokKiralanan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTumKiralamalar;
    }
}