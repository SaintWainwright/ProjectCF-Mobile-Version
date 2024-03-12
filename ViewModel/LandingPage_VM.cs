using ProjectCF_Mobile_Version.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectCF_Mobile_Version.ViewModel
{
    public partial class LandingPage_VM : MainViewModel
    {
        private void GoToViewSalary()
        {
            Shell.Current.GoToAsync(nameof(ViewSalary));
        }
        public ICommand GoToViewSalaryCommand => new Command(GoToViewSalary);
        private void GoToViewProfile()
        {
            Shell.Current.GoToAsync(nameof(ViewProfile));
        }
        public ICommand GoToViewProfileCommand => new Command(GoToViewProfile);
        private void GoToWorktime()
        {
            Shell.Current.GoToAsync(nameof(Worktime));
        }
        public ICommand GoToWorktimeCommand => new Command(GoToWorktime);
        private void GoToMessaging()
        {
            Shell.Current.GoToAsync(nameof(Messaging));
        }
        public ICommand GoToMessagingCommand => new Command(GoToMessaging);
    }
}