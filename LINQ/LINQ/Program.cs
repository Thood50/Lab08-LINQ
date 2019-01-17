using System;
using System.IO;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void ReadJSON()
        {
            string path = "../../../data.json";
            string json = File.ReadAllText(path);
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

        }
    }
}
