using System;
using static System.Console;
using System.IO;
class DirectoryInformation
{
    static void Main()
    {
        // Write your code here
        string directoryString;
        
        while (true)
        {
            WriteLine("Enter a directory: or type end to quit. ");
            directoryString = ReadLine();

            if (directoryString == "end" )
            {
                break;
            }

            if (Directory.Exists(directoryString))
            {
                WriteLine($"{directoryString} contains the following files");
                foreach (var file in Directory.GetFiles(directoryString))
                {
                    WriteLine($" {file}");
                }
            }

            else 
            {
                WriteLine($"Directory {directoryString} does not exist");
            }
        }
       
    }
    
}