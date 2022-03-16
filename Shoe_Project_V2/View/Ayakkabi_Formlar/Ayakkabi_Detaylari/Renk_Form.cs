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
    public partial class Renk_Form : Form
    {
        List<Renk> renkler = new List<Renk>();
        Renk secili_renk = new Renk();
        BindingSource source = new BindingSource();
        Shoe_DbEntities db = new Shoe_DbEntities();
        public Renk_Form()
        {
            InitializeComponent();
        }

        private void Renk_Form_Load(object sender, EventArgs e)
        {
            Verileri_Cek();

        }

        private void Verileri_Cek()
        {
            renkler = db.Renk.ToList();


            source.DataSource = renkler;
            dataGridView1.DataSource = source;
            //hıza direct etki eder
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dataGridView1.RowHeadersVisible = false;
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            db.Renk.Add(new Renk {renk_Ad  = ad_e_tb.Text });
            db.SaveChanges();
            renkler = db.Renk.ToList();
            source.DataSource = renkler;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            secili_renk = (Renk)dataGridView1.CurrentRow.DataBoundItem;
            id_g_tb.Text = id_s_tb.Text = secili_renk.ID.ToString();
            ad_g_tb.Text = ad_s_tb.Text = secili_renk.renk_Ad;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            db.Renk.Remove(secili_renk);
            db.SaveChanges();
            secili_renk = new Renk();
            renkler = db.Renk.ToList();
            source.DataSource = renkler;

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            secili_renk.renk_Ad = ad_g_tb.Text;
            db.SaveChanges();
            secili_renk = new Renk();
            renkler = db.Renk.ToList();
            source.DataSource = renkler;
        }
    }
}
