using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// classlarımıza erişmek için models paketimizi tanıtıyoruz
using RentACarProject.Models;


namespace RentACarProject
{
    public partial class FormMusteri : Form
    {
       

        public FormMusteri()
        {
            InitializeComponent();
        }
        private void MusteriListesiniGoster()
        {
            dgvMusteriler.DataSource = null;
            dgvMusteriler.DataSource = MusteriVeri.MusteriListesi;
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text
            };

            MusteriVeri.MusteriListesi.Add(musteri);
            MusteriListesiniGoster();
            Temizle();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow != null)
            {
                int seciliIndex = dgvMusteriler.CurrentRow.Index;

                DialogResult sonuc = MessageBox.Show(
                    "Seçilen müşteriyi silmek istediğinizden emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (sonuc == DialogResult.Yes)
                {
                    MusteriVeri.MusteriListesi.RemoveAt(seciliIndex);
                    MusteriListesiniGoster();
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow != null)
            {
                int seciliIndex = dgvMusteriler.CurrentRow.Index;

                MusteriVeri.MusteriListesi[seciliIndex].Ad = txtAd.Text;
                MusteriVeri.MusteriListesi[seciliIndex].Soyad = txtSoyad.Text;
                MusteriVeri.MusteriListesi[seciliIndex].Telefon = txtTelefon.Text;
                MusteriVeri.MusteriListesi[seciliIndex].Email = txtEmail.Text;

                MusteriListesiniGoster();
                Temizle();
            }
        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMusteriler.Rows[e.RowIndex];

                txtAd.Text = row.Cells[0].Value.ToString();
                txtSoyad.Text = row.Cells[1].Value.ToString();
                txtTelefon.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriListesiniGoster();
        }
    }
}
