using MVVMFirma.Models.Entities;

namespace MVVMFirma.ViewModels
{
    public class NowyRolePracownikowViewModel : JedenViewModel<RolePracownikow>
    {
        public NowyRolePracownikowViewModel() : base("Nowa Rola Pracownika") { }


        public string Nazwa
        {
            get { return item.Nazwa; }
            set { item.Nazwa = value; OnPropertyChanged(() => Nazwa); }
        }
    }
}
