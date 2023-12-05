using static StudingC_.Program;

namespace StudingC_;

class Program
{
    public static class Player
    {
        public static int Energy { get; set; }
        public static string Name { get; set; }
        public static bool IsDead { get; set; }

        public static void Start(int energy, string name, bool isDead)
        {
            Energy = energy;
            Name = name;
            IsDead = isDead;
        }
        public static void InfoPlayer()
        {
            Console.WriteLine($"{Name}, {Energy}, {IsDead}");
        }
    }

    public class Enemy
    {
        public bool IsDead { get; set; }
        public string Name { get; set; }
        public static bool Alert { get; set; }

        public Enemy(string name, bool alert = false)
        {
            IsDead = true;
            Name = name;
            Alert = alert;
        }

        public void InfoEnemy()
        {
            Console.WriteLine($"{Name}, {IsDead}, {Alert}");
        }
    }
    public static void Main()
    {
        Player.Start(100, "Yudi", false);
        Player.InfoPlayer();

        var enemy1 = new Enemy("Oni");
        var enemy2 = new Enemy("Bruxa", false);
        enemy1.InfoEnemy();
        enemy2.InfoEnemy();
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