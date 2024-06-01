using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Please enter a number of inches.");
    
var X = Console.ReadLine();
    
var splitX = X.Split(' '); 
          // splitting the string into two parts, number and unit
var inches = (splitX[0]);
         // calling just the value of inches
    int numberInch;

  if(int.TryParse(inches, out numberInch)) {

       Console.WriteLine(numberInch * 2.54 + " centimeters");
    }
    else{
       Console.WriteLine("Please enter a valid number");
    };
  }
}