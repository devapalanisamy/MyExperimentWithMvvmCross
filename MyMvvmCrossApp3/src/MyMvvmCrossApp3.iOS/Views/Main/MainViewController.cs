using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using MyMvvmCrossApp3.Core.ViewModels.Main;
using UIKit;

namespace MyMvvmCrossApp3.iOS.Views.Main
{
    [MvxFromStoryboard(nameof(MainViewController))]
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MainViewController : BaseViewController<MainViewModel>
    {
        public MainViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<MainViewController, MainViewModel>();
            set.Bind(LabelWelcome).To(vm => vm.Welcome);
            set.Bind(NextButton).To(vm => vm.SubmitCommand);
            set.Apply();
        }
    }
}
