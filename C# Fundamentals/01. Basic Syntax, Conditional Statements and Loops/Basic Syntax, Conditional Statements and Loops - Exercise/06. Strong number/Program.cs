﻿using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int factorialSum = 0;
            while(numCopy > 0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;
                int factorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }
            if (factorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
