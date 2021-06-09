using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Linus Torvalds");
            names.Add("Donald Knuth");
            names.Add("Grace Hopper");
            names.Add("Donald Knuth");
            names.Add("Jean Bartik");
            names.TrimExcess();
            names.RemoveAt(3);
            names.Remove("Donald Knuth");

            for (int i = 0; i < names.Count; ++i)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Count of list: " + names.Count);
            Console.WriteLine("Capacity of list: " + names.Capacity);

            
        }
    }
}
