using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuideXamarinForms.Service;
using Xamarin.Forms;

namespace GuideXamarinForms.Views
{
    public partial class ScannerPage : ContentPage
    {
        public ScannerPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e) => await OpenScan();

        private async Task OpenScan()
        {
            var scanner = DependencyService.Get<IQrCodeScanningService>();
            var result = await scanner.ScanAsync();
            if (!string.IsNullOrEmpty(result))
            {
                lblResultado.Text = result;
            }
            else
            {
                lblResultado.Text = "Código de barras não identificado!";
            }
        }
    }
}
