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
    public class NowyDostawyViewModel : JedenViewModel<Dostawy>, IDataErrorInfo
    {
        public NowyDostawyViewModel() : base("Nowa Dostawa") {
            DataDostawy = DateTime.Now;
        }

        
        public string AdresDostawy
        {
            get { return item.AdresDostawy; }
            set { item.AdresDostawy = value; OnPropertyChanged(() => AdresDostawy); }
        }

        public DateTime DataDostawy
        {
            get { return item.DataDostawy; }
            set { item.DataDostawy = value; OnPropertyChanged(() => DataDostawy); }
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
                if (name == "AdresDostawy")
                    komunikat = StringValidator.SprawdzCzyZaczynaSieZDuzejLitery(this.AdresDostawy);
                if (name == "DataDostawy")
                    komunikat = BiznesValidator.SprawdzDate(this.DataDostawy);
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (this["AdresDostawy"] == null && this["DataDostawy"] == null)
                return true;
            return false;
        }

        #endregion
    }

}
