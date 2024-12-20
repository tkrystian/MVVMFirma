using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Markup;

namespace MVVMFirma.ViewModels
{
    public class NowyPromocjeViewModel : JedenViewModel<Promocje>, IDataErrorInfo
    {
        public NowyPromocjeViewModel() : base("Nowa Promocja") {
            DataRozpoczecia = DateTime.Now;
            DataZakonczenia = DateTime.Now;
        }


        public string Nazwa
        {
            get { return item.Nazwa; }
            set { item.Nazwa = value; OnPropertyChanged(() => Nazwa); }
        }

        public string Opis
        {
            get { return item.Opis; }
            set { item.Opis = value; OnPropertyChanged(() => Opis); }
        }

        public DateTime DataRozpoczecia
        {
            get { return item.DataRozpoczecia; }
            set { item.DataRozpoczecia = value; OnPropertyChanged(() => DataRozpoczecia); }
        }

        public DateTime DataZakonczenia
        {
            get { return item.DataZakonczenia; }
            set { item.DataZakonczenia = value; OnPropertyChanged(() => DataZakonczenia); }
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
                if (name == "DataRozpoczecia")
                    komunikat = BiznesValidator.SprawdzDate(this.DataRozpoczecia);
                if (name == "DataZakonczenia")
                    komunikat = BiznesValidator.SprawdzDate(this.DataZakonczenia);
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (
                this["Nazwa"] == null &&
                this["DataRozpoczecia"] == null &&
                this["DataZakonczenia"] == null
                )
                return true;
            return false;
        }

        #endregion
    }
}
