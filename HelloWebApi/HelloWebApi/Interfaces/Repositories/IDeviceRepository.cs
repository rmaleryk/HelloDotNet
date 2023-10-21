using System.Collections.Generic;
using HelloWebApi.Models;

namespace HelloWebApi.Interfaces.Repositories
{
    public interface IDeviceRepository
    {
        List<Device> GetDevices();

        int GetDevicesTotalCount();

        Device GetDeviceById(int id);

        Device AddDevice(Device device);
    }
}
