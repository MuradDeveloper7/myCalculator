using System;
using Calculator.Classes;


internal class Program
{
    private static void Main(string[] args)
    {
        Security security = new Security();
        Calculatorr calculatorr = new Calculatorr();

        security.CheckPassword();
        calculatorr.GetInputs();


        string message =
            !(calculatorr.IsFirstNumberPositive())
            ? "1st number is not positive"
            : "2nd number is not positive";
        Console.WriteLine(message);

        calculatorr.CompareInputs();
        string result = calculatorr.Calculate();
        Console.WriteLine(result);
        calculatorr.PrintEvenNumbers();
        calculatorr.PrintMultiplicationTable();


    }
}