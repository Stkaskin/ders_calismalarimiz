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
    public partial class Marka_Form : Form
    {
        List<Marka> markalar = new List<Marka>();
        Marka secili_marka = new Marka();
        Shoe_DbEntities db = new Shoe_DbEntities();
        BindingSource source = new BindingSource();

        public Marka_Form()
        {
            InitializeComponent();
        }
        private void Marka_Form_Load(object sender, EventArgs e)
        {
            Verileri_Cek();
           
        }

        private void Verileri_Cek()
        {
            markalar = db.Marka.ToList();
            
       
            source.DataSource = markalar;
            dataGridView1.DataSource = source;
            //hıza direct etki eder
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dataGridView1.RowHeadersVisible = false;
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            db.Marka.Add(new Marka {marka_Ad=ad_e_tb.Text });
            db.SaveChanges();
            markalar = db.Marka.ToList();
            source.DataSource = markalar;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            secili_marka = (Marka)dataGridView1.CurrentRow.DataBoundItem;
            id_g_tb.Text = id_s_tb.Text = secili_marka.ID.ToString();
            ad_g_tb.Text = ad_s_tb.Text = secili_marka.marka_Ad;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            db.Marka.Remove(secili_marka);
            db.SaveChanges();
            secili_marka = new Marka();
            markalar = db.Marka.ToList();
            source.DataSource = markalar;

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            secili_marka.marka_Ad = ad_g_tb.Text;
            db.SaveChanges();
            secili_marka = new Marka();
            markalar = db.Marka.ToList();
            source.DataSource = markalar;
        }
    }
}
