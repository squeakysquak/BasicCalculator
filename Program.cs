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
#pragma warning disable CS8604 // Possible null reference argument.
            if (IsInteger(firstOperandString))
            {
                firstOperandCheck = true;
            }
            else
            {
                Console.WriteLine("Error: Please enter an integer (first operand)");
            }
#pragma warning restore CS8604 // Possible null reference argument.
        }

        int firstOperand = int.Parse(firstOperandString);
        Console.WriteLine("First Operand: " + firstOperand);

        Console.WriteLine("Enter an operator (+, -, / or *)");

        bool operatorCheck = false;
        string? operatorString = "";
        Operator? op = null;

        while (!operatorCheck)
        {
            operatorString = Console.ReadLine();
            try
            {
#pragma warning disable CS8604 // Possible null reference argument.
                op = Operator.CreateOperatorFromString(operatorString);
#pragma warning restore CS8604 // Possible null reference argument.
                Console.WriteLine("Operator: " + op.ToString());
                operatorCheck = true;
            }
            catch
            {
                Console.WriteLine("Error: Please enter a valid operator (+, -, / or *)");
            }
        }

        Console.WriteLine("Enter an integer (second operand)");

        bool secondOperandCheck = false;
        string? secondOperandString = "";

        while (!secondOperandCheck)
        {
            secondOperandString = Console.ReadLine();
#pragma warning disable CS8604 // Possible null reference argument.
            if (IsInteger(secondOperandString))
            {
                secondOperandCheck = true;
            }
            else
            {
                Console.WriteLine("Error: Please enter an integer (second operand)");
            }
#pragma warning restore CS8604 // Possible null reference argument.
        }

        int secondOperand = int.Parse(secondOperandString);
        Console.WriteLine("Second Operand: " + secondOperand);

        if (op != null)
        {
            try
            {
                int result = op.DoOperation(firstOperand, secondOperand);
                Console.WriteLine("Result = " + result);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            
        }
    }

    private static bool IsInteger(string input)
    {
        return int.TryParse(input, out int n);
    }
}