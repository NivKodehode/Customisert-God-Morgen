namespace Customisert_God_Morgen;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;

        double time = date.ToOADate();

        if (time >= 12.00)
        {
            Console.WriteLine($"Good morning!");
        }
        else if (time <= 20.00)
        {
            Console.WriteLine($"Good evening!");
        }
        else
        {
            Console.WriteLine($"Good afternoon");
        }

        Console.WriteLine ($"The time is {date:T}!");
    }
}
