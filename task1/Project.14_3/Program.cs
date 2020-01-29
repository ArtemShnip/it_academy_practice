using System;
using System.Collections.Generic;
using System.Linq;

namespace Project._14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> neighbors = new List<Neighbor>();
            neighbors.Add(new Neighbor() { FullName = "Ivanov" , FlatNumber =24 , PhoneNumber = 296543215 });
            neighbors.Add(new Neighbor() { FullName = "Petrov", FlatNumber = 25, PhoneNumber = 296543215 });
            neighbors.Add(new Neighbor() { FullName = "Sokolov", FlatNumber = 27, PhoneNumber = 296543215 });
            neighbors.Add(new Neighbor() { FullName = "Kuznecov", FlatNumber = 28, PhoneNumber = 296543215 });
            Console.WriteLine("Enter flat number");
            int flat = int.Parse(Console.ReadLine());
            var selected = from Neighbor in neighbors
                               where Neighbor.FlatNumber == flat
                               select Neighbor;
            foreach (Neighbor neighbor in selected)
                Console.WriteLine($"Phone: +375{neighbor.PhoneNumber}, name: {neighbor.FullName}");
        }
    }
}
