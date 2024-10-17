using System.Reflection;

namespace microsoft.botsay;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer (first operand)");
        string ?firstOperand = Console.ReadLine();
        Console.WriteLine("First Operand: " + firstOperand);
    }

    private bool IsInteger(string input)
    {
        return false;
    }
}