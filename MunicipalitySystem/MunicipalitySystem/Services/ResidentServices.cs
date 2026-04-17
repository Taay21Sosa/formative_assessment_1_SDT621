using MunicipalitySystem.Models;
using MunicipalitySystem.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalitySystem.Services
{
    public class ResidentServices
    {
        ValidationUtility validator = new ValidationUtility();

        public void RegisterResidents(int i, List<Resident> residents)
        {
            Console.WriteLine($"\n--- Resident {i} ---");
            Resident newResident = new Resident();

            Console.Write("ID: ");
            newResident.ID = Console.ReadLine();

            Console.Write("Name: ");
            newResident.Name = Console.ReadLine();

            Console.Write("Address: ");
            newResident.Address = Console.ReadLine();

            Console.Write("Account number: ");
            newResident.AccountNumber = Console.ReadLine();

            newResident.MonthlyUtilityUsage = validator.GetValidDouble("Monthly Utility Usage: ");

            residents.Add(newResident);
            Console.WriteLine("--------------------------------------------------------");
        }

        public int GetNumberOfResidents()
        {
            int residentCount = validator.GetValidInteger("\nEnter the number of residents: ", 1, 10);
            return residentCount;
        }
    }
}
