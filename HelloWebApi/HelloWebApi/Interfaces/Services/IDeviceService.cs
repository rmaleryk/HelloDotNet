﻿using System.Collections.Generic;
using HelloWebApi.Models;

namespace HelloWebApi.Interfaces.Services
{
    public interface IDeviceService
    {
        Device GetDeviceById(int id);

        List<Device> GetDevices(out int totalCount);

        Device AddDevice(Device device);
    }
}
