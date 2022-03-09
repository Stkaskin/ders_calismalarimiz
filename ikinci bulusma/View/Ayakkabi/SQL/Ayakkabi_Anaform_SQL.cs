using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shoe_project.Classlar;
using System.Windows.Forms;
using shoe_project.Work.Sql_Operasyonları;

namespace shoe_project.View.Ayakkabi.SQL
{
    public partial class Ayakkabi_Anaform_SQL : Form
    {
        public Ayakkabi_Anaform_SQL()
        {
            InitializeComponent();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            Classlar.ayakkabi ayakkabi = new Classlar.ayakkabi();
            ayakkabi.markaID = 1;
            ayakkabi.numaraID = 1;
            ayakkabi.renkID = 1;
            ayakkabi.adiID = 1;
            ayakkabi.Ekle();
            MessageBox.Show("Eklendi");
         
        }
        void getir() 
        {
            Komut sql = new Komut();
            string komutum = "Select * from ayakkabi_T";
            sql.Sorgu_Calistir(komutum);
            dataGridView1.DataSource = null; 
        }
    }
}
