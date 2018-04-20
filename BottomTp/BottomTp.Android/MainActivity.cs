using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Naxam.Controls.Platform.Droid;
using Android.Graphics;
using Plugin.Iconize;
using FFImageLoading.Forms.Droid;

namespace BottomTp.Droid
{
    [Activity(Label = "BottomTp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            // Naxam    
            // =====
            SetupBottomTabs();
            Plugin.Iconize.Iconize
                .With(new Plugin.Iconize.Fonts.FontAwesomeModule())
                .With(new Plugin.Iconize.Fonts.MaterialModule());

            // FFImageLoading
            // ==============
            CachedImageRenderer.Init(enableFastRenderer: false);
             

            base.OnCreate(bundle);

            // Iconize
            // =======
            //Plugin.Iconize.Iconize.Init(Resource.Id.toolbar, Resource.Id.sliding_tabs);

            // Disable hamburger => arrow animation
            // ====================================
            //Toolbar toolbar = (Toolbar)Resource.Layout.Toolbar;
            //ActionBarDrawerToggle
            //toolbar.Set
            /*
            var myToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            if (myToolbar != null)
            {

                // set this flag so the colors colorPrimaryDark and android:statusBarColor have an effect
                // setting android:statusBarColor to transparent causes the drawer to be dran underneath a translucent status bar
                Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

                // make the toolbar the replacement of the action bar
                //SetSupportActionBar(myToolbar);
            }
            */

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        void SetupBottomTabs()
        {
            var stateList = new Android.Content.Res.ColorStateList(
                new int[][] {
                    new int[] { Android.Resource.Attribute.StateChecked
                },
                new int[] { Android.Resource.Attribute.StateEnabled
                }
                },
                new int[] {
                    //Color.Red, //Selected
                    //Color.White //Normal
                    Color.White, //Selected
                    Color.LightGray //Normal
	            });

            //BottomTabbedRenderer.BackgroundColor = new Color(0x9C, 0x27, 0xB0);
            BottomTabbedRenderer.BackgroundColor = new Color(0x21, 0x96, 0xF3);
            //BottomTabbedRenderer.FontSize = 12f;
            BottomTabbedRenderer.FontSize = 14f;
            BottomTabbedRenderer.IconSize = 16;
            BottomTabbedRenderer.ItemTextColor = stateList;
            BottomTabbedRenderer.ItemIconTintList = stateList;
            //BottomTabbedRenderer.Typeface = Typeface.CreateFromAsset(this.Assets, "architep.ttf");
            //BottomTabbedRenderer.Typeface = Typeface.CreateFromAsset(this.Assets, "HiraginoKakugoProNW3.otf");
            BottomTabbedRenderer.ItemBackgroundResource = Resource.Drawable.bnv_selector;
            BottomTabbedRenderer.ItemSpacing = 4;
            //BottomTabbedRenderer.ItemPadding = new Xamarin.Forms.Thickness(6);
            BottomTabbedRenderer.BottomBarHeight = 56;
            BottomTabbedRenderer.ItemAlign = ItemAlignFlags.Center;
            BottomTabbedRenderer.ShouldUpdateSelectedIcon = true;
            BottomTabbedRenderer.MenuItemIconSetter = (menuItem, iconSource, selected) =>
            {
                var iconized = Iconize.FindIconForKey(iconSource.File);
                if (iconized == null)
                {
                    BottomTabbedRenderer.DefaultMenuItemIconSetter.Invoke(menuItem, iconSource, selected);

                    return;
                }

                //var drawable = new IconDrawable(this, iconized).Color(selected ? Color.Red : Color.White).SizeDp(30);
                var drawable = new IconDrawable(this, iconized).Color(selected ? Color.White : Color.LightGray).SizeDp(30);

                menuItem.SetIcon(drawable);
            };
        }



    }

}

