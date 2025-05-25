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

namespace RentACarProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAracYonetimi_Click(object sender, EventArgs e)
        {
            FormAracYonetimi form = new FormAracYonetimi();
            form.Show();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            FormMusteri form = new FormMusteri();
            form.Show();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            FormKiralama form = new FormKiralama();
            form.Show();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            FormRaporlama form = new FormRaporlama();
            form.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
