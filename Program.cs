using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = new List<string>();

            rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            foreach (var item in rockyPlanets)
            {
                Console.WriteLine(item);
            }

            var spacecrafts = new Dictionary<string, List<string>>();

            spacecrafts.Add("Mercury", new List<string>{"Mariner 10", "Messenger", "BepiColombo"});
            spacecrafts.Add("Venus", new List<string> { "Mariner 2", "Mariner 5" });
            spacecrafts.Add("Mars", new List<string> { "Mariner 4", "Mariner 6" });
            spacecrafts.Add("Jupiter", new List<string> { "Juno", "New Horizons" });
            spacecrafts.Add("Uranus", new List<string> { "Voyager 2" });
            spacecrafts.Add("Neptune", new List<string> { "Voyager 2" });
            spacecrafts.Add("Pluto", new List<string> { "New Horizons" });

            foreach (var key in spacecrafts.Keys)
            {
                Console.WriteLine($"{key}");
                foreach (var value in spacecrafts[key])
                {
                    Console.WriteLine($"Planet: {key} Shuttle: {value}");
                }
            }

            
        }
    }
}
