using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Helper;
using System.Diagnostics;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Data;
using MVVMFirma.ViewModels;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Fields
        private ReadOnlyCollection<CommandViewModel> _Commands;
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        #endregion

        #region Commands
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    List<CommandViewModel> cmds = this.CreateCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }

        private BaseCommand _ShowRestauracjeCommand;
        public ICommand ShowRestauracjeCommand
        {
            get
            {
                if (_ShowRestauracjeCommand == null)
                    _ShowRestauracjeCommand = new BaseCommand(() => this.ShowAll(new WszystkieRestauracjeViewModel()));
                return _ShowRestauracjeCommand;
            }
        }

        private List<CommandViewModel> CreateCommands()
        {
            Messenger.Default.Register<string>(this, open);
            return new List<CommandViewModel>
            {
                new CommandViewModel(
                    "Dostawy",
                    new BaseCommand(() => this.ShowAll(new WszystkieDostawyViewModel()))),

                new CommandViewModel(
                    "HistoriaZamowien",
                    new BaseCommand(() => this.ShowAll(new WszystkieHistoriaZamowienViewModel()))),

                new CommandViewModel(
                    "KategorieMenu",
                    new BaseCommand(() => this.ShowAll(new WszystkieKategorieMenuViewModel()))),

                new CommandViewModel(
                    "Klienci",
                    new BaseCommand(() => this.ShowAll(new WszystkieKlienciViewModel()))),

                new CommandViewModel(
                    "Menu",
                    new BaseCommand(() => this.ShowAll(new WszystkieMenuViewModel()))),

                new CommandViewModel(
                    "Opinie",
                    new BaseCommand(() => this.ShowAll(new WszystkieOpinieViewModel()))),

                new CommandViewModel(
                    "Pozycje Zamowienia",
                    new BaseCommand(() => this.ShowAll(new WszystkiePozycjeZamowieniaViewModel()))),

                new CommandViewModel(
                    "Pracownicy",
                    new BaseCommand(() => this.ShowAll(new WszystkiePracownicyViewModel()))),

                new CommandViewModel(
                    "Promocje",
                    new BaseCommand(() => this.ShowAll(new WszystkiePromocjeViewModel()))),

                new CommandViewModel(
                    "Restauracje",
                    new BaseCommand(() => this.ShowAll(new WszystkieRestauracjeViewModel()))),

                new CommandViewModel(
                    "Rezerwacje",
                    new BaseCommand(() => this.ShowAll(new WszystkieRezerwacjeViewModel()))),

                new CommandViewModel(
                    "RolePracownikow",
                    new BaseCommand(() => this.ShowAll(new WszystkieRolePracownikowViewModel()))),

                new CommandViewModel(
                    "Zamowienia",
                    new BaseCommand(() => this.ShowAll(new WszystkieZamowieniaViewModel())))
            };
        }
        #endregion

        #region Workspaces
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.OnWorkspaceRequestClose;

            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.OnWorkspaceRequestClose;
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }

        #endregion // Workspaces

        #region Private Helpers
        private void CreateView(WorkspaceViewModel nowy)
        {
            this.Workspaces.Add(nowy);
            this.SetActiveWorkspace(nowy);
        }
        private void ShowAll(WorkspaceViewModel nowy) {
            WorkspaceViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm.GetType() == nowy.GetType());

            if (workspace == null)
            {
                workspace = nowy;
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }
        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }

        private void open(string name)
        {
            //if (name == "DostawyAdd")
            //{
            //    CreateView(new NowyDostawyViewModel());
            //}
            switch (name)
            {
                case "DostawyAdd": CreateView(new NowyDostawyViewModel()); break;
                case "Historia ZamowienAdd": CreateView(new NowyHistoriaZamowienViewModel()); break;
                case "Kategorie MenuAdd": CreateView(new NowyKategorieMenuViewModel()); break;
                case "KlienciAdd": CreateView(new NowyKlienciViewModel()); break;
                case "MenuAdd": CreateView(new NowyMenuViewModel()); break;
                case "OpinieAdd": CreateView(new NowyOpinieViewModel()); break;
                case "Pozycje ZamowieniaAdd": CreateView(new NowyPozycjeZamowieniaViewModel()); break;
                case "PracownicyAdd": CreateView(new NowyPracownicyViewModel()); break;
                case "PromocjeAdd": CreateView(new NowyPromocjeViewModel()); break;
                case "RestauracjeAdd": CreateView(new NowyRestauracjaViewModel()); break;
                case "RezerwacjeAdd": CreateView(new NowyRezerwacjeViewModel()); break;
                case "Role PracownikowAdd": CreateView(new NowyRolePracownikowViewModel()); break;
                case "ZamowieniaAdd": CreateView(new NowyZamowieniaViewModel()); break;
                    default: break;
            }
        }
        #endregion
    }
}
