using MVVMFirma.Models.Entities;
using MVVMFirma.Models.Validators;
using System.ComponentModel;

namespace MVVMFirma.ViewModels
{
    public class NowyKlienciViewModel : JedenViewModel<Klienci>, IDataErrorInfo
    {
        public NowyKlienciViewModel() : base("Nowy Klient") { }


        public string Imie
        {
            get { return item.Imie; }
            set { item.Imie = value; OnPropertyChanged(() => Imie); }
        }

        public string Nazwisko
        {
            get { return item.Nazwisko; }
            set { item.Nazwisko = value; OnPropertyChanged(() => Nazwisko); }
        }

        public int Telefon
        {
            get { return item.Telefon; }
            set { item.Telefon = value; OnPropertyChanged(() => Telefon); }
        }

        public string Email
        {
            get { return item.Email; }
            set { item.Email = value; OnPropertyChanged(() => Email); }
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
                if (name == "Imie")
                    komunikat = StringValidator.SprawdzCzyZaczynaSieZDuzejLitery(this.Imie);
                if (name == "Nazwisko")
                    komunikat = StringValidator.SprawdzCzyZaczynaSieZDuzejLitery(this.Nazwisko);
                if (name == "Telefon")
                    komunikat = BiznesValidator.SprawdzNumerTelefonu(this.Telefon);
                if (name == "Email")
                    komunikat = StringValidator.SprawdzPoprawnoscEmail(this.Email);
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (this["Imie"] == null && this["Nazwisko"] == null && this["Telefon"] == null && this["Email"] == null)
                return true;
            return false;
        }

        #endregion
    }
}
