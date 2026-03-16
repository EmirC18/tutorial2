namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int[] values = { 2, 4, 6, 8, 10 };

        double average = StatisticsHelper.CalculateAverage(values);

        Console.WriteLine("Statistics application started successfully.");
        Console.WriteLine("Minimum feature will be added soon.");
        Console.WriteLine($"Calculated average: {average}");
    }
}