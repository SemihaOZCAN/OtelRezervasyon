//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezervasyon.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblKasa
    {
        public int KasaID { get; set; }
        public string KasaADI { get; set; }
        public decimal Bakiye { get; set; }
        public decimal Giren { get; set; }
        public decimal Cikan { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
    }
}
