using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;

namespace MVVMFirma.ViewModels
{
    public class WszystkieRezerwacjeViewModel : WszystkieViewModel<RezerwacjeForAllView>
    {
        public WszystkieRezerwacjeViewModel() : base("Rezerwacje") { }

        public override void load()
        {
            List = new ObservableCollection<RezerwacjeForAllView>
               (
                   from rezerwacje in restauracjeEntities.Rezerwacje
                   select new RezerwacjeForAllView
                   {
                       IdRezerwacji = rezerwacje.IdRezerwacji,
                       RestauracjeNazwa = rezerwacje.Restauracje.Nazwa,
                       RestauracjeAdres = rezerwacje.Restauracje.Adres,
                       RestauracjeMiasto = rezerwacje.Restauracje.Miasto,
                       KlienciImie = rezerwacje.Klienci.Imie,
                       KlienciNazwisko = rezerwacje.Klienci.Nazwisko,
                       KlienciTelefon = rezerwacje.Klienci.Telefon,
                       Data = rezerwacje.Data,
                       Godzina = rezerwacje.Godzina,
                       LiczbaOsob = rezerwacje.LiczbaOsob,
                   }
               );
        }

    }
 
}
