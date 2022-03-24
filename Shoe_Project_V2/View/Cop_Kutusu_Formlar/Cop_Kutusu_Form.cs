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

namespace Shoe_Project_V2.View.Cop_Kutusu_Formlar
{
    public partial class Cop_Kutusu_Form : Form
    {
        Urun urun= new Urun();
        Shoe_DbEntities db = new Shoe_DbEntities();
        List<Log> loglar = new List<Log>();
        BindingSource source = new BindingSource();
        public Cop_Kutusu_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun=(Urun)source.Current;
            urun.aktif =true;
            db.SaveChanges();
            LogCek();
        }

        private void Cop_Kutusu_Form_Load(object sender, EventArgs e)
        {
            LogCek();
        }

     

   
        private void LogCek()

        {
            source.DataSource = db.Urun.Where(x => x.aktif == false).ToList();
            dataGridView1.DataSource = source;
        }

    }
}
