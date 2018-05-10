using System;

namespace SampleCodes
{
    class myMath
    {
        public int mySum(int a,int b)
        {
            return a+b;        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Math a = new SampleCodes.myMath();
          a.mySum(25,30);
        }
    }
}