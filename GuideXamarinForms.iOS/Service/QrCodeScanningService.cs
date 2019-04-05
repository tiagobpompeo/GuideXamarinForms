using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideXamarinForms.Service;
using Foundation;
using UIKit;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(GuideXamarinForms.iOS.Service.QrCodeScanningService))]
namespace GuideXamarinForms.iOS.Service
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Aproxime a câmera do código de barras",
                BottomText = "Toque na tela para focar"
            };

            var scanResults = await scanner.Scan();

            return (scanResults != null) ? scanResults.Text : String.Empty;
        }
    }
}