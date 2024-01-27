using System;
using System.IO;
using static System.Console;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
class ReadPatientRecords
{
   
   static void Main()
   {
      // Write your code here
      string FILENAME = "Patients.txt";
   
      if (File.Exists(FILENAME))
      {
         using (StreamReader reader = new StreamReader(FILENAME))
         {
            string fileContent = reader.ReadToEnd();

            WriteLine("File Content: {0} ", fileContent);
         }
      }
      else 
      {
         WriteLine("File Not Found: "+ FILENAME);
      }
   }
   Patient patient = new Patient();
}


class Patient
{
   public string IdNumber { get; set; }
   public string Name { get; set; }
   public double Price { get; set; }
   
   public new string ToString()
   {
      return IdNumber + " " + Name + " " + Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
   }
   
}