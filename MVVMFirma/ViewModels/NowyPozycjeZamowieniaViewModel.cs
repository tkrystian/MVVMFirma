using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyPozycjeZamowieniaViewModel : JedenViewModel<PozycjeZamowienia>
    {
        public NowyPozycjeZamowieniaViewModel() : base("Nowa Opinia") { }


        public int Ilosc
        {
            get { return item.Ilosc; }
            set { item.Ilosc = value; OnPropertyChanged(() => Ilosc); }
        }

        public decimal Cena
        {
            get { return item.Cena; }
            set { item.Cena = value; OnPropertyChanged(() => Cena); }
        }

    }
}
