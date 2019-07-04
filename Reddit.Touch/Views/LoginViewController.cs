using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Reddit.Core.ViewModels;
using UIKit;

namespace Reddit.Touch.Views
{
    public partial class LoginViewController : MvxViewController<LoginViewModel>
    {
        MvxFluentBindingDescriptionSet<LoginViewController, LoginViewModel> BindingSet;

        public LoginViewController() : base("LoginViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            BindingSet = this.CreateBindingSet<LoginViewController, LoginViewModel>();

            BindingSet.Bind(TextLabel).To(vm => vm.Text);
            BindingSet.Apply();
        }


    }
}

