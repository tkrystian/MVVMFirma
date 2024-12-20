using MVVMFirma.Models.EntitiesForView;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class WszystkiePromocjeViewModel : WszystkieViewModel<PromocjeForAllView>
    {
        public WszystkiePromocjeViewModel() : base("Promocje") { }

        public override void load()
        {
            List = new ObservableCollection<PromocjeForAllView>
               (
                   from promocje in restauracjeEntities.Promocje
                   select new PromocjeForAllView
                   {
                       IdPromocji = promocje.IdPromocji,
                       RestauracjeNazwa = promocje.Restauracje.Nazwa,
                       RestauracjeAdres = promocje.Restauracje.Adres,
                       RestauracjeMiasto = promocje.Restauracje.Miasto,
                       Nazwa = promocje.Nazwa,
                       Opis = promocje.Opis,
                       DataRozpoczecia = promocje.DataRozpoczecia,
                       DataZakonczenia = promocje.DataZakonczenia,

                   }
               );
        }

    }

}
