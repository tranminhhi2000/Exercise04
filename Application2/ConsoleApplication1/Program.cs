﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alo Alo");
        }

        //public static bool IsOdd(int n)
        //{
        //    if (n % 2 != 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
