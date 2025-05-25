using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarProject.Models;


namespace RentACarProject
{
    public partial class FormAracYonetimi : Form
    {
       

        public FormAracYonetimi()
        {
            InitializeComponent();
        }
        private void AracListesiniGoster()
        {
            dgvAraclar.DataSource = null;
            dgvAraclar.DataSource = AracVeri.AracListesi;
        }

        private void Temizle()
        {
            cmbAracTuru.SelectedIndex = 0;
            txtPlaka.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtYil.Clear();
            nudGunlukUcret.Value = 0;
        }
        private void FormAracYonetimi_Load(object sender, EventArgs e)
        {
            cmbAracTuru.Items.Add("Sedan");
            cmbAracTuru.Items.Add("SUV");
            cmbAracTuru.Items.Add("Kamyonet");
            cmbAracTuru.SelectedIndex = 0;

        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac yeniArac;
            

            switch (cmbAracTuru.Text)
            {
                case "Sedan":
                    yeniArac = new Sedan(); break;
                case "SUV":
                    yeniArac = new SUV(); break;
                case "Kamyonet":
                    yeniArac = new Kamyonet(); break;
                default:
                    MessageBox.Show("Lütfen araç türü seçin!");
                    return;
            }



            yeniArac.Plaka=txtPlaka.Text;
            yeniArac.Marka = txtMarka.Text;
            yeniArac.Model = txtModel.Text;
            yeniArac.Yil = Convert.ToInt32(txtYil.Text);
            yeniArac.GunlukUcret = nudGunlukUcret.Value;

            AracVeri.AracListesi.Add(yeniArac);


            
            AracListesiniGoster();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.CurrentRow != null)
            {
                int seciliIndex = dgvAraclar.CurrentRow.Index;

                AracVeri.AracListesi[seciliIndex].AracTuru = cmbAracTuru.Text;
                AracVeri.AracListesi[seciliIndex].Plaka = txtPlaka.Text;
                AracVeri.AracListesi[seciliIndex].Marka = txtMarka.Text;
                AracVeri.AracListesi[seciliIndex].Model = txtModel.Text;
                AracVeri.AracListesi[seciliIndex].Yil = Convert.ToInt32(txtYil.Text);
                AracVeri.AracListesi[seciliIndex].GunlukUcret = nudGunlukUcret.Value;

                AracListesiniGoster();
                Temizle();
            }
        }


        private void dgvAraclar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // dgvmizdeki satıra tıklandığında o satırdaki bilgileri ilgili alanlara getiriyoruz
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAraclar.Rows[e.RowIndex];

                cmbAracTuru.Text = row.Cells["AracTuru"].Value.ToString();
                txtPlaka.Text = row.Cells["Plaka"].Value.ToString();
                txtMarka.Text = row.Cells["Marka"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtYil.Text = row.Cells["Yil"].Value.ToString();
                nudGunlukUcret.Value = Convert.ToDecimal(row.Cells["GunlukUcret"].Value);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.CurrentRow != null)
            {
                int seciliIndex = dgvAraclar.CurrentRow.Index;

                DialogResult sonuc = MessageBox.Show(
                    "Seçilen aracı silmek istediğinizden emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (sonuc == DialogResult.Yes)
                {
                    AracVeri.AracListesi.RemoveAt(seciliIndex);
                    AracListesiniGoster();
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracListesiniGoster();
        }
    }

}
