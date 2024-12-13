using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class PromocjeForAllView
    {
        public int IdPromocji { get; set; }
        public string RestauracjeNazwa { get; set; }
        public string RestauracjeAdres { get; set; }
        public string RestauracjeMiasto { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public DateTime DataRozpoczecia { get; set; }
        public DateTime DataZakonczenia { get; set; }
    }
}
