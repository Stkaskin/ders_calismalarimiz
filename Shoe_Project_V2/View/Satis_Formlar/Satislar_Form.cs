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

namespace Shoe_Project_V2.View.Satis_Formlar
{
    public partial class Satislar_Form : Form
    {
        List<Satislar> satislar = new List<Satislar>();
        Satislar secili_satis = new Satislar();
        Shoe_DbEntities db = new Shoe_DbEntities();
        BindingSource source = new BindingSource();

        public Satislar_Form()
        {
            InitializeComponent();
        }
        private void Satislar_Form_Load(object sender, EventArgs e)
        {
            Verileri_Cek();

        }

        private void Verileri_Cek()
        {
            satislar = db.Satislar.ToList();


            source.DataSource = satislar;
            dataGridView1.DataSource = source;
            //hıza direct etki eder
            dataGridView1.Columns[nameof(secili_satis.Musteri)].Visible = false;
            dataGridView1.Columns[nameof(secili_satis.Satis_Detay)].Visible = false;

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dataGridView1.RowHeadersVisible = false;
        }

       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            secili_satis = (Satislar)dataGridView1.CurrentRow.DataBoundItem;
            //.Text = id_s_tb.Text = secili_satis.ID.ToString();
         //   ad_g_tb.Text = ad_s_tb.Text = secili_satis.marka_Ad;
        }

        private void yeni_btn_Click(object sender, EventArgs e)
        {
            Form form = new Satis_Detay_Form();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Satis_Detay_Form form = new Satis_Detay_Form();
            form.Cek_Satislar(secili_satis);
            form.ShowDialog();
        }
        /*
*  private void ekle_btn_Click(object sender, EventArgs e)
{
//   db.Satislar.Add(new Satislar { tutar = ad_e_tb.Text });
  db.SaveChanges();
  satislar = db.Satislar.ToList();
  source.DataSource = satislar;


}
private void sil_btn_Click(object sender, EventArgs e)
{
  db.Satislar.Remove(secili_satis);
  db.SaveChanges();
  secili_satis = new Satislar();
  satislar = db.Satislar.ToList();
  source.DataSource = satislar;

}

private void guncelle_btn_Click(object sender, EventArgs e)
{
//    secili_satis.marka_Ad = ad_g_tb.Text;
  db.SaveChanges();
  secili_satis = new Satislar();
  satislar = db.Satislar.ToList();
  source.DataSource = satislar;
}*/
    }
}
