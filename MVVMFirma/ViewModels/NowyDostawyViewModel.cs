﻿using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyDostawyViewModel : JedenViewModel<Dostawy>
    {
        public NowyDostawyViewModel() : base("Nowa Dostawa") { }

        
        public string AdresDostawy
        {
            get { return item.AdresDostawy; }
            set { item.AdresDostawy = value; OnPropertyChanged(() => AdresDostawy); }
        }

        public DateTime DataDostawy
        {
            get { return item.DataDostawy; }
            set { item.DataDostawy = value; OnPropertyChanged(() => DataDostawy); }
        }

    }
}