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
    
    public partial class Urun_Detay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun_Detay()
        {
            this.Urun = new HashSet<Urun>();
        }
    
        public int ID { get; set; }
        public string urun_ad { get; set; }
        public string urun_Ekleme_Tarihi { get; set; }
        public string urun_Temsilcisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urun> Urun { get; set; }
    }
}