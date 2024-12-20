using MVVMFirma.Models.Entities;

namespace MVVMFirma.ViewModels
{
    public class NowyKategorieMenuViewModel : JedenViewModel<KategorieMenu>
    {
        public NowyKategorieMenuViewModel() : base("Nowa Kategoria Menu") { }


        public string Nazwa
        {
            get { return item.Nazwa; }
            set { item.Nazwa = value; OnPropertyChanged(() => Nazwa); }
        }

    }
}
