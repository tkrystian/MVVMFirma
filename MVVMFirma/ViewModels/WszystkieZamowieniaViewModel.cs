using MVVMFirma.Models.EntitiesForView;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class WszystkieZamowieniaViewModel : WszystkieViewModel<ZamowieniaForAllView>
    {
        public WszystkieZamowieniaViewModel() : base("Zamowienia") { }

        public override void load()
        {
            List = new ObservableCollection<ZamowieniaForAllView>
               (
                   from zamowienia in restauracjeEntities.Zamowienia
                   select new ZamowieniaForAllView
                   {
                       IdZamowienia = zamowienia.IdZamowienia,
                       RestauracjeNazwa = zamowienia.Restauracje.Nazwa,
                       RestauracjeAdres = zamowienia.Restauracje.Adres,
                       RestauracjeMiasto = zamowienia.Restauracje.Miasto,
                       KlienciImie = zamowienia.Klienci.Imie,
                       KlienciNazwisko = zamowienia.Klienci.Nazwisko,
                       KlienciTelefon = zamowienia.Klienci.Telefon,
                       Data = zamowienia.Data,
                       Suma = zamowienia.Suma,
                   }
               );
        }

    }

}
