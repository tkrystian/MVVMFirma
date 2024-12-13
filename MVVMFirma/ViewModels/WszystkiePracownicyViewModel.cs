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
    public class WszystkiePracownicyViewModel : WszystkieViewModel<PracownicyForAllView>
    {
        public WszystkiePracownicyViewModel() : base("Pracownicy") { }

        public override void load()
        {
            List = new ObservableCollection<PracownicyForAllView>
               (
                   from pracownicy in restauracjeEntities.Pracownicy
                   select new PracownicyForAllView
                   {
                       IdPracownika = pracownicy.IdPracownika,
                       RestauracjeNazwa = pracownicy.Restauracje.Nazwa,
                       RestauracjeAdres = pracownicy.Restauracje.Adres,
                       RestauracjeMiasto = pracownicy.Restauracje.Miasto,
                       Imie = pracownicy.Imie,
                       Nazwisko = pracownicy.Nazwisko,
                       Stanowisko = pracownicy.Stanowisko,
                   }
               );
        }
    }

}
