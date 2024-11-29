using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowaRestauracjaViewModel : JedenViewModel<Restauracje>
    {
        public NowaRestauracjaViewModel() : base("Nowa Restauracja") { }

        public string Nazwa
        {
            get { return item.Nazwa; }
            set { item.Nazwa = value; OnPropertyChanged(() => Nazwa); }
        }

        public string Adres
        {
            get { return item.Adres; }
            set { item.Adres = value; OnPropertyChanged(() => Adres); }
        }

        public string Miasto
        {
            get { return item.Miasto; }
            set { item.Miasto = value; OnPropertyChanged(() => Miasto); }
        }

        public string Telefon
        {
            get { return item.Telefon; }
            set { item.Telefon = value; OnPropertyChanged(() => Telefon); }
        }

        public string GodzinyOtwarcia
        {
            get { return item.GodzinyOtwarcia; }
            set { item.GodzinyOtwarcia = value; OnPropertyChanged(() => GodzinyOtwarcia); }
        }
    }
}
