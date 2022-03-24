using Shoe_Project_V2.Model.Model_Database;
using Shoe_Project_V2.View;
using Shoe_Project_V2.View.Ayakkabi_Formlar.Ayakkabi_Detaylari;
using Shoe_Project_V2.View.Cop_Kutusu_Formlar;
using Shoe_Project_V2.View.Log_Formlar;
using Shoe_Project_V2.View.Satis_Formlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Project_V2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Shoe_DbEntities db = new Shoe_DbEntities();
            db.Database.CreateIfNotExists();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cop_Kutusu_Form());
   
        }
    }
}
