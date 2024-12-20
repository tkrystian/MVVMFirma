using MVVMFirma.Models.Entities;
using MVVMFirma.Models.Validators;
using System.ComponentModel;

namespace MVVMFirma.ViewModels
{
    public class NowyPozycjeZamowieniaViewModel : JedenViewModel<PozycjeZamowienia>, IDataErrorInfo
    {
        public NowyPozycjeZamowieniaViewModel() : base("Nowa Pozycja Zamowienia") { }


        public int Ilosc
        {
            get { return item.Ilosc; }
            set { item.Ilosc = value; OnPropertyChanged(() => Ilosc); }
        }

        public decimal Cena
        {
            get { return item.Cena; }
            set { item.Cena = value; OnPropertyChanged(() => Cena); }
        }

        #region Validation
        public string Error
        {
            get { return null; }
        }
        public string this[string name]
        {
            get
            {
                string komunikat = null;
                if (name == "Ilosc")
                    komunikat = BiznesValidator.SprawdzCzyDodatniaLiczba(this.Ilosc);
                if (name == "Cena")
                    komunikat = BiznesValidator.SprawdzCzyDodatniaLiczba(this.Cena);
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (this["Ilosc"] == null && this["Cena"] == null)
                return true;
            return false;
        }

        #endregion

    }
}
