using Shoe_Project_V2.Model.Model_Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Project_V2.View.Ayakkabi_Formlar
{
    class ayakkabi_data
    {
        public int ID { get; set; }
        [DisplayName("ÜRÜN ADI")]
        public string Ürün_Adi { get; set; }
        public int? Ürün_ID { get; set; }
 
        public string Marka { get; set; }
        public int? Marka_ID { get; set; }
        public string Renk { get; set; }
        public int? Renk_ID { get; set; }
        public int Numara { get; set; }
        public int? Numara_ID { get; set; }
        
        public int? Fiyat { get;set; }




    }
}