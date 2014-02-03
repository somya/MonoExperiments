using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;

namespace S3MobileApps.Mono.Experiments.Library
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {

			Mvx.RegisterType<ICalculation, Calculation>();

//            CreatableTypes()
//                .EndingWith("Service")
//                .AsInterfaces()
//                .RegisterAsLazySingleton();
				
			RegisterAppStart<TipViewModel>();
        }
    }
}