using GuideXamarinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideXamarinForms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Behaviors, Title="Behaviors" },
                new HomeMenuItem {Id = MenuItemType.CustomControls, Title="CustomControls" },
                new HomeMenuItem {Id = MenuItemType.CustomRenders, Title="CustomRenders" },
                new HomeMenuItem {Id = MenuItemType.Effects, Title="Effects" },
                new HomeMenuItem {Id = MenuItemType.Triggers, Title="Triggers" },
                new HomeMenuItem {Id = MenuItemType.Converters, Title="Converters" },
                new HomeMenuItem {Id = MenuItemType.Commands, Title="Commands" },
                new HomeMenuItem {Id = MenuItemType.BindingMode, Title="BindingMode" },
                new HomeMenuItem {Id = MenuItemType.DependencyService, Title="DependencyService" },
                new HomeMenuItem {Id = MenuItemType.NavigationMethods, Title="NavigationMethods" },
                new HomeMenuItem {Id = MenuItemType.TaskPage, Title="TaskPage" },
                new HomeMenuItem {Id = MenuItemType.ServicesPage, Title="ServicesPage" },
                new HomeMenuItem {Id = MenuItemType.ScannerServices, Title="ScannerService" }

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}

