using GuideXamarinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideXamarinForms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Behaviors:
                        MenuPages.Add(id, new NavigationPage(new BehaviorsPage()));
                        break;
                    case (int)MenuItemType.BindingMode:
                        MenuPages.Add(id, new NavigationPage(new BindingModePage()));
                        break;
                    case (int)MenuItemType.Commands:
                        MenuPages.Add(id, new NavigationPage(new CommandsPage()));
                        break;
                    case (int)MenuItemType.Converters:
                        MenuPages.Add(id, new NavigationPage(new ConvertesPage()));
                        break;
                    case (int)MenuItemType.CustomControls:
                        MenuPages.Add(id, new NavigationPage(new CustomControlsPage()));
                        break;
                    case (int)MenuItemType.CustomRenders:
                        MenuPages.Add(id, new NavigationPage(new CustomRendersPage()));
                        break;
                    case (int)MenuItemType.DependencyService:
                        MenuPages.Add(id, new NavigationPage(new DependencyServicePage()));
                        break;
                    case (int)MenuItemType.Effects:
                        MenuPages.Add(id, new NavigationPage(new EffectsPage()));
                        break;
                    case (int)MenuItemType.NavigationMethods:
                        MenuPages.Add(id, new NavigationPage(new NavigationMethodsPage()));
                        break;
                    case (int)MenuItemType.ServicesPage:
                        MenuPages.Add(id, new NavigationPage(new ServicesPages()));
                        break;
                    case (int)MenuItemType.TaskPage:
                        MenuPages.Add(id, new NavigationPage(new TaskPages()));
                        break;
                    case (int)MenuItemType.Triggers:
                        MenuPages.Add(id, new NavigationPage(new TriggersPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}