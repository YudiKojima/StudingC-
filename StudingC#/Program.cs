namespace StudingC_;

class Program
{
    public class Car
    {
        public int Velocity { get; set; }

        public bool InsideLimit
        {
            get
            {
                return Velocity <= 60;
            }
        }

        public Car(int velocity)
        {
            Velocity = velocity;
        }
    }

    public static void Main()
    {
        var car = new Car(63);
        Console.WriteLine(car.InsideLimit);
    }
}

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