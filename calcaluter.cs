using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome To The Calcaluter!");

        while (true)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide");
            var choice = int.Parse(Console.ReadLine());

            double result = 0;
            switch (choice)
            {
                case 1: result = num1 + num2; break;
                case 2: result = num1 - num2; break;
                case 3: result = num1 * num2; break;
                case 4: result = num1 / num2; break;
                default: Console.WriteLine("Invalid choice."); continue;
            }

            Console.WriteLine($"Result: {result}");

            if (Console.ReadLine().ToUpper() != "Y")
                break;
        }
    }
}