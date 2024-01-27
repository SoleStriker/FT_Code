using System;
using static System.Console;
using System.IO;
class WritePatientRecords
{
   static void Main()
   {
      // Write your code here
      const string END = "END";
      const string FILENAME = "Patients.txt";

      Patient patient = new Patient();
      FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
      StreamWriter writer = new StreamWriter(outFile);

      Write("Enter patient ID number or " + END + " to quit >> ");
      string id = ReadLine();
        while (id != END)
        {
             Write("Enter patient name >> ");
             string name = ReadLine();
             Write("Enter patient balance >> ");
             double balance = Convert.ToDouble(ReadLine());
             writer.WriteLine(id + "," + name + "," + balance);
             Write("Enter patient ID number or " + END + " to quit >> ");
             id = ReadLine();
        }
        writer.Close();
        outFile.Close();

      
   }
}

class Patient
{
    public string IdNumber {get; set;}
    public string Name {get; set;}
    public double Balance {get; set;}

    public new string ToString()
    {
        return IdNumber + " " + Name + " " + Balance.ToString("C");
    }
}
