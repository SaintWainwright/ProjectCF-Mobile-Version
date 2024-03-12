using ProjectCF_Mobile_Version.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectCF_Mobile_Version.ViewModel
{
    public partial class LoginPage_VM : MainViewModel
    {
        private void GoToLandingPage()
        {
            Shell.Current.GoToAsync(nameof(LandingPage));
        }
        public ICommand GoToLandingPageCommand => new Command(GoToLandingPage);
    }
}
