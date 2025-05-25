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
    public partial class FormKiralama : Form
    {
        public FormKiralama()
        {
            InitializeComponent();
        }
       
        

        private void FormKiralama_Load(object sender, EventArgs e)
        {
                KiralamaListesiniGoster();

            cmbArac.DataSource = null;
            cmbArac.DataSource = AracVeri.AracListesi;
            cmbArac.DisplayMember = "OzluBilgi";

            // Müşteri listesini ComboBox'a yükleriz
            cmbMusteri.DataSource = null;
            cmbMusteri.DataSource = MusteriVeri.MusteriListesi;
            cmbMusteri.DisplayMember = "AdSoyad"; 

            // Başlangıç ve bitiş tarihi bugünden başlasın
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
        }

        private void btnUcretHesapla_Click(object sender, EventArgs e)
        {
            if(cmbArac.SelectedItem is IKiralik kiralanabilirArac)
{
                DateTime baslangic = dtpBaslangic.Value.Date;
                DateTime bitis = dtpBitis.Value.Date;

                int gunSayisi = (bitis - baslangic).Days + 1;

                if (gunSayisi <= 0)
                {
                    MessageBox.Show("Geçerli bir tarih aralığı seçin.", "Uyarı");
                    return;
                }

                decimal ucret = kiralanabilirArac.KiraHesapla(gunSayisi);
                txtUcret.Text = ucret.ToString("C"); // ₺ işaretiyle göster
            }

        }
        private void KiralamaListesiniGoster()
        {
            dgvKiralama.DataSource = null;
            dgvKiralama.DataSource = KiralamaVeri.KiralamaListesi;
        }


        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (cmbArac.SelectedItem is Arac secilenArac && cmbMusteri.SelectedItem is Musteri secilenMusteri)
            {
                if (decimal.TryParse(txtUcret.Text.Replace("₺", "").Trim(), out decimal ucret))
                {
                    Kiralama yeniKiralama = new Kiralama
                    {
                        MusteriAdi = $"{secilenMusteri.Ad} {secilenMusteri.Soyad}",
                        AracBilgisi = secilenArac.OzluBilgi,
                        BaslangicTarihi = dtpBaslangic.Value.Date,
                        BitisTarihi = dtpBitis.Value.Date,
                        Ucret = ucret
                    };

                    
                    KiralamaVeri.KiralamaListesi.Add(yeniKiralama);
                    KiralamaListesiniGoster();
                   

                    MessageBox.Show("Kiralama başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen önce ücret hesaplayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void krlmgster_Click(object sender, EventArgs e)
        {
            KiralamaListesiniGoster();
        }
    }
}
