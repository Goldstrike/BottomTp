using Plugin.Iconize;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomTp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IcMainPage : IconTabbedPage
    {
		public IcMainPage ()
		{
			InitializeComponent ();
		}
	}
}