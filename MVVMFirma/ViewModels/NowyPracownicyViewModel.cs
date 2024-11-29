using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyPracownicyViewModel : JedenViewModel<Pracownicy>
    {
        public NowyPracownicyViewModel() : base("Nowy Pracownik") { }


        public string Imie
        {
            get { return item.Imie; }
            set { item.Imie = value; OnPropertyChanged(() => Imie); }
        }

        public string Nazwisko
        {
            get { return item.Nazwisko; }
            set { item.Nazwisko = value; OnPropertyChanged(() => Nazwisko); }
        }
        
        public string Stanowisko
        {
            get { return item.Stanowisko; }
            set { item.Stanowisko = value; OnPropertyChanged(() => Stanowisko); }
        }

    }
}
