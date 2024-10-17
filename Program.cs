using BasicCalculator;
using System.Reflection;

namespace microsoft.botsay;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number (first operand)");

        bool firstOperandCheck = false;
        string? firstOperandString = "";

        while (!firstOperandCheck)
        {
            firstOperandString = Console.ReadLine();
#pragma warning disable CS8604 // Possible null reference argument.
            if (IsDouble(firstOperandString))
            {
                firstOperandCheck = true;
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number (first operand)");
            }
#pragma warning restore CS8604 // Possible null reference argument.
        }

        double firstOperand = double.Parse(firstOperandString);
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

        Console.WriteLine("Enter a number (second operand)");

        bool secondOperandCheck = false;
        string? secondOperandString = "";

        while (!secondOperandCheck)
        {
            secondOperandString = Console.ReadLine();
#pragma warning disable CS8604 // Possible null reference argument.
            if (IsDouble(secondOperandString))
            {
                secondOperandCheck = true;
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number (second operand)");
            }
#pragma warning restore CS8604 // Possible null reference argument.
        }

        double secondOperand = double.Parse(secondOperandString);
        Console.WriteLine("Second Operand: " + secondOperand);

        if (op != null)
        {
            try
            {
                double result = op.DoOperation(firstOperand, secondOperand);
                Console.WriteLine(firstOperand + " " + op.ToString() + " " + secondOperand + " = " + result);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            
        }
    }

    private static bool IsDouble(string input)
    {
        return double.TryParse(input, out double n);
    }
}