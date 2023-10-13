using System.Collections.Generic;
using System.Linq;
using HelloWebApi.Enums;
using HelloWebApi.Interfaces;
using HelloWebApi.Models;

namespace HelloWebApi.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly List<Device> _devices = new List<Device>
        {
            new Device
            {
                Id = 1,
                Name = "Vacuum cleaner",
                Type = DeviceType.Vacuum
            },
            new Device
            {
                Id = 2,
                Name = "Ceiling light",
                Type = DeviceType.Light
            }
        };

        public Device GetDeviceById(int id)
        {
            return _devices.SingleOrDefault(device => device.Id == id);
        }

        public List<Device> GetDevices(out int totalCount)
        {
            totalCount = 2;

            return _devices;
        }

        public Device AddDevice(Device device)
        {
            device.Id = _devices.Count + 1;

            _devices.Add(device);

            return device;
        }
    }
}
