﻿using MVVMFirma.Models.EntitiesForView;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class WszystkieOpinieViewModel : WszystkieViewModel<OpinieForAllView>
    {
        public WszystkieOpinieViewModel() : base("Opinie") { }

        public override void load()
        {
            List = new ObservableCollection<OpinieForAllView>
               (
                   from opinie in restauracjeEntities.Opinie
                   select new OpinieForAllView
                   {
                       IdOpinii = opinie.IdOpinii,
                       RestauracjeNazwa = opinie.Restauracje.Nazwa,
                       RestauracjeAdres = opinie.Restauracje.Adres,
                       RestauracjeMiasto = opinie.Restauracje.Miasto,
                       KlienciImie = opinie.Klienci.Imie,
                       KlienciNazwisko = opinie.Klienci.Nazwisko,
                       Ocena = opinie.Ocena,
                       Komentarz = opinie.Komentarz,
                       Data = opinie.Data,
                   }
               );

        }


    }

}
