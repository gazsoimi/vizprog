//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrSzimulator2000
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lakhely
    {
        public int LakhelyId { get; set; }
        public string Nev { get; set; }
    
        public virtual Szornyek Szornyek { get; set; }
    }
}
