﻿using System;

namespace TipCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      //Welcome the User
      Console.WriteLine("Welcome User!!!!");
      //Ask how much the bill
      Console.WriteLine("How much was your meal?");
      var total = Console.ReadLine();
      //calculate 18%
      var tip = double.Parse(total) * 0.18;
      // add the tip to the total
      var grandTotal = tip + double.Parse(total);
      //display the result
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("Your 18% tip is " + tip);
      Console.WriteLine("Grand total is " + grandTotal);

    }
  }
}
