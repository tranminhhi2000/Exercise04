using System;
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

        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
                return false;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }
        // input: float x
        // output: int a that is smallest but not smaller than x
        // idea: a = (int)x then a = a + 1
        // if x is negative then a is unchanged
        // if x == a then a is unchanged
        public static int Ceil(float x)
        {
            int a = (int)x;
            if (x > 0)
                if(x > a)
                a = a + 1;
            return a;
        }

        // input: float x
        // output: int a that is largest but not bigger than x
        // idea: a = (int) x
        // if x is negative then a = a - 1
        // if x == a then a is unchanged
        public static int Floor(float x)
        {
            int a = (int)x;
            if (x < 0 && x != a)
                    a = a - 1;
            return a;
        }

        // idea: return a random value between 0 and 2^31-1
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i < n; i++) if (n % i == 0)
                {
                    return false;
                }
            return true;
        }
        public static int Pow(int x, int y)
        {
            int rs = 1;
            for (int i = 1; i <= y; i++)
                rs = rs * x;
            return rs;
        }
        public static int Square(int n)
        {
            return n * n;
        }
        public static long Factorial(long n)
        {
            int F = 1;
            for (int i = 2; i < n; i++)
                F = F * i;
            return F;
        }
        public static int Rand1()
        {
            Random rd = new Random();
            int n = rd.Next();
            return n;
        }
        public static float Rand2()
        {
            Random rd = new Random();
            float r = rd.Next() % (0.1F) + (float)rd.Next(0, 1);
            return r;
        }
    }
}
