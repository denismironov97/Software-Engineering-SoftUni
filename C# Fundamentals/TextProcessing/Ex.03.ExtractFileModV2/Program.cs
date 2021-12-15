using System;
using System.Linq;

namespace Ex._03.ExtractFileModV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileDirectoryPath = Console.ReadLine().Split('\\');

            //string fileNameAndExtension = fileDirectoryPath.Last();
            //string[] fileParts = fileNameAndExtension.Split('.');

            var fileParts = fileDirectoryPath.Last().Split('.');
            string extension = fileParts.Last();
            string fileName = fileDirectoryPath.Last().Replace($".{extension}", "");
            Console.WriteLine($"File name: { fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
