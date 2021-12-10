using System;

namespace Ex._03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileDirectory = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] fileData = new string[] { fileDirectory[fileDirectory.Length - 1] };
            string fileData = fileDirectory[fileDirectory.Length - 1];
            string[] fileNameAndExtension = fileData.Split('.');
            Console.WriteLine($"File name: {fileNameAndExtension[0]}");
            Console.WriteLine($"File extension: {fileNameAndExtension[1]}");
        }
    }
}
