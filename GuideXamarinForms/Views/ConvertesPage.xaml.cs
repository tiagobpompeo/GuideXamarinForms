using System;
using System.Collections.Generic;
using GuideXamarinForms.ViewModels;
using Xamarin.Forms;

namespace GuideXamarinForms.Views
{
    public partial class ConvertesPage : ContentPage
    {
        public ConvertesPage()
        {
            InitializeComponent();

            BindingContext = new ConvertersViewModel();
        }
    }
}
