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
                       IdZamowienia=zamowienia.IdZamowienia,
                       RestauracjeNazwa=zamowienia.Restauracje.Nazwa,
                       RestauracjeAdres=zamowienia.Restauracje.Adres,
                       RestauracjeMiasto=zamowienia.Restauracje.Miasto,
                       KlienciImie=zamowienia.Klienci.Imie,
                       KlienciNazwisko=zamowienia.Klienci.Nazwisko,
                       KlienciTelefon=zamowienia.Klienci.Telefon,
                       Data=zamowienia.Data,
                       Suma=zamowienia.Suma,
                   }
               );
        }

    }

}
