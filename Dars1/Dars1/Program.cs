namespace Dars1;

internal class Program
{
    static void Main(string[] args)
    {
        int intValue = 5;
        int secondIntValue = 78;
        int summ = 0;

        for (int i = 0; i < intValue; i++)
        {
            summ += secondIntValue;
        }

        Console.WriteLine(summ);
    }
}
