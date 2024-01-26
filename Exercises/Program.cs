namespace Exercises;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");

        var number = int.Parse(Console.ReadLine());

        var factorial = 1;

        for (int i = number; i > 0; i--)
        {
            factorial *= i;
        }

        Console.WriteLine("{0}! = {1}", number, factorial);
    }
}
