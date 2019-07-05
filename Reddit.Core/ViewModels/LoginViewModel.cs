using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace Reddit.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        public MvxObservableCollection<string> TestCollection { get; set; } 

        public LoginViewModel()
        {
            TestCollection = new MvxObservableCollection<string>
            { "q", "w", "e", "r", "t", "y"};
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