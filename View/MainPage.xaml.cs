using ProjectCF_Mobile_Version.ViewModel;

namespace ProjectCF_Mobile_Version
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPage_VM();
        }
    }
}
