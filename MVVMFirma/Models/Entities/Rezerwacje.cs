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
    
    public partial class Rezerwacje
    {
        public int IdRezerwacji { get; set; }
        public Nullable<int> IdRestauracji { get; set; }
        public Nullable<int> IdKlienta { get; set; }
        public System.DateTime Data { get; set; }
        public System.TimeSpan Godzina { get; set; }
        public int LiczbaOsob { get; set; }
    
        public virtual Restauracje Restauracje { get; set; }
    }
}
