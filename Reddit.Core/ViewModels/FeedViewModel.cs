using System;
using MvvmCross.Core.ViewModels;

namespace Reddit.Core.ViewModels
{
    public class FeedViewModel : MvxViewModel
    {
        public MvxObservableCollection<string> TestCollection { get; set; }

        public FeedViewModel()
        {
            TestCollection = new MvxObservableCollection<string>
            { "q", "w", "e", "r", "t", "y"};
        }
    }
}
