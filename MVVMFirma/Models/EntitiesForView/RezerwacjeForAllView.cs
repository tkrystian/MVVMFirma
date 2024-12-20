using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class RezerwacjeForAllView
    {
        public int IdRezerwacji { get; set; }
        public string RestauracjeNazwa { get; set; }
        public string RestauracjeAdres { get; set; }
        public string RestauracjeMiasto { get; set; }
        public String KlienciImie { get; set; }
        public String KlienciNazwisko { get; set; }
        public int KlienciTelefon { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Godzina { get; set; }
        public int LiczbaOsob { get; set; }
    }
}
