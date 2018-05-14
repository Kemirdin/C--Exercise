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
           Console.WriteLine("the answer was 1");
           break;
           case 2:
           Console.WriteLine("the answer was 2");
           break;
             
           default:
           Console.WriteLine("the answer was more than 2");
           break;
       }


      }
  }  
}