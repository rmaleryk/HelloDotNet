using System.ComponentModel.DataAnnotations;
using HelloWebApi.Enums;

namespace HelloWebApi.ClientModels.Devices
{
    public class DeviceRequestModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public DeviceType? Type { get; set; }
    }
}
