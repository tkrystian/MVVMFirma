using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using GalaSoft.MvvmLight.Messaging;

namespace MVVMFirma.ViewModels
{
    public class WszystkieViewModel<T> : WorkspaceViewModel where T : class
    {
        #region DB
        protected readonly RestauracjeEntities restauracjeEntities;
        #endregion

        #region Command
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
        public WszystkieViewModel(string displayName)
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
            Messenger.Default.Send(DisplayName + "Add");
        }
        #endregion
    }
}
