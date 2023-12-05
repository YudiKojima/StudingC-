using static StudingC_.Program;

namespace StudingC_;

class Program
{
    public class Player
    {
        public int Energy { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }

        public Player(int energy, string name, bool isDead)
        {
            Energy = energy;
            Name = name;
            IsDead = isDead;
        }
        public void InfoPlayer()
        {
            Console.WriteLine($"{Name}, {Energy}, {IsDead}");
        }
    }
    private static void Main()
    {
        var player = new Player(10, "Yudi", false);
        var player2 = new Player(100, "teste", true);
        player.InfoPlayer();
        player2.InfoPlayer();

    }

    //public static int SumNumberArray(params int[] array)
    //{
    //    int sum = 0;

    //    if (array.Length == 0)
    //    {
    //        Console.WriteLine("Don't has value to sum");
    //    }

    //    if (array.Length == 1)
    //    {
    //        Console.WriteLine("Has only one value");
    //    }
    //    else
    //    {
    //        foreach (var value in array)
    //        {
    //            sum += value;
    //        }
    //    }

    //    return sum;
    //}

    //public static int ToDivide(int dividend, int divider, out int rest)
    //{
    //    int result = dividend / divider;
    //    rest = dividend % divider;
    //    return result;
    //}

    //public static void ToDouble(ref int num)
    //{
    //    num *= 2;
    //}

    //static decimal GetTestAverage()
    //{
    //    decimal p1, p2, averageDecimal;

    //    Console.WriteLine("Write your test notes: ");

    //    p1 = Convert.ToDecimal(Console.ReadLine());
    //    p2 = Convert.ToDecimal(Console.ReadLine());
    //    averageDecimal = GetTestAverage(p1, p2);
    //    Console.WriteLine("Your average in tests is: " + averageDecimal);

    //    return (p1 + p2) / 2;
    //}

}