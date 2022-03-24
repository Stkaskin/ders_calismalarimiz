using Shoe_Project_V2.Model.Model_Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Project_V2.View.Ayakkabi_Formlar
{
    public partial class Ayakkabi_Form : Form
    {
        Shoe_DbEntities db = new Shoe_DbEntities();
        List<Marka> markalar = new List<Marka>();
        List<Numara> numaralar = new List<Numara>();
        List<Renk> renkler = new List<Renk>();
        List<ayakkabi_data> ayakkabilar = new List<ayakkabi_data>();
        ayakkabi_data urun_sil = new ayakkabi_data();
        ayakkabi_data urun_guncelle = new ayakkabi_data();
        BindingSource source = new BindingSource();
        public Ayakkabi_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///önce üründetay sonra ürün eklenmelidir
            ///eğer ilk ürünü sonra detayını eklersek 
            ///urun hangi detaya ait olacağını bilemez
            ///buda ilişkide hataya sebep olur
            ///son eklenen detayın idsini urun tablosuna göndermemiz gerekecektir
            Urun_Detay urun = new Urun_Detay
            {
                urun_ad = ad_e_tb.Text,
                urun_Ekleme_Tarihi = DateTime.Now.ToString(),
                urun_Temsilcisi = "yok"
            };

            db.Urun_Detay.Add(urun);
            db.SaveChanges();
            db.Urun.Add(new Urun
            {
                detay_ID = urun.ID,
                marka_ID = Convert.ToInt32(marka_e_combo.SelectedValue),
                renk_ID = Convert.ToInt32(renk_e_combo.SelectedValue),
                numara_ID = Convert.ToInt32(numara_e_combo.SelectedValue)
            });
            db.SaveChanges();
            //zorunlu ilişki yaptıgımız için ürünün markası rengi ve numarasını zorunlu kılmış
            // ve ilişkili tablo gereği ilk bir olan tarafa sonra sonsuz olan tarafa olcak
            //sekilde ilerlememiz gerekir
            //marka renk numara detay yok ise urun tabloda bulunamaz
            //var olmayan prop ilişkisi kabul edilemez
            //NULL ile veritabanındaki ilişkili ilgili tablo Id si arasında bir bağlantı
            ///kurulamaz buda veri eksikliği oldugundan hata döndürür
            ///once marka renk numara ve urundetayı oldugundan emin olmalıyız
            ///ve idleri eklenirken doğru olarak girildiğinden boş girilmediğinden emin olmalıyız aksi halde hata almaya devam ederiz
            ///eğer bu tür şeylerle uğraşmadan ilişki kurmak istersek 
            ///diagramdan ilişkideki zorunlulukları kaldırmamız ve modeli update etmemiz gerekecektir
            ///bu durumda NULL girsek bile ilişki yapmaz fakat urunID==urundetayID girdiğimizde ilişki kurmaya devam edecektir

        }
        private void ListeCek_Combo_Aktar()
        {
            var renkler2 = new List<Renk>();
            var markalar2 = new List<Marka>();
            var numaralar2 = new List<Numara>();
            renkler = db.Renk.ToList();
            markalar = db.Marka.ToList();
            numaralar = db.Numara.ToList();
            renkler2.AddRange(renkler);
            markalar2.AddRange(markalar);
            numaralar2.AddRange(numaralar);

            renk_e_combo.DataSource = renkler2;
            renk_g_combo.DataSource = renkler;
            renk_e_combo.DisplayMember = renk_g_combo.DisplayMember = "renk_Ad";
            marka_e_combo.DataSource = markalar2;
            marka_g_combo.DataSource = markalar;
            marka_e_combo.DisplayMember = marka_g_combo.DisplayMember = "marka_Ad";
            numara_e_combo.DataSource = numaralar2;
            numara_g_combo.DataSource = numaralar;
            numara_e_combo.DisplayMember = numara_g_combo.DisplayMember = "numara_";
            marka_g_combo.ValueMember = "ID";
            numara_g_combo.ValueMember = "ID";
            renk_g_combo.ValueMember = "ID";
        }
        private void Ayakkabi_Form_Load(object sender, EventArgs e)
        {

            ListeCek_Combo_Aktar();
            datagrid_operasyonları();
            Work.Log.LogOperations operations = new Work.Log.LogOperations();
            operations.Add(new Marka());



        }
        private void ayakkabilar_doldur() 
        {
            ayakkabilar = (from a in db.Urun
                               /*  // ilişkiyi elle kurmak istersek bunları kullanabiliriz
                              //  join b in db.Urun_Detay on a.detay_ID equals b.ID */
                           where a.aktif==true
                           select new ayakkabi_data 
                           
                           {
                               ID = a.ID,
                               Ürün_Adi = a.Urun_Detay.urun_ad,
                               Marka = a.Marka.marka_Ad,
                               Renk = a.Renk.renk_Ad,
                               Renk_ID = a.renk_ID,
                               Marka_ID = a.marka_ID,
                               Numara_ID = a.numara_ID,
                               Numara = a.Numara.numara_,
                               Fiyat = a.fiyat,
                               Ürün_ID = a.detay_ID,


                           }).ToList();
        }
        private void datagrid_operasyonları()
        {
            //  button1.PerformClick();
            ayakkabilar_doldur();
            source.DataSource = ayakkabilar.ToList();
            gridview_ayarla();


        }
        private void gridview_ayarla() 
        {
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            // set it to false if not needed
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = source;
            //column name list ile gizleme denemeleri ilerde yapılacak 
            dataGridView1.Columns["Marka_ID"].Visible = false;
            dataGridView1.Columns["Numara_ID"].Visible = false;
            dataGridView1.Columns["Renk_ID"].Visible = false;
            dataGridView1.Columns["Ürün_ID"].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            urun_sil = (ayakkabi_data)dataGridView1.CurrentRow.DataBoundItem;
            urun_guncelle = (ayakkabi_data)dataGridView1.CurrentRow.DataBoundItem;
            marka_g_combo.SelectedValue = urun_guncelle.Marka_ID;
            renk_g_combo.SelectedValue = urun_guncelle.Renk_ID;
            numara_g_combo.SelectedValue = urun_guncelle.Numara_ID;
            ad_s_tb.Text = ad_g_tb.Text = urun_sil.Ürün_Adi;
            fiyat_s_tb.Text = fiyat_g_tb.Text = urun_sil.Fiyat + "";
            id_s_tb.Text = id_g_tb.Text = urun_sil.ID.ToString();
            marka_s_tb.Text = urun_sil.Marka;
            numara_s_tb.Text = urun_sil.Numara + "";
            renk_s_tb.Text = urun_sil.Renk;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            Urun_Detay detay = db.Urun_Detay.Find(Convert.ToInt32(urun_sil.Ürün_ID));
            Urun urun = db.Urun.Find(urun_guncelle.ID);
            urun.aktif = false;
          //  db.Urun_Detay.Remove(detay);
         //   db.Urun.Remove(urun);
            db.SaveChanges();
            ayakkabilar_doldur();
            source.DataSource = ayakkabilar;
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            Urun_Detay detay = db.Urun_Detay.Find(urun_guncelle.Ürün_ID);
            Urun urun = db.Urun.Find(urun_guncelle.ID);
            detay.urun_ad = ad_g_tb.Text;
            urun.numara_ID = Convert.ToInt32(numara_g_combo.SelectedValue);
            urun.marka_ID = Convert.ToInt32(marka_g_combo.SelectedValue);
            urun.renk_ID = Convert.ToInt32(renk_g_combo.SelectedValue);
            urun.fiyat = Convert.ToInt32(fiyat_g_tb.Text);
            db.SaveChanges();
            ayakkabilar_doldur();
            source.DataSource = ayakkabilar;
        }
    }
}
