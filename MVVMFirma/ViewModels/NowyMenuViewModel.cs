using MVVMFirma.Models.Entities;

namespace MVVMFirma.ViewModels
{
    public class NowyMenuViewModel : JedenViewModel<Menu>
    {
        public NowyMenuViewModel() : base("Nowe Menu") { }


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

        public decimal Cena
        {
            get { return item.Cena; }
            set { item.Cena = value; OnPropertyChanged(() => Cena); }
        }

    }
}
