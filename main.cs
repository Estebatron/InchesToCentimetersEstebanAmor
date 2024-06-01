using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Please enter a number in inches.");
    
var inches = Console.ReadLine();

  char seperator = " "
  int maxSubstrings = 1;
    
var justNumber = inches.Split(seperator, maxSubstrings);
int numberInch;
    
  if(int.TryParse(justNumber, out numberInch)) {

       Console.WriteLine(numberInch * 2.54 + " centimeters");
    }
    else{
       Console.WriteLine("Please enter a valid number");
    };
  }
}