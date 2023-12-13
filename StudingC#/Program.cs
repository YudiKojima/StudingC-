class Program
{
    public static void Main()
    {
        Dictionary<int, string> books = new Dictionary<int, string>();

        books.Add(0, "teste0");
        books.Add(1, "teste1");
        books.Add(2, "teste2");
        books.Add(3, "teste03");

        if (books.ContainsKey(3) && books.ContainsValue("teste03"))
        {
            foreach (var book in books)
            {
                var bookKey = book.Key;
                var bookValue = book.Value;
                Console.WriteLine($"Dictionary has {bookKey} and {bookValue}");
            }

            ChangeDictionaryValue(books, 0, "mudei");
        }
    }

    private static void ChangeDictionaryValue(Dictionary<int, string> books, int key, string value)
    {
        bool check = true;
        books[key] = value;
        Console.WriteLine($"value to {key} key modified to {value}, Do you want to check them all?");

        if (!check) return;
        foreach (var book in books)
        {
            var bookKey = book.Key;
            var bookValue = book.Value;
            Console.WriteLine($"Dictionary has {bookKey} and {bookValue}");
        }
    }
}

//public static void Main()
//{
//    var perfectSquare = new PerfectSquare();

//    try
//    {
//        var result = perfectSquare.createSquarePerfect(4, 4);
//        Console.WriteLine($"Perfect square created, size is {result}");
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"ERRO MESSAGE: {e.Message}");
//        Console.WriteLine($"EXCEPTION: {e}");
//    }
//    finally
//    {
//        Console.WriteLine("Finally");
//    }
//}

//namespace Calc
//{
//    public class PerfectSquare
//    {
//        public int createSquarePerfect(int bas, int height)
//        {
//            if (bas != height)
//            {
//                throw new Exception("To be perfect square need that base is equal height");
//            }

//            return bas * height;
//        }
//    }
//}

//delegate int Operation(int n1, int n2);

//public class Calc
//{
//    public static int Fac(int n)
//    {
//        int res;

//        if (n <= 1)
//        {
//            res = 1;
//        }
//        else
//        {
//            res = n * Fac(n - 1);
//        }

//        return res;
//    }

//    public static int Sum(int n1, int n2)
//    {
//        return n1 + n2;
//    }

//    public static int Multi(int n1, int n2)
//    {
//        return n1 * n2;
//    }
//}

//public class Calculate
//{
//    public int Sum(int n1, int n2)
//    {
//        return n1 + n2;
//    }
//    public double Sum(double n1, double n2)
//    {
//        return n1 + n2;
//    }

//    public int Sum(int n1, int n2, int n3)
//    {
//        return n1 + n2 + n3;
//    }

//    public int Sum(int n1, int n2, int n3, int n4)
//    {
//        return n1 + n2 + n3 + n4;
//    }

//}

//public class Chicken
//{
//    public string Name { get; set; }
//    public int TimesEggsLaid { get; set; }
//    public Egg LastEgg { get; set; }

//    public Chicken(string name)
//    {
//        Name = name;
//        TimesEggsLaid = 0;
//        LastEgg = new Egg();
//    }

//    public Egg LayEgg(int times)
//    {
//        TimesEggsLaid = +times;
//        LastEgg = new Egg(times);
//        return LastEgg;
//    }
//}

//public class Egg
//{
//    public int Quantity { get; set; }

//    public Egg(int quantity = 0)
//    {
//        Quantity += quantity;
//        if (quantity > 0)
//        {
//            Console.WriteLine(Quantity == 1 ? "Ovo foi criado!" : "Ovos foram criados!");
//        }
//    }
//}

//public interface ICar
//{
//    public bool Radar(int velocity);
//    public void OutOfLimit(bool insideLimit);
//}


//public class Car : ICar
//{
//    public int Velocity { get; set; }

//    public bool InsideLimit
//    {
//        get
//        {
//            return Velocity <= 60;
//        }
//    }

//    public Car(int velocity)
//    {
//        Velocity = velocity;
//    }

//    public bool Radar(int velocity)
//    {
//        return InsideLimit;
//    }

//    public void OutOfLimit(bool insideLimit)
//    {
//        Console.WriteLine(insideLimit ? "voce se livrou da multa" : "FOI MULTADO");
//    }
//}
//public class Honda : Car
//{
//    public string Name { get; set; }

//    public Honda(string name) : base(60)
//    {
//        Name = name;
//    }
//}

//abstract class Book
//{
//    protected int Quantity { get; set; }
//    protected int Cost { get; set; }
//    protected bool Reserved { get; set; }

//    protected Book()
//    {
//        Reserved = false;
//        Cost = 0;
//    }

//    public abstract void SetReserve();
//}

//class MaterialBook : Book
//{
//    public MaterialBook()
//    {
//        Quantity = 1;
//        Cost = 10;
//        Reserved = false;
//    }

//    public void GetReserve()
//    {
//        Console.WriteLine($"{Reserved}");
//    }

//    public override void SetReserve()
//    {
//        Reserved = true;
//    }
//}

//public class Base1
//{
//    public virtual void Info()
//    {
//        Console.WriteLine("Info Base 1");
//    }
//}

//public class Base2 : Base1
//{
//    public override void Info()
//    {
//        Console.WriteLine("Info Base 2");
//    }
//}

//public class Book
//{
//    public int Quantity { get; set; }
//    private string Name { get; set; }
//    protected bool Reserved { get; set; }

//    public Book(string name)
//    {
//        Quantity = 1;
//        Name = name;
//        Reserved = false;
//    }

//    public string GetNameBook()
//    {
//        return Name;
//    }
//}

//public class SchoolBook : Book
//{
//    public int Score { get; set; }
//    public SchoolBook(int score, bool reserved, string name) : base(name)
//    {
//        Score = score;
//        Reserved = reserved;
//    }

//    public bool GetReservedBook()
//    {
//        return Reserved;
//    }
//}


//public class Vehicle
//{
//    public int Velocity { get; set; }
//    public bool Connect { get; set; }
//    public int Wheels { get; set; }

//    public Vehicle(int wheels)
//    {
//        Velocity = 120;
//        Connect = false;
//        Wheels = wheels;
//    }

//    public string CheckConnectVehicle()
//    {
//        return Connect ? "Yes" : "No";
//    }
//}

//public class Car : Vehicle
//{
//    public string Name { get; set; }
//    public string Color { get; set; }

//    public Car(string name, string color) : base(6)
//    {
//        Name = name;
//        Color = color;
//        Connect = true;
//    }
//}

//public class TruckCar : Car
//{
//    public bool HasWeapon { get; set; }
//    public TruckCar(bool hasWeapon) : base("Monster Truck", "Red")
//    {
//        HasWeapon = hasWeapon;
//    }
//}

//public class Player
//{
//    public int Energy { get; set; }
//    private string Name { get; set; }

//    public Player(int energy, string name)
//    {
//        Energy = energy;
//        Name = name;
//    }

//    public void SetEnergyPlayer(int energy)
//    {
//        if (energy < 0)
//        {
//            Energy = Energy + energy < 0 ? 0 : Energy += energy;
//        }
//        else
//        {
//            Energy = Energy + energy > 100 ? 100 : Energy -= energy;
//        }
//    }
//}

//public class Calc
//{
//    public int value1;
//    public int value2;

//    public Calc(int value1, int value2)
//    {
//        this.value1 = value1;
//        this.value2 = value2;
//    }

//    public int Sum()
//    {
//        return value1 + value2;
//    }
//}

//public static class Player
//{
//    public static int Energy { get; set; }
//    public static string Name { get; set; }
//    public static bool IsDead { get; set; }

//    public static void Start(int energy, string name, bool isDead)
//    {
//        Energy = energy;
//        Name = name;
//        IsDead = isDead;
//    }
//    public static void InfoPlayer()
//    {
//        Console.WriteLine($"{Name}, {Energy}, {IsDead}");
//    }
//}

//public class Enemy
//{
//    public bool IsDead { get; set; }
//    public string Name { get; set; }
//    public static bool Alert { get; set; }

//    public Enemy(string name, bool alert = false)
//    {
//        IsDead = true;
//        Name = name;
//        Alert = alert;
//    }

//    public void InfoEnemy()
//    {
//        Console.WriteLine($"{Name}, {IsDead}, {Alert}");
//    }
//}

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