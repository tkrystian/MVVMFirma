using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyKategorieMenuViewModel : JedenViewModel<KategorieMenu>
    {
        public NowyKategorieMenuViewModel() : base("Nowa Kategoria Menu") { }


        public string Nazwa
        {
            get { return item.Nazwa; }
            set { item.Nazwa = value; OnPropertyChanged(() => Nazwa); }
        }

    }
}
