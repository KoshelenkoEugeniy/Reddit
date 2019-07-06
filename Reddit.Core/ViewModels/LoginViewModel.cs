using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using Reddit.Core.Managers.Interfaces;

namespace Reddit.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private IAccountManager _accountManager;

        public LoginViewModel(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }


        public override Task Initialize()
        {
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}