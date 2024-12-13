using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class WszystkiePozycjeZamowieniaViewModel : WszystkieViewModel<PozycjeZamowieniaForAllView>
    {
        public WszystkiePozycjeZamowieniaViewModel() : base("Pozycje Zamowienia") { }

        public override void load()
        {
            List = new ObservableCollection<PozycjeZamowieniaForAllView>
               (
                   from pozycjeZamowienia in restauracjeEntities.PozycjeZamowienia
                   select new PozycjeZamowieniaForAllView
                   {
                       IdPozycjaZamowienia = pozycjeZamowienia.IdPozycjaZamowienia,
                       ZamowieniaId = pozycjeZamowienia.Zamowienia.IdZamowienia,
                       MenuNazwa = pozycjeZamowienia.Menu.Nazwa,
                       MenuCena = pozycjeZamowienia.Menu.Cena,
                       Ilosc = pozycjeZamowienia.Ilosc,
                       Cena = pozycjeZamowienia.Cena,
                   }
               );
        }
    }
    
}
