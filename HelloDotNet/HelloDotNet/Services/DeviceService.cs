using System.Collections.Generic;
using System.Threading.Tasks;
using HelloDotNet.Enums;
using HelloDotNet.Interfaces;
using HelloDotNet.Models;

namespace HelloDotNet.Services
{
    public class DeviceService : IDeviceService
    {
        public ResponseModel<Device> GetDevices()
        {
            // Real call
            return new ResponseModel<Device>
            {
                Data = new List<Device>
                {
                    new Device
                    {
                        Id = 1,
                        Name = "Vacuum cleaner",
                        Type = DeviceType.Vacuum
                    }
                },
                TotalCount = 100
            };
        }

        public Task<ResponseModel<User>> GetUsersAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
