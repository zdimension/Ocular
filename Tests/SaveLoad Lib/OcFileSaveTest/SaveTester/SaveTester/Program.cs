using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ocular;
namespace SaveTester
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSaver fs = new FileSaver(Environment.CurrentDirectory, "OcTest", "0.0.1.pre");
            Console.ReadLine();
        }
    }
}
