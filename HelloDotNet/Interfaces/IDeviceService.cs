using HelloDotNet.Models;

namespace HelloDotNet.Interfaces
{
    public interface IDeviceService
    {
        ResponseModel<Device> GetDevices();
    }
}
