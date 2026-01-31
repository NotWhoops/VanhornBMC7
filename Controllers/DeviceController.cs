using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITCheckoutAPIv2.Models;
using ITCheckoutAPIv2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITCheckoutAPIv2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        /// Read all
        [HttpGet("getDeviceList")]

        public List<Device> GetDevices()
        {
            return _deviceService.GetDevices();
        }

        /// Read Id

        [HttpGet("AddDeviceById/{id}")]


        public Device? GetDeviceById(int id)
        {
            return _deviceService.GetDeviceById(id);
        }


        /// Create
        [HttpPost("AddDevice")]

        public Device AddDevice(Device device)
        {
            return _deviceService.AddDevice(device);
        }


        /// Update

        [HttpPut("updateDevice/{id}")]

        public Device? UpdateDevice(int id, Device device)
        {
            return _deviceService.UpdateDevice(id, device);
        }

        /// Delete

        [HttpDelete("removeDevice{id}")]
        public bool DeleteDevice(int id)
        {
            return _deviceService.DeleteDevice(id);
        }

    }
}
