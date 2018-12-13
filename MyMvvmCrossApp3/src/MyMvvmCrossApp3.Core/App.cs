using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MyMvvmCrossApp3.Core.ViewModels.Main;

namespace MyMvvmCrossApp3.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
