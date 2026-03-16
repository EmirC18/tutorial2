namespace ConsoleApp1;

public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            Console.WriteLine("No values provided.");
            return 0;
        }

        int sum = 0;

        foreach (var v in values)
        {
            sum += v;
        }

        return (double)sum / values.Length;
    }
}