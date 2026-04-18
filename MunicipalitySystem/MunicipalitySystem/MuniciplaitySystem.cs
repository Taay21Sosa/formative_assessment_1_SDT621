using MunicipalitySystem.Models;
using MunicipalitySystem.Services;
using System;

class MuniciplaitySystem
{
    static void Main(string[] args)
    {
        List<Resident> residents = new List<Resident>();
        List<ServiceRequest> serviceRequests = new List<ServiceRequest>();
        ResidentServices residentService = new ResidentServices();
        ServiceRequestManager serviceRequestManager = new ServiceRequestManager();

        Console.WriteLine("======================================================");
        Console.WriteLine("*****        EMFULENI MUNICIPALITY SYSTEM        *****");
        Console.WriteLine("======================================================");

        // Determines the number of residents, then registers residents and thier details
        int residentCount = residentService.GetNumberOfResidents();
        for (int i = 0; i < residentCount; i++)
        {
            residentService.RegisterResidents(i+1, residents);
        }

        // Determine service request details
        int requestCount = serviceRequestManager.GetNumberOfRequests();
        for (int i = 0; i < requestCount; i++)
        {
            serviceRequestManager.CreateNewServiceRequest(i + 1, serviceRequests, residents);
        }

        serviceRequestManager.ProcessRequests(serviceRequests);
    }
}
