namespace Solver;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        if(input == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }
        var stringSolver = new StringSolver();
        var longest = stringSolver.FindLongest(input);

        Console.WriteLine(longest);
    }
}