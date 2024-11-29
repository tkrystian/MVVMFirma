using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class WszystkieViewModelBase<T> : WorkspaceViewModel where T : class
    {
        #region DB
        protected readonly RestauracjeEntities restauracjeEntities;
        #endregion

        #region LoadCommand
        private BaseCommand _LoadCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                    _LoadCommand = new BaseCommand(() => load());
                return _LoadCommand;
            }
        }
        #endregion

        #region AddCommand
        private BaseCommand _AddCommand;
        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                    _AddCommand = new BaseCommand(() => add());
                return _AddCommand;
            }
        }
        #endregion

        #region List
        private ObservableCollection<T> _List;
        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                    load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }
        #endregion

        #region Constructor
        public WszystkieViewModelBase(string displayName)
        {
            base.DisplayName = displayName;
            restauracjeEntities = new RestauracjeEntities();
        }
        #endregion

        #region Helpers
        private void load()
        {
            List = new ObservableCollection<T>(restauracjeEntities.Set<T>().ToList());
        }

        private void add()
        {
            OpenAddWindow();
        }

        protected virtual void OpenAddWindow(){
        

        }
        #endregion
    }
}
