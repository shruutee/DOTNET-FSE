using System;

class Program
{
    static double FutureValue(double currentValue, double growthRate, int years)
    {
        if (years == 0)
            return currentValue;

        return FutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
    }

    static void Main()
    {
        double currentValue = 10000;
        double growthRate = 0.10;
        int years = 5;

        double result = FutureValue(currentValue, growthRate, years);

        Console.WriteLine("Future Value after " + years + " years = " + result);
    }
}