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
