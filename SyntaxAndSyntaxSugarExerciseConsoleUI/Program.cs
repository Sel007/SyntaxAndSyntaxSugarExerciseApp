using System;

namespace SyntaxAndSyntaxSugarExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            var answer = double.Parse(Console.ReadLine());

            Console.WriteLine();

            var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
