using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Project_V2.Work.Interface
{
    interface ILog
    {
        string table_name { get; set; }
        
    }
}

/*public void genelegoreyazim(int islemkodu, string tabloadi, int tbl_id)
{
    db.Log.Add(new Model.Model_Database.Log { islem = islemkodu, tbl_name = tabloadi, tbl_id = tbl_id });
    db.SaveChanges();
}*/