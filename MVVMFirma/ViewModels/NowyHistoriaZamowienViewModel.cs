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
    public class NowyHistoriaZamowienViewModel : JedenViewModel<HistoriaZamowien>, IDataErrorInfo
    {
        public NowyHistoriaZamowienViewModel() : base("Nowa Historia Zamowien") {
            Data = DateTime.Now;
        }


        public string Status
        {
            get { return item.Status; }
            set { item.Status = value; OnPropertyChanged(() => Status); }
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
