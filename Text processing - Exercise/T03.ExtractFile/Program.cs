using System;

namespace T03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            string fileName = string.Empty;
            string fileExtension = string.Empty;

            string[] fileProperties = filePath.Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string fileNameAndExtensions = fileProperties[fileProperties.Length - 1];

            string[] filePropertiesAdvanced = fileNameAndExtensions.Split('.', StringSplitOptions.RemoveEmptyEntries);

            fileName = filePropertiesAdvanced[0];
            fileExtension = filePropertiesAdvanced[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
