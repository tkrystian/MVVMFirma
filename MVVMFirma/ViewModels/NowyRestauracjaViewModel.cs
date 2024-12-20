using MVVMFirma.Models.Entities;
using MVVMFirma.Models.Validators;
using System.ComponentModel;

namespace MVVMFirma.ViewModels
{
    public class NowyRestauracjaViewModel : JedenViewModel<Restauracje>, IDataErrorInfo
    {
        public NowyRestauracjaViewModel() : base("Nowa Restauracja") { }

        public string Nazwa
        {
            get { return item.Nazwa; }
            set { item.Nazwa = value; OnPropertyChanged(() => Nazwa); }
        }

        public string Adres
        {
            get { return item.Adres; }
            set { item.Adres = value; OnPropertyChanged(() => Adres); }
        }

        public string Miasto
        {
            get { return item.Miasto; }
            set { item.Miasto = value; OnPropertyChanged(() => Miasto); }
        }

        public int Telefon
        {
            get { return item.Telefon; }
            set { item.Telefon = value; OnPropertyChanged(() => Telefon); }
        }

        public string GodzinyOtwarcia
        {
            get { return item.GodzinyOtwarcia; }
            set { item.GodzinyOtwarcia = value; OnPropertyChanged(() => GodzinyOtwarcia); }
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
                if (name == "Nazwa")
                    komunikat = StringValidator.SprawdzCzyZaczynaSieZDuzejLitery(this.Nazwa);
                if (name == "Adres")
                    komunikat = StringValidator.SprawdzCzyZaczynaSieZDuzejLitery(this.Adres);
                if (name == "Miasto")
                    komunikat = StringValidator.SprawdzCzyZaczynaSieZDuzejLitery(this.Miasto);
                if (name == "Telefon")
                    komunikat = BiznesValidator.SprawdzNumerTelefonu(this.Telefon);
                //if (name == "GodzinyOtwarcia")
                //    komunikat = BiznesValidator.SprawdzGodziny(this.GodzinyOtwarcia);
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (
                this["Nazwa"] == null &&
                this["Adres"] == null &&
                this["Miasto"] == null &&
                this["Telefon"] == null
                )
                return true;
            return false;
        }

        #endregion
    }
}
