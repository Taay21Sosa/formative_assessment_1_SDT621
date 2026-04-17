using MunicipalitySystem.Models;
using MunicipalitySystem.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalitySystem.Services
{
    public class ServiceRequestManager
    {
        ValidationUtility validator = new ValidationUtility();
        UtilitiesManager manager = new UtilitiesManager();

        public void CreateNewServiceRequest(int i, List<ServiceRequest> serviceRequests, List<Resident> residents)
        {
            Console.WriteLine($"\n--- Service Request {i} ---");
            ServiceRequest newRequest = new ServiceRequest();

            newRequest.RequestId = $"2138-nlmb-xx{i}";
            newRequest.isResolved = false;

            // Select resident that created the request
            Console.Write("Select Resident for this request: ");
            for (int j = 0; j < residents.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {residents[j].Name} ({residents[j].AccountNumber})");
            }
            
            int residentIndex = validator.GetValidInteger("Enter resident number: ", 1, residents.Count) - 1;
            newRequest.RequestingResident = residents[residentIndex];

            // Request Details
            Console.Write("Request type (e.g., water leak): ");
            newRequest.RequestType = Console.ReadLine();

            newRequest.PriorityLevel = validator.GetValidInteger("Priority Level (1-5): ", 1, 5);
            newRequest.SeverityLevel = validator.GetValidInteger("Severity Level (1-10): ", 1, 10);
            newRequest.EstimatedResolutionTime = validator.GetValidDouble("Est. Resolution Time (hours): ");

            // Calculate Urgency Score
            newRequest.UrgencyScore = manager.CalculateUregencyScore(newRequest);

            serviceRequests.Add(newRequest);
            Console.WriteLine("--------------------------------------------------------");
        }

        public int GetNumberOfRequests()
        {
            int requestCount = validator.GetValidInteger("\nEnter the number of service requests: ", 1, 10);
            return requestCount;
        }

        public void ProcessRequests(List<ServiceRequest> serviceRequests)
        {
            bool processing = true;
            while (processing)
            {
                var pendingRequests = serviceRequests.Where(r => !r.isResolved).OrderByDescending(r => r.UrgencyScore).ToList();

                if (pendingRequests.Count == 0)
                {
                    Console.WriteLine("\nAll requests have been processed!");
                    break;
                }

                Console.WriteLine("\n===== Pending Service Requests =====");
                Console.WriteLine($"\n{"Request ID",-15} | {"Request Type",-20} | {"Urgency Score",-15}");
                Console.WriteLine("--------------------------------------------------------");
                foreach (var req in pendingRequests)
                {
                    Console.WriteLine($"{req.RequestId,-15} | {req.RequestType,-20} | {req.UrgencyScore,-15:F2}");
                }

                Console.WriteLine("--------------------------------------------------------");

                int suffix = validator.GetValidInteger("\nEnter the Request ID to process (or 0 to exit processing): 2138-nlmb-xx", 0, serviceRequests.Count);
                
                string selectedId = "2138-nlmb-xx" + suffix;
                Console.WriteLine(selectedId);

                if (suffix == 0) break;

                ServiceRequest requestToProcess = serviceRequests.FirstOrDefault(r  => r.RequestId == selectedId && !r.isResolved);

                if (requestToProcess != null)
                {

                    requestToProcess.isResolved = true;
                    manager.GenerateServiceReport(requestToProcess);
                }
                else
                {
                    Console.WriteLine("Invalid ID or request is already resolved. PLease try again.");
                }
            }
        }
    }
}
