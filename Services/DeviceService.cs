using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITCheckoutAPIv2.Models;

namespace ITCheckoutAPIv2.Services
{
    public class DeviceService : IDeviceService
    {

//Our service is the how of our project
        private readonly List<Device> _deviceList = new();

        //constructor (shortcut is "ctor")
        public DeviceService()
        {
            _deviceList.Add(new Device
            {
                Id = 1,
                Name = "Dell",
                Type = "Laptop",
                SerialNumber = "SN-1234",
                IsCheckedOut = true
            });

            _deviceList.Add(new Device
            {
                Id = 2,
                Name = "Ipad",
                Type = "Tablet",
                SerialNumber = "SN-56789",
                IsCheckedOut = false
            });
        }


        //----------------------- Create -----------------------
        public Device AddDevice(Device newDevice)
        {
            int newId = _deviceList.Count == 0 ? 1 : _deviceList.Max(d => d.Id) + 1;

            newDevice.Id = newId;

            _deviceList.Add(newDevice);
            return newDevice;
        }
//----------------------- Delete ---------------------
        public bool DeleteDevice(int id)
        {
           Device? device = _deviceList.FirstOrDefault(d => d.Id == id);

           if( device == null)
            {
                return false;
            }
            _deviceList.Remove(device);
            return true;
        }
//----------------------- Read -----------------------
        public List<Device> GetDevices()
        {
            return _deviceList;
        }
//----------------------- Read -----------------------
        public Device? GetDeviceById(int id)
        {
            return _deviceList.FirstOrDefault(d => d.Id == id);
        }
//----------------------- Update -----------------------
        public Device? UpdateDevice(int id, Device updatedDevice)
        {
            Device? existingDevice = _deviceList.FirstOrDefault(d => d.Id == id);

            if(existingDevice == null)
            {
                return null;
            }
            existingDevice.Name = updatedDevice.Name;
            existingDevice.Type = updatedDevice.Type;
            existingDevice.SerialNumber = updatedDevice.SerialNumber;
            existingDevice.IsCheckedOut = updatedDevice.IsCheckedOut;
            
            return existingDevice;
        }
    }
}