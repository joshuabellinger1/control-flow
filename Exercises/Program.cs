namespace Exercises;

class Program
{
    static void Main(string[] args)
    {
        var sum = 0;

        while (true)
        {
            Console.WriteLine("Please enter a number, or type \"OK\" to EXIT");

            var input = Console.ReadLine();

            if (input.ToUpper() == "OK")
            {
                break;
            }
            else
            {
                sum += int.Parse(input);
                Console.WriteLine(sum);
            }
        }
        Console.WriteLine("You have been exited from this program. Here is your sum: " + sum);
    }
}
