using System;

namespace SampleCodes
{
  class Program

  {
      static void  Main(string[] args)
      {
          int age = 30;
          int thisYear = DateTime.Now.Year;
          int YearBorn = thisYear-age;
          Console.WriteLine('You were Born in' + YearBorn);
      }
  }  
}