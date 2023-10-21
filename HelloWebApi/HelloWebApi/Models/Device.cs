using HelloWebApi.Enums;

namespace HelloWebApi.Models
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DeviceType Type { get; set; }
    }
}
