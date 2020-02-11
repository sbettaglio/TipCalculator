using System;

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
      //How was the service?
      Console.WriteLine("How was your service?");
      Console.WriteLine("Was it okay, good or great?");
      var service = Console.ReadLine();
      //okay, good, great, default

      //calculate the tip based on the level service
      var tipPercentage = 0.15;
      if (service == "okay")
      {
        tipPercentage = 0.18;
      }
      else if (service == "good")
      {
        tipPercentage = 0.20;
      }
      else if (service == "great")
      {
        tipPercentage = 0.25;
      }

      //calculate 18%
      var tip = double.Parse(total) * tipPercentage;
      // add the tip to the total
      var grandTotal = tip + double.Parse(total);
      //display the result
      //tipPercent * 100 will give you the correct value
      var tipToDisplay = tipPercentage * 100;
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("Your " + tipToDisplay + "% tip is " + tip);
      Console.WriteLine("Grand total is " + grandTotal);

    }
  }
}
