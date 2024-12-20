using System;

namespace MVVMFirma.Models.EntitiesForView
{
    public class DostawyForAllView
    {
        public int IdDostawy { get; set; }
        public DateTime ZamowieniaData { get; set; }
        public decimal ZamowieniaSuma { get; set; }
        public string AdresDostawy { get; set; }
        public DateTime DataDostawy { get; set; }

    }
}
