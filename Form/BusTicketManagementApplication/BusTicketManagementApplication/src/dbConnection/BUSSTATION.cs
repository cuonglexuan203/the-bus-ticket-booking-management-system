//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusTicketManagementApplication.src.dbConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class BUSSTATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BUSSTATION()
        {
            this.BUSROUTEs = new HashSet<BUSROUTE>();
            this.BUSROUTEs1 = new HashSet<BUSROUTE>();
            this.BUSROUTEs2 = new HashSet<BUSROUTE>();
        }
    
        public string id_bus_station { get; set; }
        public string id_place { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int bus_capacity { get; set; }
        public Nullable<int> count_current_bus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUSROUTE> BUSROUTEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUSROUTE> BUSROUTEs1 { get; set; }
        public virtual PLACE PLACE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUSROUTE> BUSROUTEs2 { get; set; }
    }
}