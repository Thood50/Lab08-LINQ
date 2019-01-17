using System;
using System.IO;
using LINQ.Classes;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cities data = ReadJSON();

        }

        public static Cities ReadJSON()
        {
            string path = "../../../data.json";
            string json = File.ReadAllText(path);
            Cities data = Newtonsoft.Json.JsonConvert.DeserializeObject<Cities>(json);

            return data;
        }
    }
}
