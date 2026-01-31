using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITCheckoutAPIv2.Models;

namespace ITCheckoutAPIv2.Services
{
    public interface IDeviceService
    {
        //What of our project

        //Create functions for our CRUD

        //Create
        Device AddDevice(Device newDevice);
        //Read
        List<Device> GetDevices();
        Device? GetDeviceById(int id);
        //Update
        Device? UpdateDevice(int id, Device updatedDevice);
        //Delete
        bool DeleteDevice(int id);
    }
}