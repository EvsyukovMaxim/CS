﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Number__1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            List<int> integersDouble = new List<int>();
            int n = Convert.ToInt32(Console.ReadLine());

            while (n != -1)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (integers.Contains(n))
                {

                    integersDouble.Add(n);
                }
                integers.Add(n);
            }

            for (int i = 0; i < integersDouble.Count; i++)
            {
                Console.Write("Это будлирующиеся значенияЖ " + integersDouble[i] + " ");

            }

        }
    }
}
