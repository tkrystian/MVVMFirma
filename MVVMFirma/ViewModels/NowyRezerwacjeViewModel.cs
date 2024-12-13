using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyRezerwacjeViewModel : JedenViewModel<Rezerwacje>
    {
        public NowyRezerwacjeViewModel() : base("Nowa Rezerwacja") {
            Data = DateTime.Now;
        }


        public DateTime Data
        {
            get { return item.Data; }
            set { item.Data = value; OnPropertyChanged(() => Data); }
        }

        public TimeSpan Godzina
        {
            get { return item.Godzina; }
            set { item.Godzina = value; OnPropertyChanged(() => Godzina); }
        }

        public int LiczbaOsob
        {
            get { return item.LiczbaOsob; }
            set { item.LiczbaOsob = value; OnPropertyChanged(() => LiczbaOsob); }
        }

    }
}
