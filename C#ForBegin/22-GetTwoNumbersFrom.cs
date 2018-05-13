using System;

namespace SampleCodes
{
  class Program

  {
      static void  Main(string[] args)
      {
          //Store those two numbers in string variables
          string str1 , str2;

      str1 = Console.ReadLine();
      str2 = Console.ReadLine();

      //Convert the string values entered by the user
      //into integer values


      int num1 , num2;
      num1 = Convert.ToInt32(str1);
      num2 = Convert.ToInt32(str2);

      int sum = num1 + num2;
      Console.WriteLine("The sum of {0} and {1} os {2}",num1,num2,sum);

      }
  }  
}