using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyZamowieniaViewModel : JedenViewModel<Zamowienia>, IDataErrorInfo
    {
        public NowyZamowieniaViewModel() : base("Nowe Zamowienie") {
            Data = DateTime.Now;
        }


        public DateTime Data
        {
            get { return item.Data; }
            set { item.Data = value; OnPropertyChanged(() => Data); }
        }

        public decimal Suma
        {
            get { return item.Suma; }
            set { item.Suma = value; OnPropertyChanged(() => Suma); }
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
                if (name == "Suma")
                    komunikat = BiznesValidator.SprawdzCzyDodatniaLiczba(this.Suma);
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (this["Data"] == null && this["Suma"] == null)
                return true;
            return false;
        }

        #endregion
    }
}
