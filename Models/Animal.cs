using System;
using System.Collections.Generic;

namespace ZooManagement.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string Classification {get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public DateTime AcquisitionDate { get; set; }

    }
}
