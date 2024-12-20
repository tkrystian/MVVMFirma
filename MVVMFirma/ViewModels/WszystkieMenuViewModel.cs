using MVVMFirma.Models.EntitiesForView;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class WszystkieMenuViewModel : WszystkieViewModel<MenuForAllView>
    {
        public WszystkieMenuViewModel() : base("Menu") { }

        public override void load()
        {
            List = new ObservableCollection<MenuForAllView>
               (
                   from menu in restauracjeEntities.Menu
                   select new MenuForAllView
                   {
                       IdMenu = menu.IdMenu,
                       RestauracjeNazwa = menu.Restauracje.Nazwa,
                       RestauracjeAdres = menu.Restauracje.Adres,
                       RestauracjeMiasto = menu.Restauracje.Miasto,
                       Nazwa = menu.Nazwa,
                       Opis = menu.Opis,
                       Cena = menu.Cena,
                   }
               );
        }
    }

}
