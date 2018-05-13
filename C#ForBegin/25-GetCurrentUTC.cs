using System;

namespace SampleCodes
{
  class Program

  {
      static void  Main(string[] args)
      {
     Console.WriteLine(DateTime.Now.ToLongDateString());
     Console.WriteLine(DateTime.UtcNow.ToLongDateString());
      }
  }  
}