using System;
using System.Globalization;
using System.IO;

class Program
{
    static void Main()
{
   Console.Write("Enter patient ID number to find >> ");
   string inputId = Console.ReadLine();

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
               string idFromFile = parts[0].Trim().ToLower();
               string trimmedInputId = inputId.Trim().ToLower();

               if (int.TryParse(idFromFile, out int idFromFileAsInt) &&
                  int.TryParse(trimmedInputId, out int trimmedInputIdAsInt) &&
                  idFromFileAsInt == trimmedInputIdAsInt)
               {
                  DisplayRecord(parts);
                  recordFound = true;
                  break;
               }
           }
       }

       if (!recordFound)
       {
           Console.WriteLine($"No records found for {inputId}");
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
