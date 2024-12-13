using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
