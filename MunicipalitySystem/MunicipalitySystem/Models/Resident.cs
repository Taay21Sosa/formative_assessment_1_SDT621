using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalitySystem.Models
{
    public class Resident
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public double MonthlyUtilityUsage { get; set; }
    }
}
