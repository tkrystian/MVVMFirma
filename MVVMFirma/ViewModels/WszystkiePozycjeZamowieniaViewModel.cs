using MVVMFirma.Models.EntitiesForView;
using System.Collections.ObjectModel;
using System.Linq;

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
                       ZamowieniaId = pozycjeZamowienia.Zamowienia != null ? pozycjeZamowienia.Zamowienia.IdZamowienia : 0,
                       MenuNazwa = pozycjeZamowienia != null ? pozycjeZamowienia.Menu.Nazwa : "",
                       MenuCena = pozycjeZamowienia.Menu != null ? pozycjeZamowienia.Menu.Cena : 0,
                       Ilosc = pozycjeZamowienia.Ilosc,
                       Cena = pozycjeZamowienia.Cena,
                   }
               );
        }
    }

}
