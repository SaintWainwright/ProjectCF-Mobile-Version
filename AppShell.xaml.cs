using ProjectCF_Mobile_Version.View;

namespace ProjectCF_Mobile_Version
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(LandingPage), typeof(LandingPage));
        }
    }
}
