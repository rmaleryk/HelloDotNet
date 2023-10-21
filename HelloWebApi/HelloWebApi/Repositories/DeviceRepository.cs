using System.Collections.Generic;
using System.Linq;
using HelloWebApi.Database;
using HelloWebApi.Interfaces.Repositories;
using HelloWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWebApi.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly DbSet<Device> _dbSet;
        private readonly ApplicationDbContext _dbContext;

        public DeviceRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Devices;
        }

        public Device AddDevice(Device device)
        {
            _dbSet.Add(device);
            _dbContext.SaveChanges();

            return device;
        }

        public Device GetDeviceById(int id)
        {
            return _dbSet.SingleOrDefault(device => device.Id == id);
            /*
             * SELECT * FROM [Devices]
             * WHERE [Id] = @id;
             */
        }

        public List<Device> GetDevices()
        {
            return _dbSet.ToList();
            /*
            * SELECT * FROM [Devices];
            */
        }

        public int GetDevicesTotalCount()
        {
            return _dbSet.Count();
            /*
            * SELECT COUNT(1) FROM [Devices];
            */
        }
    }
}
