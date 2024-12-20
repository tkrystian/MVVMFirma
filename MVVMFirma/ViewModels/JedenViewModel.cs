using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    internal class JedenViewModel
    {
    }
}

namespace MVVMFirma.ViewModels
{
    public class JedenViewModel<T> : WorkspaceViewModel where T : class, new()
    {
        #region DB
        protected readonly RestauracjeEntities restauracjeEntities;
        #endregion

        #region Item
        protected readonly T item;
        #endregion

        #region Command
        private BaseCommand _SaveCommand;
        private BaseCommand _CancelCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => SaveAndClose());
                return _SaveCommand;
            }
        }
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                    _CancelCommand = new BaseCommand(() => CancelAndClose());
                return _CancelCommand;
            }
        }
        #endregion

        #region Constructor
        public JedenViewModel(string displayName)
        {
            base.DisplayName = displayName;
            restauracjeEntities = new RestauracjeEntities();
            item = new T();
        }
        #endregion

        #region Helpers
        public void Save()
        {
            restauracjeEntities.Set<T>().Add(item);
            restauracjeEntities.SaveChanges();
        }
        public void SaveAndClose()
        {
            if (IsValid())
            {
                Save();
                OnRequestClose();
            }
        }
        
        public void CancelAndClose()
        {
            if (IsValid())
            {
                OnRequestClose();
            }
        }
        #endregion

        #region Validation
        public virtual bool IsValid()
        {
            return true;
        }
        #endregion
    }
}
