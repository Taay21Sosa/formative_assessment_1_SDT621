using MunicipalitySystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalitySystem.Services
{
    public class UtilitiesManager
    {
        /*
         * Calculates the requests urgency score based on priority, severity, and time.
         * A higher score, the higher the urgency for the request.
         */
        public double CalculateUregencyScore(ServiceRequest request)
        {
            double score = (request.PriorityLevel * 10) + (request.SeverityLevel * 5) - (request.EstimatedResolutionTime * 0.5);
            return Math.Max(0, score);
        }

        /*
         * 
         */
        public void GenerateServiceReport(ServiceRequest request)
        {
            Console.WriteLine("\n===== Service Request Report =====");
            Console.WriteLine("--- Resident Details ---");
            Console.WriteLine($"Name: {request.RequestingResident.Name}");
            Console.WriteLine($"Address: {request.RequestingResident.Address}");
            Console.WriteLine($"Account number: {request.RequestingResident.AccountNumber}");


            Console.WriteLine("\n--- Request Details ---");
            Console.WriteLine($"Request ID: {request.RequestId}");
            Console.WriteLine($"Request type: {request.RequestType}");
            Console.WriteLine($"Priority level: {request.PriorityLevel}");
            Console.WriteLine($"Severity level: {request.SeverityLevel}");
            Console.WriteLine($"Est. time: {request.EstimatedResolutionTime} hours");

            Console.WriteLine("\n--- Current Status ---");
            Console.WriteLine($"Urgency score: {request.UrgencyScore}");
            Console.WriteLine($"Status: {(request.isResolved ? "Resolved" : "In Progress")}");
            Console.WriteLine("--------------------------------------------------------");

        }

        /*
         * 
         */
        public void GenerateFinalSummary(List<ServiceRequest> serviceRequests)
        {
            var resolvedRequests = serviceRequests.Where(r => r.isResolved).ToList();


            Console.WriteLine("\n===== Final Summary =====");
            if (resolvedRequests.Count > 0)
            {
                Console.WriteLine("\nResolved Requests List:");
                Console.WriteLine($"\n{"Request ID",-15} | {"Resident",-5} | {"Request Type",-20} | {"Priority",-3} | {"Severity",-3} | {"Est. Time",-10} | {"Urgency Score",-5} | {"Status",-5} ");
                Console.WriteLine("--------------------------------------------------------\n");
                foreach (var req in resolvedRequests)
                {
                    Console.WriteLine($"\n{req.RequestId,-15} | {req.RequestingResident.Name,-10} | {req.RequestType,-15} | {req.PriorityLevel,-3} | {req.SeverityLevel,-3} | {req.EstimatedResolutionTime,-10} | {req.UrgencyScore,-5} | {req.isResolved,-5} ");
                }
                Console.WriteLine("--------------------------------------------------------");

                Console.WriteLine($"\nTotal Requests Resolved: {resolvedRequests.Count}");

                // Highlights the highest urgency score
                ServiceRequest highestUrgency = resolvedRequests.OrderByDescending(r => r.UrgencyScore).First();

            }

        }
    }
}
