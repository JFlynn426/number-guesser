using System;

namespace number_guesser
{
  class Program
  {


    static void Main(string[] args)
    {
      var Answer = "Yes";
      while (Answer == "Yes")
      {
        Console.WriteLine("Pick a number between 1 and 100. Are you ready? Yes or No");
        var Ready = Console.ReadLine();
        if (Answer == "Yes")
        {
          var Continue = true;
          var HighestGuess = 100;
          var LowestGuess = 1;
          var Guess = 50;
          Console.WriteLine($"Is your number higher, lower or equal to {Guess}");
          while (Continue)
          {
            var Input = Console.ReadLine();
            if (Input == "lower")
            {
              HighestGuess = Guess;
              Guess = (HighestGuess + LowestGuess) / 2;
              Console.WriteLine($"Is your number higher, lower or equal to {Guess}?");

            }
            if (Input == "higher")
            {
              LowestGuess = Guess;
              Guess = (HighestGuess + LowestGuess) / 2;
              Console.WriteLine($"Is your number higher, lower or equal to {Guess}");

            }
            if (Input == "equal")
            {
              Continue = false;
              Console.WriteLine("Got your number! Try again? Yes or No?");
              Answer = Console.ReadLine();
              if (Answer == "Yes")
              {
                Continue = true;
                HighestGuess = 100;
                LowestGuess = 1;
                Guess = 50;
              }
              else if (Answer == "No")
              {
                Console.WriteLine("I could put strychnine in the guacamole");
              }
            }
          }
        }
      }
    }
  }
}
/*first guess should be between 1-100, if the number is higher then it should be between 100 and the previous guess if it is higher still then it should be in the middle of 50 and 100 if it is higher still it should be between 75 and 100 */
