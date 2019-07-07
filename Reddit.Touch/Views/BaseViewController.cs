//using System;
//using Foundation;
//using MvvmCross.Binding.BindingContext;
//using MvvmCross.iOS.Views;

//namespace Reddit.Touch.Views
//{
//    public abstract class BaseViewController<TViewModel> : MvxViewController<TViewModel> 
//        where TViewModel : BaseScreenViewModel
//    {
//        protected MvxFluentBindingDescriptionSet<BaseViewController<TViewModel>, TViewModel> BindingSet { get; private set; }

//        //public virtual KeyboardHandlerSettings KeyboardHandlerSettings { get; set; }

//        //protected bool KeyboardIsVisible { get; set; }

//        private string _titleText;
//        public string TitleText //        {
//            get => _titleText;
//            set //            {
//                _titleText = value; //                SetScreenTitle();
//            }
//        } 


//        protected BaseViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
//        {
//        } 
//        public override void ViewDidLoad()
//        {
//            base.ViewDidLoad();

//            BindingSet = this.CreateBindingSet<BaseViewController<TViewModel>, TViewModel>();

//            InitData();
//            InitUi();
//        }

//        public override void ViewWillAppear(bool animated)
//        {
//            base.ViewWillAppear(animated);

//            //SetupNavBar();  //            SetupKeyboardHandling();

//            TitleView.Update(NavigationItem.TitleView); //        }

//        public override void ViewDidDisappear(bool animated)
//        {
//            base.ViewDidDisappear(animated);

//            ResetKeyBoardHandling();
//        }

//        protected virtual void InitUi() //        { //            BindingSet.Bind(this).For(v => v.TitleText).To(vm => vm.Title); //        }

//        protected void SetupKeyboardHandling()
//        {
//            var settings = KeyboardHandlerSettings;

//            if (settings == null || !settings.HandleKeyboardNotifications)
//                return;

//            RegisterForKeyboardNotifications(); //            DismissKeyboardOnBackgroundTap();

//            CurrentScrollView = settings.MainScrollView;
//            ViewToCenterOnKeyboardShown = settings.MainContainerToCenter;
//        }

//        protected void ResetKeyBoardHandling()
//        {
//            var settings = KeyboardHandlerSettings;

//            if (settings == null || !settings.HandleKeyboardNotifications)
//                return;

//            UnregisterForKeyboardNotifications();
//        }
//    }
//}
