﻿using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{

    public class WszystkieKlienciViewModel : WszystkieViewModel<Klienci>
    {
        public WszystkieKlienciViewModel() : base("Klienci") { }

    }
}
