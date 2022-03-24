using Shoe_Project_V2.Model.Model_Database;
using Shoe_Project_V2.View.Ayakkabi_Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Project_V2.View.Satis_Formlar
{
    public partial class Satis_Detay_Form : Form
    {
        List<Satis_Detay> satislar = new List<Satis_Detay>();
        Satis_Detay secili_satisdetaylar = new Satis_Detay();
        Satislar satis = new Satislar();
        Shoe_DbEntities db = new Shoe_DbEntities();

        List<Musteri> musteriler = new List<Musteri>();
        List<comboboxicin> urunler_combo = new List<comboboxicin>();
        comboboxicin secili_urun = new comboboxicin();


        BindingSource source = new BindingSource();
        class comboboxicin
        {
            public int? ID { get; set; }
            public string AD { get; set; }
            public int? Fiyat { get; set; }
        }
        public Satis_Detay_Form()
        {
            InitializeComponent();
        }
        private void Satis__Detay_Form_Load(object sender, EventArgs e)
        {
            Verileri_Cek();


        }
        public void Cek_Satislar(Satislar satis_get)
        {
            this.satis = satis_get;
        }
        private void Satislar_Cek()
        {
            //ilişkili tablolarda eklemeden sonra verilerin ilişkilerinin tazelenmesi için
            /// db yi yenilememiz gerekiyor aksi halde satis detaya yeni ürün eklediğimizde 
            /// oluşacak hata satisdetayın ilişkili tablolarının null gelmesi hatası
            db = new Shoe_DbEntities();
            satislar = db.Satis_Detay.Where(x => x.satisid == satis.ID).ToList();


        }
        private void Urunleri_Cek()
        {
            urunler_combo = (from a in db.Urun
                             select new comboboxicin
                             {
                                 ID = a.ID,
                                 AD = a.Urun_Detay.urun_ad,
                                 Fiyat = a.fiyat
                             }).ToList();
            var listeEkleUrunler = new List<comboboxicin>();
                listeEkleUrunler.AddRange(urunler_combo.ToList());
            comboBox2.DataSource = listeEkleUrunler;
         guncelle_urun_cb.DataSource = urunler_combo.ToList();
        }
        private void Verileri_Cek()
        {

            musteriler = db.Musteri.ToList();
            comboBox1.DataSource = guncelle_musteri_cb.DataSource = musteriler;
            comboBox1.DisplayMember = guncelle_musteri_cb.DisplayMember = "musteri_AD";
            comboBox1.ValueMember = guncelle_musteri_cb.ValueMember = "ID";
            Satislar_Cek();
            Urunleri_Cek();
            source.DataSource = satislar;
            dataGridView1.DataSource = source;
            //hıza direct etki eder
            comboBox2.DisplayMember = guncelle_urun_cb.DisplayMember = "AD";
            comboBox2.ValueMember = guncelle_urun_cb.ValueMember = "ID";
            dataGridView1.Columns[nameof(secili_satisdetaylar.satisid)].Visible = false;
            dataGridView1.Columns[nameof(secili_satisdetaylar.Urun)].Visible = false;
            dataGridView1.Columns[nameof(secili_satisdetaylar.Satislar)].Visible = false;


            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if (satislar.Count == 0)
            {
                Satislar satis_add = new Satislar { musteri_ID = (int)comboBox1.SelectedValue, tarih = DateTime.Now.Year, tutar = 0 };
                db.Satislar.Add(satis_add);
                db.SaveChanges();
                satis = satis_add;
            }
            Satis_Detay detay_add = new Satis_Detay();

            detay_add = new Satis_Detay { adet = Convert.ToInt32(adet_e_tb.Text), satisid = satis.ID, tutar = Convert.ToInt32(tutar_e_tb.Text), urunid = (int)comboBox2.SelectedValue };
            db.Satis_Detay.Add(detay_add);
            db.SaveChanges();
            satis.tutar += Convert.ToInt32(tutar_e_tb.Text);
            db.SaveChanges();

            Satislar_Cek();

            source.DataSource = satislar;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && satislar.Count > 0)
            {

                //   secili_satisdetaylar = (Satis_Detay)dataGridView1.CurrentRow.DataBoundItem;
                secili_satisdetaylar = (Satis_Detay)source.Current;
                // secili_satisdetaylar = satislar.Where(x=>x.ID == ((Satis_Detay)source.Current).ID).FirstOrDefault();
                secili_urun = urunler_combo.Where(x => x.ID == secili_satisdetaylar.urunid).FirstOrDefault();
                guncelle_urun_cb.SelectedItem = secili_urun;
                sil_urun_tb.Text = secili_urun.AD;

                guncelle_ID_tb.Text = sil_ID_tb.Text = secili_satisdetaylar.ID.ToString();
                guncelle_fiyat_tb.Text = sil_fiyat_tb.Text = secili_satisdetaylar.Urun.fiyat.ToString();
                guncelle_tutar_tb.Text = sil_tutar_tb.Text = (secili_satisdetaylar.adet * secili_satisdetaylar.Urun.fiyat) + "";
                guncelle_adet_tb.Text = sil_adet_tb.Text = secili_satisdetaylar.adet.ToString();
                // ad_g_tb.Text = ad_s_tb.Text = secili_satisdetaylar.tutar;
            }

        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
         int count=    db.Satis_Detay.Count(x => x.satisid == secili_satisdetaylar.satisid);
            
            if (count == 1)
                db.Satislar.Remove(secili_satisdetaylar.Satislar);
            db.Satis_Detay.Remove(secili_satisdetaylar);
            db.SaveChanges();
            
            secili_satisdetaylar = new Satis_Detay();
            Satislar_Cek();
            
            source.DataSource = satislar;

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(guncelle_adet_tb.Text);
            int fiyat = Convert.ToInt32(guncelle_fiyat_tb.Text);
            int tutar = adet * fiyat;
            int fark = tutar - (int)secili_satisdetaylar.tutar;
            secili_satisdetaylar.adet = adet;
            secili_satisdetaylar.tutar = tutar;
            secili_satisdetaylar.Satislar.tutar += fark;
            secili_satisdetaylar.urunid = (int)guncelle_urun_cb.SelectedValue;
            db.SaveChanges();
            secili_satisdetaylar = new Satis_Detay();
            Satislar_Cek();
            source.DataSource = satislar;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (comboboxicin)comboBox2.SelectedItem;
            fiyat_tb.Text = s.Fiyat.ToString();
        }

        private void adet_carpi_tutar_text_changed(object sender, EventArgs e)
        {
            if (adet_e_tb.Text.Length > 0 && fiyat_tb.Text.Length > 0)
                tutar_e_tb.Text = (Convert.ToInt32(fiyat_tb.Text) * Convert.ToInt32(adet_e_tb.Text)) + "";
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            guncelle_panel.Enabled = sil_panel.Visible = satislar.Count == 0 ? false : true;
        }

        private void guncelle_adet_tb_TextChanged(object sender, EventArgs e)
        {
            if (guncelle_adet_tb.Text.Length > 0 && guncelle_fiyat_tb.Text.Length > 0)
                guncelle_tutar_tb.Text = (Convert.ToInt32(guncelle_fiyat_tb.Text) * Convert.ToInt32(guncelle_adet_tb.Text)) + "";
        }
    }
}
