using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ocular;
namespace LoadTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MAKE SURE OCULAR PROJECT FILE IS IN THE FOLDER THIS EXECUTABLE IS IN!");
            Ocular.FileLoader fd = new FileLoader(Environment.CurrentDirectory);
            FileLoader.FileData fida = fd.Execute();
            if (fida.IsValid != true)
            {
                Console.WriteLine("File invalid or not found.");
            }
            else
            {
                Console.WriteLine("--------------- " + fida.ProjectName + " Ocular Project ---------------");
                Console.WriteLine("Created with Ocular: " + fida.Version);
            }
            Console.ReadLine();
        }
    }
}
