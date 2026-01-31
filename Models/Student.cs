using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITCheckoutAPIv2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set;}
        public bool IsCheckedOut { get; set;}
    }
}