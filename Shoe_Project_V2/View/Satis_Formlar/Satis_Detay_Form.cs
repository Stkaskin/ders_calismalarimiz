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
        Shoe_DbEntities db = new Shoe_DbEntities();
        List<Musteri> musteriler = new List<Musteri>();
        List<comboboxicin> urunler_combo = new List<comboboxicin>();
        
       
        BindingSource source = new BindingSource();
        class comboboxicin
        {
           public int? ID { get; set; }
            public string  AD{ get; set; }
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

        private void Verileri_Cek()
        {
            satislar = db.Satis_Detay.ToList();
            musteriler = db.Musteri.ToList();
            comboBox1.DataSource = musteriler;
            comboBox1.DisplayMember = "musteri_AD";
            comboBox1.ValueMember= "ID";
            urunler_combo  =( from a in db.Urun
                     select new comboboxicin
                     {
                         ID = a.ID,
                         AD = a.Urun_Detay.urun_ad,
                         Fiyat = a.fiyat
                     }).ToList();
            comboBox2.DataSource = urunler_combo.ToList();
            comboBox2.DisplayMember = "AD";
            comboBox2.ValueMember = "ID";
            source.DataSource = satislar;
            dataGridView1.DataSource = source;
            //hıza direct etki eder
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dataGridView1.RowHeadersVisible = false;
        }
        
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            Satislar satis_add = new Satislar { musteri_ID = 1, tarih = 1, tutar = -1 };
            db.Satislar.Add(satis_add);
            db.SaveChanges();
            Satis_Detay detay_add = new Satis_Detay { adet = 10, satisid = satis_add.ID, tutar = 1, urunid = 3 };
            db.Satis_Detay.Add(detay_add);
            db.SaveChanges();
            satislar = db.Satis_Detay.ToList();
            source.DataSource = satislar;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            secili_satisdetaylar = (Satis_Detay)dataGridView1.CurrentRow.DataBoundItem;
            id_g_tb.Text = id_s_tb.Text = secili_satisdetaylar.ID.ToString();
           // ad_g_tb.Text = ad_s_tb.Text = secili_satisdetaylar.tutar;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            db.Satis_Detay.Remove(secili_satisdetaylar);
            db.SaveChanges();
            secili_satisdetaylar = new Satis_Detay();
            satislar = db.Satis_Detay.ToList();
            source.DataSource = satislar;

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
          //  secili_satisdetaylar.marka_Ad = ad_g_tb.Text;
            db.SaveChanges();
            secili_satisdetaylar = new Satis_Detay();
            satislar = db.Satis_Detay.ToList();
            source.DataSource = satislar;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s =(comboboxicin)comboBox2.SelectedItem;
            fiyat_tb.Text = s.Fiyat.ToString();
        }

        private void adet_carpi_tutar_text_changed(object sender, EventArgs e)
        {
            if (adet_e_tb.Text.Length>0 && fiyat_tb.Text.Length>0)
            tutar_e_tb.Text = (Convert.ToInt32(fiyat_tb.Text) * Convert.ToInt32(adet_e_tb.Text))+"";
        }
    }
}
