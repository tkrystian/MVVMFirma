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
    public class WszystkiePozycjeZamowieniaViewModel : WszystkieViewModelBase<PozycjeZamowienia>
    {
        public WszystkiePozycjeZamowieniaViewModel() : base("Pozycje Zamowienia") { }

    }
    
}