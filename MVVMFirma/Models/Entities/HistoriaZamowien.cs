//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMFirma.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoriaZamowien
    {
        public int IdHistorii { get; set; }
        public Nullable<int> IdZamowienia { get; set; }
        public string Status { get; set; }
        public System.DateTime Data { get; set; }
    
        public virtual Zamowienia Zamowienia { get; set; }
    }
}
