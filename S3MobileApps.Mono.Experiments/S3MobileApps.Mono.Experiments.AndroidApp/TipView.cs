using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using S3MobileApps.Mono.Experiments.Library;

namespace S3MobileApps.Mono.Experiments.AndroidApp
{
	[Activity(Label = "Tip", MainLauncher = true)]
	public class TipView : MvxActivity
	{
		public new TipViewModel ViewModel
		{
			get { return (TipViewModel) base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet()
		{
			base.OnViewModelSet();
			SetContentView(Resource.Layout.View_Tip);
		}
	}
}


