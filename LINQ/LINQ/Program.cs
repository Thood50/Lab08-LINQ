using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LINQ.Classes;


namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cities data = ReadJSON();
            PrintData(data);
            Console.ReadLine();

        }

        public static Cities ReadJSON()
        {
            string path = "../../../../../Data.JSON";
            string json = File.ReadAllText(path);
            Cities data = JsonConvert.DeserializeObject<Cities>(json);

            return data;
        }

        public static void PrintData(Cities data)
        {
            var selected = from x in data.Features
                           where x.Properties.Neighborhood != null
                           select x.Properties.Neighborhood;
            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }
            
        }

        
    }
}
