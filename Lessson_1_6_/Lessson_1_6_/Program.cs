namespace Lessson_1_6_;

internal class Program
{


    static void Main(string[] args)
    {
        // // REKURSIYA:
        var num1 = 3;
        var num2 = 8;

        Console.WriteLine(SummNum1Num2(num1, num2));
        Console.WriteLine(Summ2Num1Num2(num1, num2));

    }


    static int SummNum1Num2(int a, int b)
    {
        /* f(3, 8) */
        if (a == b) return a;
        return a + SummNum1Num2(a + 1, b);

        /* f(3, 8) => 
        * 3 + f(4, 8) => 4 + 26
          4 + f(5, 8) => 5 + 27
          5 + f(6, 8) => 6 + 21
          6 + f(7, 8) => 15
          7 + f(8, 8) => 8*/
    }

    static int Summ2Num1Num2(int a, int b)
    {
         // 3,8 => 4
        if (a + 1 == b) return 0;
        return a + 1 + Summ2Num1Num2(a + 1, b);


        /* f(3, 8) => 
         * 4 + f(4, 8) => 4 + 18
           5 + f(5, 8) => 5 + 13
           6 + f(6, 8) => 6 + 7
           7 + f(7, 8) => 0*/
    }

}
