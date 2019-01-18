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
            //PrintAllNeighborHoods(data);
            //PrintAllNeighborHoodsWithName(data);
            PrintUniqueNeighborHoods(data);
            Console.ReadLine();

        }

        public static Cities ReadJSON()
        {
            string path = "../../../../../Data.JSON";
            string json = File.ReadAllText(path);
            Cities data = JsonConvert.DeserializeObject<Cities>(json);

            return data;
        }

        public static void PrintAllNeighborHoods(Cities data)
        {
            var selected = from x in data.Features
                           where x.Properties.Neighborhood != null
                           select x.Properties.Neighborhood;

            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }

            
        }

        public static dynamic PrintAllNeighborHoodsWithName(Cities data)
        {
            var selected = from x in data.Features
                           where x.Properties.Neighborhood != null
                           select x.Properties.Neighborhood;

            selected = selected.Where(x => x != "");
                           

            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }

            return selected;
        }

        public static void PrintUniqueNeighborHoods(Cities data)
        {
            var selected = from x in data.Features
                           where x.Properties.Neighborhood != null
                           select x.Properties.Neighborhood;

            selected = selected.Where(x => x != "");

            selected = selected.Distinct();

            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }            
        }

        
    }
}
