using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;
using GuideXamarinForms.Service;

[assembly: Dependency(typeof(GuideXamarinForms.Droid.Service.QrCodeScanningService))]
namespace GuideXamarinForms.Droid.Service
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionCuston = new MobileBarcodeScanningOptions()
            {
                //UseFrontCameraIfAvailable = true;
            };

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Aproxime a câmera do código de barras",
                BottomText = "Toque na tela para focar"
            };

            var scanResults = await scanner.Scan(optionCuston);

            return (scanResults != null) ? scanResults.Text : String.Empty;
        }
    }
}