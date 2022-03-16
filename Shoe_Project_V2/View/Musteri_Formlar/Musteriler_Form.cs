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

namespace Shoe_Project_V2.View.Musteri_Formlar
{
    public partial class Musteriler_Form : Form
    {
        List<Musteri> musteriler = new List<Musteri>();
        Musteri secili_musteri = new Musteri();
        Shoe_DbEntities db = new Shoe_DbEntities();
        BindingSource source = new BindingSource();

        public Musteriler_Form()
        {
            InitializeComponent();
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            Verileri_Cek();

        }

        private void Verileri_Cek()
        {
            musteriler = db.Musteri.ToList();


            source.DataSource = musteriler;
            dataGridView1.DataSource = source;
            //hıza direct etki eder
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["Satislar"].Visible = false;
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            db.Musteri.Add(new Musteri { musteri_AD = ad_e_tb.Text ,musteri_Tel="xxxx",musteri_Adres="xy"});
            db.SaveChanges();
            musteriler = db.Musteri.ToList();
            source.DataSource = musteriler;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            secili_musteri = (Musteri)dataGridView1.CurrentRow.DataBoundItem;
            id_g_tb.Text = id_s_tb.Text = secili_musteri.ID.ToString();
            ad_g_tb.Text = ad_s_tb.Text = secili_musteri.musteri_AD;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            db.Musteri.Remove(secili_musteri);
            db.SaveChanges();
            secili_musteri = new Musteri();
            musteriler = db.Musteri.ToList();
            source.DataSource = musteriler;

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            secili_musteri.musteri_AD = ad_g_tb.Text;
            db.SaveChanges();
            secili_musteri = new Musteri();
            musteriler = db.Musteri.ToList();
            source.DataSource = musteriler;
        }
    }
}
