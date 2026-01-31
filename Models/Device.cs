using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITCheckoutAPIv2.Models
{
    public class Device
    {
        //Id int
        public int Id { get; set; }
        //Name string
        public string? Name { get; set; }
        //Type string
        public string? Type { get; set; }
        // SerialNumber string
        public string? SerialNumber { get; set; }
        // IsCheckedOut bool
        public bool IsCheckedOut { get; set;}
    }
}