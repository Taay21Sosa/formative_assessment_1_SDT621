using System;

class GradeCalculator
{
    static void GetStudentsResults(double[] marks)
    {
        double total = marks[0] + marks[1] + marks[2];
        double average = total / 3;
        string status = (average >= 50) ? "PASS" : "FAIL";
    }

    static double GetValidMark(string prompt)
    {
        double mark;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out mark) && mark >= 0 && mark <= 100)
            {
                return mark;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input! Please enter a numeric value between 0 and 100.");
            Console.ResetColor();
        }
    }

    static void Main(string[] args)
    {
        // Programs welcome message
        Console.WriteLine("======================================");
        Console.WriteLine("       STUDENT GRADING SYSTEM          ");
        Console.WriteLine("======================================\n");

        // Prompt user to enter a students name
        Console.Write("Enter students name: ");

        // Variable to store student name
        string studentName = Console.ReadLine();

        double[] marks = new double[3];
        string[] subjects = { "Subject 1", "Subject 2", "Subject 3" };

        for (int i = 0; i < 3; i++)
        {
            marks[i] = GetValidMark($"Enter marks for {subjects[i]}: ");
        }

        double totalMark = marks[0] + marks[1] + marks[2];
        double averageMark = totalMark / 3;
        string finalResult = (averageMark >= 50) ? "PASS" : "FAIL";

        // Print students results
        Console.WriteLine("\n===== STUDENT RESULTS =====\n");
        Console.WriteLine($"Student name: {studentName}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"{subjects[0],-15}: {marks[0],6:F2}");
        Console.WriteLine($"{subjects[1],-15}: {marks[1],6:F2}");
        Console.WriteLine($"{subjects[2],-15}: {marks[2],6:F2}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Total marks: {totalMark}/300");
        Console.WriteLine($"Average marks: {averageMark:0.0}");
        Console.WriteLine($"Result: {finalResult}");
        Console.WriteLine($"Result issued at: {DateTime.Now}");
        Console.WriteLine("======================================");


    }
}
