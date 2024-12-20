using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class WszystkieDostawyViewModel : WszystkieViewModel<DostawyForAllView>
    {
        public WszystkieDostawyViewModel() : base("Dostawy") { }

        public override void load()
        {
            List = new ObservableCollection<DostawyForAllView>
               (
                   from dostawy in restauracjeEntities.Dostawy
                   select new DostawyForAllView
                   {
                       IdDostawy = dostawy.IdDostawy,
                       ZamowieniaData = dostawy.Zamowienia != null ? dostawy.Zamowienia.Data : default(DateTime),
                       ZamowieniaSuma = dostawy.Zamowienia != null ? dostawy.Zamowienia.Suma : 0,
                       AdresDostawy = dostawy.AdresDostawy,
                       DataDostawy = dostawy.DataDostawy,
                   }
               );
        }
    }
}
