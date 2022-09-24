using System;
 namespace Guess
 {
  class GuessANumber
{
  static void Main(string[] args)
  {
   int guess = 0;
  int guessCount = 0;
  int secretNumber = new Random().Next(1,10);
   
   while(guess != secretNumber)
   {
    try{

   Console.WriteLine("Enter a number between 1 to 10");
    guess= Convert.ToInt32(Console.ReadLine());
  if(guess < secretNumber)
  {
   Console.WriteLine($"{guess} is too small");
   guessCount++;
   continue;
   }
  else if(guess > secretNumber)
   {
       Console.WriteLine($"{guess} is too large");
       guessCount++;
       continue;
   }
    }
    catch
    {
      Console.WriteLine("Not an integer, try again");
      guessCount++;
      continue;
    }
    guessCount++;
       Console.WriteLine("guessed correctly!,secret number was {0} " ,secretNumber);
       Console.WriteLine("It took you {0} {1}.\n", guessCount, guessCount==1?"try": "tries");
       break;
   }
}
};
 }

