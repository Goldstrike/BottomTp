using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Naxam.Controls.Forms;
using Plugin.Iconize;
using UIKit;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(BottomTabbedPage), typeof(IconTabbedPageRenderer))]
namespace BottomTp.iOS.Renderers
{
    public class BottomTabbedPageRenderer : IconTabbedPageRenderer
    {
    }
}