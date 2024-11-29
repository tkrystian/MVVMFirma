using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyKlienciViewModel : JedenViewModel<Klienci>
    {
        public NowyKlienciViewModel() : base("Nowy Klient") { }


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
        
        public string Telefon
        {
            get { return item.Telefon; }
            set { item.Telefon = value; OnPropertyChanged(() => Telefon); }
        }
        
        public string Email
        {
            get { return item.Email; }
            set { item.Email = value; OnPropertyChanged(() => Email); }
        }

    }
}
