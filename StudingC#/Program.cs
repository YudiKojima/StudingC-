using System;

class Program
{
    static void Main()
    {
        int result = SumNumberArray(1, 2, 3, 4, 5);
        Console.WriteLine(result);
    }

    public static int SumNumberArray(params int[] array)
    {
        int sum = 0;

        if (array.Length == 0)
        {
            Console.WriteLine("Don't has value to sum");
        }

        if (array.Length == 1)
        {
            Console.WriteLine("Has only one value");
        }
        else
        {
            foreach (var value in array)
            {
                sum += value;
            }
        }

        return sum;
    }

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