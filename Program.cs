using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProvider data = new DataProvider();
            Console.WriteLine(DataProvider.GetConfig().Brauser);
        }
    }
}
