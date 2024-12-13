using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyOpinieViewModel : JedenViewModel<Opinie>
    {
        public NowyOpinieViewModel() : base("Nowa Opinia") {
            Data = DateTime.Now;
        }


        public int? Ocena
        {
            get { return item.Ocena; }
            set { item.Ocena = value; OnPropertyChanged(() => Ocena); }
        }

        public string Komentarz
        {
            get { return item.Komentarz; }
            set { item.Komentarz = value; OnPropertyChanged(() => Komentarz); }
        }

        public DateTime Data
        {
            get { return item.Data; }
            set { item.Data = value; OnPropertyChanged(() => Data); }
        }

    }
}
