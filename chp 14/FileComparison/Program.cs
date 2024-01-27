using System;
using static System.Console;
using System.IO;

class FileComparison
{
   static void Main()
   {
      // Write your code here
        FileInfo textFileInfo = new FileInfo("Quote.txt");
        FileInfo docxFileInfo = new FileInfo("Quote.docx");

        long size = textFileInfo.Length;
        long size2 = docxFileInfo.Length;

        double ratio = (double)size / size2;


        // if (size == size2)
        // {
        //     WriteLine("The files are the same size.{0}", ratio);
        // }
        // else
        // {
        //     WriteLine("The files are not the same size.{0}", ratio);
        // }
        DisplayComparison(size, size2, ratio);

   }
   public static void DisplayComparison(long size, long size2, double ratio)
   {
      // Write your code here
      WriteLine("The size of the word file is {0}", size);
      WriteLine("and the size of the Notepad file is {0}", size2);
      WriteLine("The Notepad file is {0} times larger than the Word file.", ratio);
   }
}