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

namespace Shoe_Project_V2.View.Ayakkabi_Formlar.Ayakkabi_Detaylari
{
    public partial class Numara_Form : Form
    {

        List<Numara> numaralar = new List<Numara>();
        Numara secili_numara = new Numara();
        BindingSource source = new BindingSource();
        Shoe_DbEntities db = new Shoe_DbEntities();
        public Numara_Form()
        {
            InitializeComponent();
        }

        private void Numara_Form_Load(object sender, EventArgs e)
        {
            Verileri_Cek();

        }

        private void Verileri_Cek()
        {
            numaralar = db.Numara.ToList();


            source.DataSource = numaralar;
            dataGridView1.DataSource = source;
            //hıza direct etki eder
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dataGridView1.RowHeadersVisible = false;
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            db.Numara.Add(new Numara { numara_ = Convert.ToInt32(ad_e_tb.Text) });
            db.SaveChanges();
            numaralar = db.Numara.ToList();
            source.DataSource = numaralar;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            secili_numara = (Numara)dataGridView1.CurrentRow.DataBoundItem;
            id_g_tb.Text = id_s_tb.Text = secili_numara.ID.ToString();
            ad_g_tb.Text = ad_s_tb.Text = secili_numara.numara_.ToString();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            db.Numara.Remove(secili_numara);
            db.SaveChanges();
            secili_numara = new Numara();
            numaralar = db.Numara.ToList();
            source.DataSource = numaralar;

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            secili_numara.numara_ = Convert.ToInt32( ad_g_tb.Text);
            db.SaveChanges();
            secili_numara = new Numara();
            numaralar = db.Numara.ToList();
            source.DataSource = numaralar;
        }
    }
}
