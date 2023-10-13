using HelloWebApi.Enums;

namespace HelloWebApi.ClientModels.Devices
{
    public class DeviceRequestModel
    {
        public string Name { get; set; }

        public DeviceType Type { get; set; }
    }
}
