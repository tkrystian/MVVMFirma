﻿using System;

namespace MVVMFirma.Models.EntitiesForView
{
    public class PozycjeZamowieniaForAllView
    {
        public int IdPozycjaZamowienia { get; set; }
        public int ZamowieniaId { get; set; }
        public string MenuNazwa { get; set; }
        public Decimal MenuCena { get; set; }
        public int Ilosc { get; set; }
        public Decimal Cena { get; set; }

    }
}
