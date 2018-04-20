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
using Naxam.Controls.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using static Android.App.ActionBar;


// From Xamarin forum
// https://forums.xamarin.com/discussion/comment/327855#Comment_327855
[assembly: ExportRenderer(typeof(MasterDetailPage), typeof(CustomNavigationPageRenderer))]

namespace BottomTp.Droid.Renderers
{
    //public class CustomNavigationPageRenderer : MasterDetailPageRenderer
    public class CustomNavigationPageRenderer : MasterDetailPageRenderer
    {
        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

            for (var i = 0; i < toolbar.ChildCount; i++)
            {
                var imageButton = toolbar.GetChildAt(i) as ImageButton;
                var drawerArrow = imageButton?.Drawable as DrawerArrowDrawable;
                if (drawerArrow == null)
                    continue;

                bool displayBack = false;
                var app = Xamarin.Forms.Application.Current;
                //var navPage = ((app.MainPage.Navigation.ModalStack[0] as MasterDetailPage).Detail as NavigationPage);
                var detailPage = (app.MainPage as MasterDetailPage).Detail;
                if (detailPage.GetType() == typeof(BottomTp.Views.NaxamMainPage))
                {
                    var tabPage = detailPage as BottomTabbedPage;
                    var curPage = tabPage.CurrentPage;
                    var navPageLevel = curPage.Navigation.NavigationStack.Count;
                    if (navPageLevel > 1)
                        displayBack = true;
                }

                if (!displayBack)
                    ChangeIcon(imageButton, Resource.Drawable.icon);
            }
        }

        private void ChangeIcon(ImageButton imageButton, int id)
        {
            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Lollipop)
                imageButton.SetImageDrawable(Context.GetDrawable(id));
            imageButton.SetImageResource(id);
        }

       
        protected override void OnElementChanged(VisualElement oldElement, VisualElement newElement)
        {

            this.DrawerClosed += delegate (object sender, Android.Support.V4.Widget.DrawerLayout.DrawerClosedEventArgs e)
            {
                OnDrawerClosed();
            };

            this.DrawerOpened += delegate (object sender, Android.Support.V4.Widget.DrawerLayout.DrawerOpenedEventArgs e)
            {
                OnDrawerOpened();
            };
            /*
            base.OnElementChanged(oldElement, newElement);

            if (oldElement != null)
            {
                // unsubscribe
                //Control.ItemClick -= OnItemClick;

            }

            if (newElement != null)
            {
                // subscribe
                Control.Adapter = new NativeAndroidListViewAdapter(_context as Android.App.Activity, e.NewElement as NativeListView);
                Control.ItemClick += OnItemClick;
            }
            */
        }

        public void OnDrawerClosed()
        {

        }

        public void OnDrawerOpened()
        {

        }

    }
}