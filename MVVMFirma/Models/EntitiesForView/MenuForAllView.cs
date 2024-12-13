using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class MenuForAllView
    {
        public int IdMenu { get; set; }
        public string RestauracjeNazwa { get; set; }
        public string RestauracjeAdres { get; set; }
        public string RestauracjeMiasto { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public decimal Cena { get; set; }
    }
}
