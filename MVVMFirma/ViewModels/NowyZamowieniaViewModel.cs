using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyZamowieniaViewModel : JedenViewModel<Zamowienia>
    {
        public NowyZamowieniaViewModel() : base("Nowe Zamowienie") {
            Data = DateTime.Now;
        }


        public DateTime Data
        {
            get { return item.Data; }
            set { item.Data = value; OnPropertyChanged(() => Data); }
        }

        public decimal Suma
        {
            get { return item.Suma; }
            set { item.Suma = value; OnPropertyChanged(() => Suma); }
        }
    }
}
