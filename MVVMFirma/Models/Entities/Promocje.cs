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
    
    public partial class Promocje
    {
        public int IdPromocji { get; set; }
        public Nullable<int> IdRestauracji { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public System.DateTime DataRozpoczecia { get; set; }
        public System.DateTime DataZakonczenia { get; set; }
    
        public virtual Restauracje Restauracje { get; set; }
    }
}