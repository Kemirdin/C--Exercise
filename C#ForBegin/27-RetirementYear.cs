using System;

namespace SampleCodes
{
  class Program

  {
      static void  Main(string[] args)
      {
          const int retirement = 65;

          int myAge = 25;
          int yourAge = 33;

          string message = " Will we be ready to retire soon?";

          int yearToRetirementForYou = retirement - yourAge;
          int yearToRetirementForMe = retirement - myAge;
     Console.WriteLine("Years for you: " + yearToRetirementForYou);
     Console.WriteLine("Years for me :{0}",yearToRetirementForMe);
      }
  }  
}