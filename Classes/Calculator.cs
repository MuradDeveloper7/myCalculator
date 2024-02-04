
namespace Calculator.Classes
{
    public class Calculatorr
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.WriteLine("Enter your 1st number");
            FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your operation (+,-,/,*,%)");
            Operation = Console.ReadLine()!;

            Console.WriteLine("Enter your 2nd number");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }

        public void CompareInputs()
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine($"1st number is greater than 2nd number");
            }
            else if (FirstNumber < SecondNumber)
            {
                Console.WriteLine($"2nd number is greater than 1st number");

            }
            else
            {
                Console.WriteLine($"2nd number adn  1st number are equal");

            }
        }

        public string Calculate()
        {
            return Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                _ => "Operation not found!"
            };
        }

        public void PrintEvenNumbers()
        {
            Console.WriteLine("Print even numbers till first input...");
            int counter = 2;
            while (counter < FirstNumber)
            {
                Console.WriteLine(counter);
                counter += 2;
            }
        }

        public void PrintMultiplicationTable()
        {
            for (int iteration = 0; iteration <= 10; iteration++)
            {
                for (int InnerIteration = 1; InnerIteration <= 10; InnerIteration++)
                {
                    Console.WriteLine($"{iteration} x {InnerIteration} = {iteration * InnerIteration}");
                }
                Console.WriteLine("\n");
            }
        }


    }
}

