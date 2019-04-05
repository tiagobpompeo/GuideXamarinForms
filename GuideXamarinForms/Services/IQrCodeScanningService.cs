using System.Threading.Tasks;

namespace GuideXamarinForms.Service
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
