using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalitySystem.Models
{
    public class ServiceRequest
    {
        public string RequestId { get; set; }
        public Resident RequestingResident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public double EstimatedResolutionTime { get; set; }
        public double UrgencyScore { get; set; }
        public  bool isResolved { get; set; }
    }
}
