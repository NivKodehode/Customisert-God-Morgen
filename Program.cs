namespace Customisert_God_Morgen;

class Program
{
    static void Main(string[] args)
    {
        int time = Int32.Parse( DateTime.Now.ToString("HH"));

        Console.WriteLine(time);

        if (time >= 06.00 && (time < 12.00))
        {
            Console.WriteLine($"Good morning!");
            return;
        }
        else if (time >= 16.00 && (time <= 20.00))
        {
            Console.WriteLine($"Good evening!");
        }
        else if (time >= 12.00 && (time < 16.00))
        {
            Console.WriteLine($"Good afternoon");
        }
        else
        {
            Console.WriteLine($"Good night!");
        }

        Console.WriteLine ($"The time is {time} o-clock!");
    }
}
