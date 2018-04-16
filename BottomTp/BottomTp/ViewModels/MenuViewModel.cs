using BottomTp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BottomTp.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>();

            MenuItems.Add(new MenuItem() { IconVisible = true, Icon = "fa-home", Text = "Home" });
            MenuItems.Add(new MenuItem() { IconVisible = true, Icon = "md-view-list", Text = "Browse" });
            MenuItems.Add(new MenuItem() { IconVisible = true, Icon = "fa-user", Text = "Profile" });
            MenuItems.Add(new MenuItem() { IconVisible = true, Icon = "md-help", Text = "About" });
        }

    }
}
