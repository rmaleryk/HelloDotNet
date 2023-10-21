using HelloWebApi.ClientModels.Devices;
using HelloWebApi.Exceptions;
using HelloWebApi.Interfaces.Services;
using HelloWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevicesController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var devices = _deviceService.GetDevices(out var totalCount);

            var responseModel = new ResponseModel<Device>
            {
                Data = devices,
                TotalCount = totalCount
            };

            return Ok(responseModel);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var device = _deviceService.GetDeviceById(id);

            if (device == null)
            {
                return NotFound();
            }

            return Ok(device);
        }

        [HttpPost]
        public IActionResult Add([FromBody] DeviceRequestModel requestModel)
        {
            var device = new Device
            {
                Name = requestModel.Name,
                Type = requestModel.Type.Value
            };

            try
            {
                var storedDevice = _deviceService.AddDevice(device);

                return Ok(storedDevice);
            }
            catch (BadOperationException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] DeviceRequestModel requestModel)
        {
            // Implementation
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            // Implementation
            return Ok();
        }
    }
}