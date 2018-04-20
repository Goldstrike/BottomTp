using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Graphics.Drawable;
using Android.Views;
using Android.Widget;
using BottomTp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;


// From KickassUI.Twitter
//[assembly: ExportRenderer(typeof(MasterDetailPage), typeof(MasterDetailIconRenderer))]
////[assembly: ExportRenderer(typeof(BottomTp.Views.NaxamMainPage), typeof(MasterDetailIconRenderer))]
namespace BottomTp.Droid.Renderers
{

    public class MasterDetailIconRenderer : MasterDetailPageRenderer
    {

        /*
        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            SetNavigationIcon(Forms.Context, Resource.Drawable.icon);
        }

        private void SetNavigationIcon(Context context, int resourceId)
        {
            bool displayBack = false;
            var app = Xamarin.Forms.Application.Current;
            var navPage = ((app.MainPage.Navigation.ModalStack[0] as MasterDetailPage).Detail as NavigationPage);
            if (app != null && navPage.Navigation.NavigationStack.Count > 0)
            {
                displayBack = true;
            }

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            if (toolbar.NavigationIcon != null)
            {
                var navIcon = toolbar.NavigationIcon.Callback as ImageButton;
                navIcon?.SetImageDrawable(context.GetDrawable(resourceId));
            }
        }
        */


    }
}