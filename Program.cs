using BasicCalculator;
using System.Reflection;

namespace microsoft.botsay;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer (first operand)");

        bool firstOperandCheck = false;
        string? firstOperandString = "";

        while (!firstOperandCheck)
        {
            firstOperandString = Console.ReadLine();
            if (IsInteger(firstOperandString))
            {
                firstOperandCheck = true;
            }
            else
            {
                Console.WriteLine("Error: Please enter an integer (first operand)");
            }
        }

        int firstOperand = int.Parse(firstOperandString);
        Console.WriteLine("First Operand: " + firstOperand);

        Console.WriteLine("Enter an operator (+, -, / or *)");

        bool operatorCheck = false;
        string? operatorString = "";
        Operator op;

        while (!operatorCheck)
        {
            operatorString = Console.ReadLine();
            try
            {
                op = Operator.CreateOperatorFromString(operatorString);
                operatorCheck = true;
            }
            catch
            {
                Console.WriteLine("Error: Please enter a valid operator (+, -, / or *)");
            }
        }

    }

    private static bool IsInteger(string input)
    {
        return int.TryParse(input, out int n);
    }
}