using System;

System.Console.WriteLine("Type here first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type here second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{firstNumber + secondNumber}");
System.Console.WriteLine($"{firstNumber / secondNumber}");
System.Console.WriteLine($"{firstNumber * secondNumber}");
System.Console.WriteLine($"{firstNumber - secondNumber}");

// System.Console.WriteLine($"1st number is bigger than 2nd number: {firstNumber > secondNumber}");
// System.Console.WriteLine($"1st number is smaller than 2nd number: {firstNumber < secondNumber}");
// System.Console.WriteLine($"1st number is equal  to 2nd number: {firstNumber == secondNumber}");
// System.Console.WriteLine($"1st number is bigger  or  equal than 2nd number: {firstNumber >= secondNumber}");
// System.Console.WriteLine($"1st number is smaller or equal than 2nd number: {firstNumber <= secondNumber}");
// System.Console.WriteLine($"1st number is not equal to 2nd number: {firstNumber != secondNumber}");