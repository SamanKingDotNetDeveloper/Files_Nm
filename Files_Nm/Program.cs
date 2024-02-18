using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Files_Nm
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            DirectoryInfo directory = new DirectoryInfo("D:/Darslar C#/Muhammadkarim ustozimning darslari/");
            FileInfo[] fileInfo = directory.GetFiles();
            for(int i = 0; i < fileInfo.Length; i++)
            {
                Console.WriteLine($"{i} - {fileInfo[i].Name}");
            }
            Console.ReadKey();
        }
    }
}
