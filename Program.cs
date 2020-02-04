using System;
using System.Diagnostics.Tracing;
using System.IO;

namespace EmailExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Training\EmailExtraction\EmailExtraction\Data\sample.txt";
            string text = ReadFile(path);
            Console.WriteLine(text);
        }
        /*start with main
         defined path to where file is 
         saving its repsonse to variable called text
         then print text 
         */
        private static string ReadFile(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }
        /*
         created new function called ReadFile
         defined a variable call path to where the file is
         called func called File.ReadAll and pass var path in barckets
         saved it into var text 
         then return txt
         */
    }
}