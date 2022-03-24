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

namespace Shoe_Project_V2.View.Log_Formlar
{
    public partial class Log_Form : Form
    {
        Log log= new Log();
        Shoe_DbEntities db = new Shoe_DbEntities();
        List<Log> loglar = new List<Log>();
        BindingSource source = new BindingSource();
        public Log_Form()
        {
            InitializeComponent();
        }

        private void Log_Form_Load(object sender, EventArgs e)
        {
            LogCek();
        }
        private void LogCek() 
        
        {
            source.DataSource = db.Log.ToList();
            dataGridView1.DataSource = source;
        }

     
    }
}
