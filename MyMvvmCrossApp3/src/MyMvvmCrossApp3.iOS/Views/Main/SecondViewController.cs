using System;
using MvvmCross.Platforms.Ios.Views;
using UIKit;
using MyMvvmCrossApp3.Core.ViewModels;

namespace MyMvvmCrossApp3.iOS.Views
{
    [MvxFromStoryboard(nameof(SecondViewController))]
    public partial class SecondViewController : BaseViewController<SecondViewModel>
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

