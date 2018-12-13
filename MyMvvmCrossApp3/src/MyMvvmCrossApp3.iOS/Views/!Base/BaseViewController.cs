using System;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;
using MyMvvmCrossApp3.iOS.Styles;
using UIKit;

namespace MyMvvmCrossApp3.iOS.Views
{
    public abstract class BaseViewController<TViewModel> : MvxViewController<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected BaseViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;

            NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;
            NavigationController.NavigationBar.Translucent = false;
            NavigationController.NavigationBar.Hidden = false;
            NavigationController.NavigationBar.BarTintColor = ColorPalette.Primary;
            NavigationController.NavigationBar.TintColor = UIColor.White;

            NavigationController.SetNeedsStatusBarAppearanceUpdate();
        }
    }
}
