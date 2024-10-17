using System.Reflection;

namespace microsoft.botsay;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer (first operand)");

        bool firstOperandCheck = false;
        string? firstOperand = "";

        while (!firstOperandCheck)
        {
            firstOperand = Console.ReadLine();
            if (IsInteger(firstOperand))
            {
                firstOperandCheck = true;
            }
            else
            {
                Console.WriteLine("Error: Please enter an integer (first operand)");
            }
        }

        Console.WriteLine("First Operand: " + firstOperand);
    }

    private static bool IsInteger(string input)
    {
        return int.TryParse(input, out int n);
    }
}