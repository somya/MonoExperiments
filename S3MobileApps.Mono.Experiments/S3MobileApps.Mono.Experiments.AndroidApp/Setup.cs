using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.MvvmCross.ViewModels;
using S3MobileApps.Mono.Experiments.Library;

namespace S3MobileApps.Mono.Experiments.AndroidApp
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext) : base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}

		protected override IMvxNavigationSerializer CreateNavigationSerializer()
		{
			Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();
			return new MvxJsonNavigationSerializer();
		}
	}
}

