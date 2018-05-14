using System;

namespace SampleCodes
{
  class Program

  {
      static void  Main(string[] args)
      {
       int answer = 2;
       switch (answer)
       {
           case 1:
           case 2:
           Console.WriteLine("the answer was 1 or 2");
           
           case 3:
           case 4:
           Console.WriteLine("the answer was more than 2");
           break;
       }


      }
  }  
}