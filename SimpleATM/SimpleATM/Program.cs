using System;

class SimpleATM
{
    static double GetValidValue(string prompt)
    {
        double amount;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out amount) && amount >= 0)
            {
                return amount;
            }

            DisplayError("Invalid amount entered! Please enter a real amount.");
        }
    }

    static double WithdrawTransaction(double currentBalance, double withdrawlAmount)
    {
        if (withdrawlAmount > currentBalance)
        {
            DisplayError("Transaction declined: Insufficent funds.");
        }
        else if (withdrawlAmount <= 0)
        {
            DisplayError("Transaction declined: Invalid amount.");
        }
        else
        {
            currentBalance -= withdrawlAmount;

            Console.WriteLine("\n-----------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Transaction successful");
            Console.ResetColor();


        }

        return currentBalance;
    }

    static void DisplayError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    static void Main(string[] args)
    {
        // 
        Console.WriteLine("====================================");
        Console.WriteLine("***     SIMPLE ATM SYSTEM       ***");
        Console.WriteLine("====================================\n");

        // 
        Console.Write("Hi, What's your name?\n> ");

        // 
        string name = Console.ReadLine();

        Console.WriteLine("\n-----------------------------");
        Console.WriteLine($"Welcome {name.ToUpper()}");

        double currentBalance = GetValidValue("\nEnter account balance: ");
        double withdrawalAmount = GetValidValue("Enter withdrawl amount: ");

        currentBalance = WithdrawTransaction(currentBalance, withdrawalAmount);

        // 
        Console.WriteLine("\n===== Transaction Receipt =====");
        Console.WriteLine($"\nWithdrawl nAmount: {withdrawalAmount,15:C}");
        Console.WriteLine($"Updated Balance: {currentBalance,15:C}");
        Console.WriteLine($"Transaction Time : {DateTime.Now}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine("\nThank you for using SIMPLE ATM SYSTEM.");
    }
}
