using MVVMFirma.Models.Entities;
using MVVMFirma.Models.Validators;
using System;
using System.ComponentModel;

namespace MVVMFirma.ViewModels
{
    public class NowyRezerwacjeViewModel : JedenViewModel<Rezerwacje>, IDataErrorInfo
    {
        public NowyRezerwacjeViewModel() : base("Nowa Rezerwacja")
        {
            Data = DateTime.Now;
        }


        public DateTime Data
        {
            get { return item.Data; }
            set { item.Data = value; OnPropertyChanged(() => Data); }
        }

        public TimeSpan Godzina
        {
            get { return item.Godzina; }
            set { item.Godzina = value; OnPropertyChanged(() => Godzina); }
        }

        public int LiczbaOsob
        {
            get { return item.LiczbaOsob; }
            set { item.LiczbaOsob = value; OnPropertyChanged(() => LiczbaOsob); }
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
                if (name == "Data")
                    komunikat = BiznesValidator.SprawdzDate(this.Data);
                if (name == "LiczbaOsob")
                    komunikat = BiznesValidator.SprawdzCzyDodatniaLiczba(this.LiczbaOsob);
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (
                this["AdresDostawy"] == null &&
                this["LiczbaOsob"] == null
                )
                return true;
            return false;
        }

        #endregion

    }
}
