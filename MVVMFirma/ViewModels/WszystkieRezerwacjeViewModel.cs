using MVVMFirma.Models.EntitiesForView;
using System.Collections.ObjectModel;
using System.Linq;

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
