//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orsimu
{
    using System;
    using System.Collections.Generic;
    
    public partial class invertory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public invertory()
        {
            this.i_fegyver = new HashSet<i_fegyver>();
        }
    
        public int inv_Id { get; set; }
        public int kar_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<i_fegyver> i_fegyver { get; set; }
        public virtual Karakter Karakter { get; set; }
    }
}
