//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shoe_Project_V2.Model.Model_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            this.Satis_Detay = new HashSet<Satis_Detay>();
        }
    
        public int ID { get; set; }
        public Nullable<int> detay_ID { get; set; }
        public Nullable<int> numara_ID { get; set; }
        public Nullable<int> renk_ID { get; set; }
        public Nullable<int> marka_ID { get; set; }
        public Nullable<int> fiyat { get; set; }
    
        public virtual Marka Marka { get; set; }
        public virtual Renk Renk { get; set; }
        public virtual Urun_Detay Urun_Detay { get; set; }
        public virtual Numara Numara { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis_Detay> Satis_Detay { get; set; }
    }
}
