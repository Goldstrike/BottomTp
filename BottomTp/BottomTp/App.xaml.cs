using System;

using BottomTp.Views;
using Naxam.Controls.Forms;
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


            // Without MasterDetail
            // ====================

            // default
            // -------
            //MainPage = new MainPage();

            // iconize
            // --------
            //MainPage = new IcMainPage();
            //MainPage = new NavigationPage(new ItemsPage());

            // Naxam
            // -----
            // Naxam - Github sample
            /*
            tabs.Children.Add(new ContentPage
            {
                Title = "Tab 1",
                Icon = "md-view-list",
                BackgroundColor = Color.Aqua,
                Content = new Label
                {
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "BottomTabbedPage - A Xamarin.Forms page with tabs at the bottom.",
                    TextColor = Color.DarkCyan,
                    Margin = new Thickness(16)
                }
            });
            tabs.Children.Add(new ContentPage
            {
                Title = "Tab 2",
                Icon = "md-help",
                BackgroundColor = Color.Beige,
                Content = new Label
                {
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "BottomTabbedPage internally uses BottomNavigationViewEx.",
                    TextColor = Color.Green,
                    Margin = new Thickness(16)
                }
            });
            MainPage = tabs;
            */

            // Naxam - default code behind
            /*
            var tabs = new BottomTabbedPage();
            tabs.Children.Add(new ItemsPage() { Title = "Browse", Icon = "md-view-list" });
            tabs.Children.Add(new AboutPage() { Title = "About", Icon = "md-help" });
            MainPage = tabs;
            */

            // Naxam - default XAML
            //MainPage = new NaxamMainPage();

            // with Master-Detail
            // ==================

            // Naxam
            var masterDetail = new MasterDetailPage();
            masterDetail.Master = new MenuPage();
            masterDetail.Detail = new NaxamMainPage();
            masterDetail.Icon = "icon.png";
            MainPage = masterDetail;
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
