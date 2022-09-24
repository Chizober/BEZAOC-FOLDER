using System;
 namespace LeapYear
 {
 class FindLeapYear
{
  public  static void Main(string[] args)
  {
    int currentYear = 2021;
    int  total = 20;
    int count = 0;
   while (count < total)
   {
   currentYear = currentYear += 1;
     if((currentYear % 4 == 0) && (currentYear  % 100 != 0) || (currentYear % 400 == 0))
     {
      count +=1;
     Console.WriteLine($"{currentYear} is a leap");
     };
  
   }
  }
}};
