using HelloDotNet.Enums;

namespace HelloDotNet.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeviceType Type { get; set; }
        public string Identifier => $"{Id}:{Name}";
    }
}
