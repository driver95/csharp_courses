﻿using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
            };
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(days[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
