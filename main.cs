using System;

class Program {
  public static void Main (string[] args) {
   
    // Prompt for input
    Console.Write("Enter the number of hours for the job: ");
    double hours = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the number of miles for the move: ");
    double miles = Convert.ToDouble(Console.ReadLine());

    // Calculate moving fee
    double baseRate = 200;
    double hourlyRate = 150;
    double mileageRate = 2;

    double total = baseRate + (hours * hourlyRate) + (miles * mileageRate);

    // Display the result
    Console.WriteLine($"Total moving fee: ${total:F2}");
    
  }
}