using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyHistoriaZamowienViewModel : JedenViewModel<HistoriaZamowien>
    {
        public NowyHistoriaZamowienViewModel() : base("Nowa Historia Zamowien") { }


        public string Status
        {
            get { return item.Status; }
            set { item.Status = value; OnPropertyChanged(() => Status); }
        }

        public DateTime Data
        {
            get { return item.Data; }
            set { item.Data = value; OnPropertyChanged(() => Data); }
        }

    }
}
