
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoe_project.View.Ayakkabi
{
    public partial class Ayakkabi_Anaform : Form
    {
        public List<ayakkabi> ayakkabilar= new List<ayakkabi>();
        ayakkabi secili_ayakkabi = new ayakkabi();
     
        public Ayakkabi_Anaform()
        {
            InitializeComponent();
        }

        private void Ayakkabi_Anaform_Load(object sender, EventArgs e)
        {


            verilerekle();
            guncelle_datagrid();
            secili_ayakkabi = (ayakkabi)dataGridView1.CurrentRow.DataBoundItem;
        }
        //zamanla kutuphane tarzına dönüştürülecek
        private void guncelle_datagrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ayakkabilar;
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            Yeni_Ayakkabi secili_form = new Yeni_Ayakkabi();
            secili_form.ekle_gelen();
            secili_form.ShowDialog();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            Yeni_Ayakkabi secili_form = new Yeni_Ayakkabi();
            secili_form.sil_gelen(secili_ayakkabi);
            secili_form.ShowDialog();
            /*
             //açık formların sayısı
            int count_form = Application.OpenForms.Count;
            MessageBox.Show("Açık olan form sayısı : " + count_form);*/
        }

        private void duzenle_btn_Click(object sender, EventArgs e)
        {
            Yeni_Ayakkabi secili_form = new Yeni_Ayakkabi();
            secili_form.duzenle_gelen(secili_ayakkabi);
            secili_form.ShowDialog();
        }
        private void hizli_ekle(ayakkabi ayakkabi_gelen)
        {
            ayakkabilar.Add(ayakkabi_gelen);
            guncelle_datagrid();

        }
        private void hizli_ekle_2(string adi, int ID, int fiyat, int numara)
        {
            ayakkabi ayakkabi = new ayakkabi();
            ayakkabi.adi = adi;
            ayakkabi.ID = ID;
            ayakkabi.numara = numara;
            ayakkabi.Fiyat = fiyat;
            ayakkabilar.Add(ayakkabi);
        }
        private void verilerekle()

        {
            //  hizli_ekle(new ayakkabi { adi = "XX", cinsiyet = "E", Fiyat = 21, ID = 1, numara =41 });
            hizli_ekle_2(adi: "xx", fiyat: 21, numara: 33, ID: 3);
            ayakkabi ayakkabi = new ayakkabi();
            ayakkabi.adi = "ad1";
            ayakkabi.ID = 1;
            ayakkabi.numara = 11;
            ayakkabi.Fiyat = 111;

            ayakkabilar.Add(ayakkabi);
            ayakkabi = new ayakkabi();
            ayakkabi.adi = "ad2";
            ayakkabi.numara = 22;
            ayakkabi.Fiyat = 222;
            ayakkabi.ID = 2;
            ayakkabilar.Add(ayakkabi);
            ayakkabi = new ayakkabi();
            ayakkabi.adi = "ad3";
            ayakkabi.ID = 3;
            ayakkabi.numara = 33;
            ayakkabi.Fiyat = 333;
            ayakkabilar.Add(ayakkabi);
            ayakkabi = new ayakkabi();
            ayakkabi.adi = "ad4";
            ayakkabi.ID = 4;
            ayakkabi.numara = 44;
            ayakkabi.Fiyat = 444;
            ayakkabilar.Add(ayakkabi);
            guncelle_datagrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.Index < ayakkabilar.Count)
                secili_ayakkabi = (ayakkabi)dataGridView1.CurrentRow.DataBoundItem;
        }
        public void yeni_ayakkabi(ayakkabi ayakkabi_gelen)
        {
            hizli_ekle(ayakkabi_gelen);
        }
        public void sil_ayakkabi(ayakkabi ayakkabi_gelen)
        {
            ayakkabilar.Remove(ayakkabi_gelen);
            guncelle_datagrid();

        }
        public void duzenle_ayakkabi(ayakkabi ayakkabi_gelen)
        {
            //listedeki secili item bağlantısı kopmadan değişiklikleri kaydetme
            secili_ayakkabi.adi = ayakkabi_gelen.adi;
            secili_ayakkabi.Fiyat = ayakkabi_gelen.Fiyat;
            secili_ayakkabi.numara = ayakkabi_gelen.numara;
    
            guncelle_datagrid();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[ayakkabilar.Count-1].Selected = true;
        }
    }
}
