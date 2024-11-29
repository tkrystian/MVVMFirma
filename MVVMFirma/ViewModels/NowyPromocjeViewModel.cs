using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyPromocjeViewModel : JedenViewModel<Promocje>
    {
        public NowyPromocjeViewModel() : base("Nowa Promocja") { }


        public string Nazwa
        {
            get { return item.Nazwa; }
            set { item.Nazwa = value; OnPropertyChanged(() => Nazwa); }
        }

        public string Opis
        {
            get { return item.Opis; }
            set { item.Opis = value; OnPropertyChanged(() => Opis); }
        }

        public DateTime DataRozpoczecia
        {
            get { return item.DataRozpoczecia; }
            set { item.DataRozpoczecia = value; OnPropertyChanged(() => DataRozpoczecia); }
        }

        public DateTime DataZakonczenia
        {
            get { return item.DataZakonczenia; }
            set { item.DataZakonczenia = value; OnPropertyChanged(() => DataZakonczenia); }
        }

    }
}
