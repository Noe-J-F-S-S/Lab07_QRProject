using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QRProject.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
