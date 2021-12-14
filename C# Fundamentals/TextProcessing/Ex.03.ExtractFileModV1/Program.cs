using System;

namespace Ex._03.ExtractFileModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileDirectory = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries); //Revisit escaping 
            string[] fileData = fileDirectory[fileDirectory.Length - 1].Split('.');
            string fileName = fileData[0];
            string extentionType = fileData[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extentionType}");
        }
    }
}
