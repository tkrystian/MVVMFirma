using MVVMFirma.Models.Entities;
using MVVMFirma.Models.Validators;
using System.ComponentModel;

namespace MVVMFirma.ViewModels
{
    public class NowyPracownicyViewModel : JedenViewModel<Pracownicy>, IDataErrorInfo
    {
        public NowyPracownicyViewModel() : base("Nowy Pracownik") { }


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

        public string Stanowisko
        {
            get { return item.Stanowisko; }
            set { item.Stanowisko = value; OnPropertyChanged(() => Stanowisko); }
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
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (this["Imie"] == null && this["Nazwisko"] == null)
                return true;
            return false;
        }

        #endregion

    }
}
