using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MyMvvmCrossApp3.Core;

namespace MyMvvmCrossApp3.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
