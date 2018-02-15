﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int number = Convert.ToInt16(Console.ReadLine());

            int result = Prime_check(number);
            if (result==0)
            {
                Console.WriteLine("Number is not Prime");
            }
            else
            {
                Console.WriteLine("Number is Prime");
            }
            Console.ReadLine();

        }
        private static int Prime_check(int number)
        {
            int i;
            for (i = 2; i < number - 1; i++)
            {
                if (number%i==0)
                {
                    return 0;
                }
            }
            if (i==number)
            {
                return 1;
            }
            return 0;
        }
    }
}
