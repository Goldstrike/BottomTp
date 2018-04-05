using System;

using BottomTp.Views;
using Xamarin.Forms;

namespace BottomTp
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.MaterialModule())
                                  .With(new Plugin.Iconize.Fonts.FontAwesomeModule());


            // default
            //MainPage = new MainPage();

            // iconize
            MainPage = new IcMainPage();

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
