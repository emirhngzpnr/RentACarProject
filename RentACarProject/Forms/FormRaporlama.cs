using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarProject.Forms;
using RentACarProject.Models;



namespace RentACarProject.Forms
{
    public partial class FormRaporlama : Form
    {
        public FormRaporlama()
        {
            InitializeComponent();
        }

        private void FormRaporlama_Load(object sender, EventArgs e)
        {
            var liste = KiralamaVeri.KiralamaListesi;

            // DataGridView'e tüm kayıtları yükleriz
            dgvTumKiralamalar.DataSource = null;
            dgvTumKiralamalar.DataSource = liste;

            // Toplam kiralama sayısı
            txtToplamKiralama.Text = liste.Count.ToString();

            // Toplam ciro
            txtToplamCiro.Text = liste.Sum(k => k.Ucret).ToString("C"); // Örn: ₺12.000,00

            // En çok kiralanan araç
            var enCok = liste
                .GroupBy(k => k.AracBilgisi)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            txtEnCokKiralanan.Text = enCok != null
                ? $"{enCok.Key} ({enCok.Count()} kez)"
                : "Veri yok.";
        }
    }
}
