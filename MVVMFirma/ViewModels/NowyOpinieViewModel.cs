using MVVMFirma.Models.Entities;
using MVVMFirma.Models.Validators;
using System;
using System.ComponentModel;

namespace MVVMFirma.ViewModels
{
    public class NowyOpinieViewModel : JedenViewModel<Opinie>, IDataErrorInfo
    {
        public NowyOpinieViewModel() : base("Nowa Opinia")
        {
            Data = DateTime.Now;
        }


        public int? Ocena
        {
            get { return item.Ocena; }
            set { item.Ocena = value; OnPropertyChanged(() => Ocena); }
        }

        public string Komentarz
        {
            get { return item.Komentarz; }
            set { item.Komentarz = value; OnPropertyChanged(() => Komentarz); }
        }

        public DateTime Data
        {
            get { return item.Data; }
            set { item.Data = value; OnPropertyChanged(() => Data); }
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
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (this["Data"] == null)
                return true;
            return false;
        }

        #endregion

    }
}
