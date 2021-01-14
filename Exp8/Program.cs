using System;
using System.Collections;
using System.Collections.Generic;


namespace Collection_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();

            // Adding content in arraylist

            l.Add(23);
            l.Add(34);
            l.Add(12);
            l.Add(56);
            l.Add(89);
            l.Add(4);
            l.Add(67);
            l.Add(89);

           

            //capacity of an arraylist

            Console.WriteLine("Capcity of an array:"+l.Capacity);

            Console.WriteLine("Count:"+l.Count);

            //content
            Console.Write("Content i arrayList:");
            foreach(int i in l)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sorted Elements:");
            l.Sort();

            foreach (int i in l)
            {
                Console.Write(i + " ");
            }


            var names = new List<string>();

            names.Add("A");
            names.Add("X");
            names.Add("F");
            names.Add("K");

            Console.Write("\nCapacity:"+names.Capacity);

            Console.Write("\nCount:"+names.Count);

            // traverse
            Console.Write("\nContent:");
            foreach(var name in names)
            {
                Console.Write(name+ " ");
            }

            Console.Write("\nSort:");
            names.Sort();

            foreach(var name in names )
            {
                Console.Write(name+ " ");
            }

            Console.ReadLine();





        }
    }

    internal class List
    {
    }
}
