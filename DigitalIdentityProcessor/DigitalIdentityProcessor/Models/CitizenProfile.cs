using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalIdentityProcessor.Models
{
    public class CitizenProfile
    {
        //
        public string FullName { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        // Constructor 
        public CitizenProfile(string fullName, string id, string citizenshipStatus)
        {
            FullName = fullName;
            ID = id;
            CitizenshipStatus = citizenshipStatus;

            CalculateAge();
        }

        public void CalculateAge()
        {
            if (string.IsNullOrWhiteSpace(ID) || ID.Length < 6)
            {
                Age = -1;
                return;
            }

            try
            {
                // Extract date of birth
                int yy = int.Parse(ID.Substring(0, 2));
                int mm = int.Parse(ID.Substring(2, 2));
                int dd = int.Parse(ID.Substring(4, 2));

                // Determine year based on yy
                int currentYear = DateTime.Now.Year % 100;
                int fullYear = (yy > currentYear) ? 1900 + yy : 2000 + yy;


                DateTime dateOfBirth = new DateTime(fullYear, mm, dd);
                DateTime today = DateTime.Today;

                // Determine citizens age
                int citizensAge = today.Year - dateOfBirth.Year;

                // Subtract a year if thier birthday has not occured yet
                if (dateOfBirth.Date > today.AddYears(-citizensAge))
                {
                    citizensAge--;
                }

                Age = citizensAge;
            }
            catch
            {
                Age = -1; 
            }
        }

        public string ValidateID()
        {
            if (string.IsNullOrEmpty(ID))
            {
                return "Invalid ID: ID Number cannot be empty.";
            }
            
            if (ID.Length != 13)
            {
                return "Invalid ID: ID Number must contain exactly 13 digits.";
            }

            if (!ID.All(char.IsDigit))
            {
                return "Invalid ID: ID Number must be only contain numbers.";
            }

            if (Age < 0 || Age > 120)
            {
                return "Invalid ID: Citizens age is invalid based on ID number.";
            }

            return $"Valid ID: Citizen is {Age} years old.";
        }

    }
}
