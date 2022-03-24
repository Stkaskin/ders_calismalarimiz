using Shoe_Project_V2.Model.Model_Database;
using Shoe_Project_V2.Work.Log;
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
            Marka marka = new Marka { marka_Ad = ad_e_tb.Text };
           db.Marka.Add(marka);
           db.SaveChanges();
            markalar = db.Marka.ToList();
            source.DataSource = markalar;
            LogOperations_Worst log = new LogOperations_Worst();
            log.Yeni(1, "Marka", marka.ID);



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            secili_marka = (Marka)dataGridView1.CurrentRow.DataBoundItem;
            id_g_tb.Text = id_s_tb.Text = secili_marka.ID.ToString();
            ad_g_tb.Text = ad_s_tb.Text = secili_marka.marka_Ad;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            int id_Tut = secili_marka.ID;
            db.Marka.Remove(secili_marka);
            db.SaveChanges();
            secili_marka = new Marka();
            markalar = db.Marka.ToList();
            source.DataSource = markalar;
            LogOperations_Worst log = new LogOperations_Worst();
            log.Yeni(3, "Marka", id_Tut);

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            secili_marka.marka_Ad = ad_g_tb.Text;
            db.SaveChanges();
            secili_marka = new Marka();
            markalar = db.Marka.ToList();
            source.DataSource = markalar;
            LogOperations_Worst log = new LogOperations_Worst();
            log.Yeni(2, "Marka", secili_marka.ID);
        }
    }
}
