using Meshur_Sehirler_CF.Data;
using Microsoft.EntityFrameworkCore;

namespace Meshur_Sehirler_CF
{
    public partial class Form1 : Form
    {
        AnadoluContext db = new AnadoluContext();
        public Form1()
        {
            InitializeComponent();
            SehirlerListele();
        }

        private void cboSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSehirler.SelectedIndex == -1)
            {
                lstOzellikler.Items.Clear();
            }
            else
            {
                OzellikleriListele();
            }
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            string ad = txtSehir.Text.Trim();
            int plaka = (int)nudPlaka.Value;
            if (ad == "")
            {
                MessageBox.Show("Bir Sehir adý girmelisiniz!");
                return; // tokat
            }
            if (db.Sehirler.Any(s => s.Plaka == plaka))
            {
                MessageBox.Show("Bu plaka daha once girildi!, baska plaka giriniz.");
                return;
            }

            //db.Sehirler.Add
            db.Add(new Sehir() { Plaka = plaka, Ad = ad });
            db.SaveChanges();
            SehirlerListele();
            txtSehir.Clear();
            nudPlaka.Value = 1;
        }

        private void SehirlerListele()
        {
            cboSehirler.DataSource = db.Sehirler.Include(s => s.Ozellikler).ToList();
        }

        private void btnOzellikEkle_Click(object sender, EventArgs e)
        {
            Sehir sehir = (Sehir)cboSehirler.SelectedItem;
            string ozellikAd = txtOzellik.Text.Trim();

            if (sehir == null)
            {
                MessageBox.Show("Once bir sehir seciniz!");
                return;
            }
            if (ozellikAd == "")
            {
                MessageBox.Show("Eklenecek ozelligi belirtiniz!");
            }

            db.Ozellikler.Add(new Ozellik() { Ad = ozellikAd, SehirId = sehir.Plaka });
            db.SaveChanges();
            SehirlerListele();
            OzellikleriListele();
            txtOzellik.Clear();
        }

        private void btnOzellikKaldýr_Click(object sender, EventArgs e)
        {
            Ozellik seciliOzellik = (Ozellik)lstOzellikler.SelectedItem;

            if (seciliOzellik == null)
                return;

            db.Remove(seciliOzellik);
            db.SaveChanges();
            OzellikleriListele();
        }

        private void OzellikleriListele()
        {
            // listboxu yenileme
            Sehir sehir = (Sehir)cboSehirler.SelectedItem;
            lstOzellikler.DataSource = sehir.Ozellikler.ToList();
        }
    }
}