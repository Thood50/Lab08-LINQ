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
            Prompt(data);
            Console.ReadLine();

        }

        public static Cities ReadJSON()
        {
            string path = "../../../../../Data.JSON";
            string json = File.ReadAllText(path);
            Cities data = JsonConvert.DeserializeObject<Cities>(json);

            return data;
        }

        public static void Prompt(Cities data)
        {
            Console.WriteLine("Welcome to Mannhatten? I think?");
            Console.WriteLine("Please enter what you would like to see!");
            Console.WriteLine("1. All Neighbor Hoods with no filter");
            Console.WriteLine("2. Neighbor Hoods with a proper name");
            Console.WriteLine("3. Proper and Unique Neighbor hoods");
            Console.WriteLine("4. Filter with one query");
            Console.WriteLine("5. Exit");
            string input = Console.ReadLine();
            Interface(data, input);            
        }

        public static void Interface(Cities data, string input)
        {
            switch (input)
            {
                case "1" :
                    Console.WriteLine("Neighbor Hoods : No Filter");
                    Console.WriteLine();
                    PrintAllNeighborHoods(data);
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to Main page");
                    Console.ReadLine();
                    Console.Clear();
                    Prompt(data);
                    break;

                case "2":
                    Console.WriteLine("Neighbor Hoods : with valid names");
                    Console.WriteLine();
                    PrintAllNeighborHoodsWithName(data);
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to Main page");
                    Console.ReadLine();
                    Console.Clear();
                    Prompt(data);
                    break;

                case "3":
                    Console.WriteLine("Neighbor Hoods : with valid names & no duplicates");
                    Console.WriteLine();
                    PrintUniqueNeighborHoods(data);
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to Main page");
                    Console.ReadLine();
                    Console.Clear();
                    Prompt(data);
                    break;

                case "4":
                    Console.WriteLine("One Query : with valid names & no duplicates");
                    Console.WriteLine();
                    OneQuery(data);
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to Main page");
                    Console.ReadLine();
                    Console.Clear();
                    Prompt(data);
                    break;

                case "5":
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Sorry we were unable to read your input");
                    Prompt(data);
                    break;
            }

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

        public static void PrintAllNeighborHoodsWithName(Cities data)
        {
            var selected = from x in data.Features
                           where x.Properties.Neighborhood != null
                           select x.Properties.Neighborhood;

            selected = selected.Where(x => x != "");
                           

            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }            
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

        public static void OneQuery(Cities data)
        {
            var selected = data.Features.Where(x => x.Properties.Neighborhood != null)
                                        .Where(x => x.Properties.Neighborhood != "")
                                        .GroupBy(g => g.Properties.Neighborhood)
                                        .Select(y => y.First());            

            foreach (var item in selected)
            {
                Console.WriteLine(item.Properties.Neighborhood);
            }
        }

        
    }
}
