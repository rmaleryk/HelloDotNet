using System.Collections.Generic;
using System.Linq;
using HelloWebApi.Enums;
using HelloWebApi.Interfaces.Repositories;
using HelloWebApi.Models;

namespace HelloWebApi.Repositories
{
    public class FakeDeviceRepository : IDeviceRepository
    {
        private readonly List<Device> _devices = new List<Device>
        {
            new Device
            {
                Id = 1,
                Name = "Vacuum cleaner 1",
                Type = DeviceType.Vacuum
            },
            new Device
            {
                Id = 2,
                Name = "Vacuum cleaner 2",
                Type = DeviceType.Vacuum
            },
            new Device
            {
                Id = 3,
                Name = "Vacuum cleaner 3",
                Type = DeviceType.Vacuum
            },
            new Device
            {
                Id = 4,
                Name = "Vacuum cleaner 4",
                Type = DeviceType.Vacuum
            }
        };

        public Device AddDevice(Device device)
        {
            device.Id = _devices.Count + 1;

            _devices.Add(device);

            return device;
        }

        public Device GetDeviceById(int id)
        {
            return _devices.SingleOrDefault(device => device.Id == id);
        }

        public List<Device> GetDevices()
        {
            return _devices;
        }

        public int GetDevicesTotalCount()
        {
            return _devices.Count;
        }
    }
}
