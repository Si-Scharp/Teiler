using System;

namespace MyMath
{

    class MyMath
    {
        static void Main(string[] args)
        {
        }

        public static ulong ggt (ulong a, ulong b)
        {
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public static ulong kgt(ulong a)
        {
            for (ulong i = 2; true; i++)
                if (a % i == 0) return i;
        }
        /*
        public static int getRestVonDivision(int dividend, int divisor)
        {
            while (dividend >= divisor)
            {
                dividend -= divisor;
            }
            return dividend;
        }
        */
    }
}
