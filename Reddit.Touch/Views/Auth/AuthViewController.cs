using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Reddit.Core.ViewModels;
using UIKit;

namespace Reddit.Touch.Views.Auth
{
    [MvxModalPresentation(WrapInNavigationController = false)]
    public partial class AuthViewController : MvxViewController<AuthViewModel>
    {
        MvxFluentBindingDescriptionSet<AuthViewController, AuthViewModel> BindingSet;

        public AuthViewController() : base("AuthViewController", null)
        {
        }

        private bool _isErrorShown;
        public bool IsErrorShown
        {
            get => _isErrorShown;
            set
            {
                _isErrorShown = value;
                ErrorLoginLabel.Hidden = !_isErrorShown;
                ErrorPasswordLabel.Hidden = !_isErrorShown;
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            BindingSet = this.CreateBindingSet<AuthViewController, AuthViewModel>();

            BindingSet.Bind(WelcomeLabel).To(vm => vm.TitleText);
            BindingSet.Bind(SubtitleLabel).To(vm => vm.SubtitleText);
            BindingSet.Bind(InfoLabel).To(vm => vm.InfoText);
            BindingSet.Bind(LoginLabel).To(vm => vm.LoginText);
            BindingSet.Bind(PasswordLabel).To(vm => vm.PasswordText);
            BindingSet.Bind(ErrorLoginLabel).To(vm => vm.LoginErrorText);
            BindingSet.Bind(ErrorPasswordLabel).To(vm => vm.PasswordErrorText);
            BindingSet.Bind(this).For(v => v.IsErrorShown).To(vm => vm.IsLoginError);
            BindingSet.Bind(LoginTextField).To(vm => vm.Login);
            BindingSet.Bind(LoginTextField).For(v => v.Placeholder).To(vm => vm.LoginHintText);
            BindingSet.Bind(PasswordTextField).To(vm => vm.Password);
            BindingSet.Bind(PasswordTextField).For(v => v.Placeholder).To(vm => vm.PasswordHintText);
            BindingSet.Bind(LoginButton).For("Title").To(vm => vm.LoginText);
            BindingSet.Bind(LoginButton).To(vm => vm.LoginCommand);

            BindingSet.Apply();
        }
    }
}

