//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.orders = new HashSet<order>();
        }
    
        public int id { get; set; }
        public string product_id { get; set; }
        public string catalog_id { get; set; }
        public string product_name { get; set; }
        public string image_main { get; set; }
        public string image_sub { get; set; }
        public Nullable<int> price { get; set; }
        public string content { get; set; }
        public Nullable<int> discount { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> quantity_sold { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> created { get; set; }
    
        public virtual catalog catalog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
