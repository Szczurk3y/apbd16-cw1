int[] arr = { 1, 2, 3, 4, 5 };

Console.WriteLine("Average: " + Calc.average(arr));

class Calc
{
    public static double average(int[] numbers)
    {
        return numbers.Sum(x => x) / numbers.Length;
    }
}
