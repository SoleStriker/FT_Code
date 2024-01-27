using System;
using System.Globalization;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter minimum balance due to find records (numeric value) >> ");
        if (decimal.TryParse(Console.ReadLine(), out decimal minBalance))
        {
            string filePath = "Patients.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                bool recordFound = false;
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length > 0)
                    {
                        if (decimal.TryParse(parts[2], out decimal balance) && balance >= minBalance)
                        {
                            DisplayRecord(parts);
                            recordFound = true;
                        }
                    }
                }

                if (!recordFound)
                {
                    Console.WriteLine($"No records found with a balance greater than or equal to {minBalance:C}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: Patients.txt not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for the minimum balance.");
        }
    }

    static void DisplayRecord(string[] parts)
    {
        Console.WriteLine("{0,-10} {1,-20} {2,-10}", "ID Number", "Name", "Balance");

        if (decimal.TryParse(parts[2], out decimal balance))
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10}", parts[0], parts[1], balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }
        else
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10}", parts[0], parts[1], "Invalid Balance");
        }
    }
}
