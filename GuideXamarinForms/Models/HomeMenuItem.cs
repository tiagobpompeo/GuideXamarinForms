using System;
using System.Collections.Generic;
using System.Text;

namespace GuideXamarinForms.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        CustomControls,
        CustomRenders,
        Effects,
        Triggers,
        Converters,
        Behaviors,
        Commands,
        BindingMode,
        DependencyService,
        NavigationMethods,
        TaskPage,
        ServicesPage,
        ScannerServices

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
