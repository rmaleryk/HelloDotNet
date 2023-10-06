using System.Collections.Generic;
using HelloDotNet.Enums;
using HelloDotNet.Interfaces;
using HelloDotNet.Models;

namespace HelloDotNet.Services
{
    public class FakeDeviceService : IDeviceService
    {
        public ResponseModel<Device> GetDevices()
        {
            return new ResponseModel<Device>
            {
                Data = new List<Device>
                {
                    new Device
                    {
                        Id = 1,
                        Name = "Fake Vacuum cleaner",
                        Type = DeviceType.Vacuum
                    }
                },
                TotalCount = 100
            };
        }
    }
}
