namespace Lesson2;

internal class Program
{
    static void Main(string[] args)
    {
        /* Quyidagi ma'lumotlarni 1 ta Console.WriteLine() va bir nechta \n yordamida ekranga(console) chiqaring.*/
        Console.Write("Toq son kiriting : ");
        int num = int.Parse(Console.ReadLine());

        string row = "";

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < 2 * num - 1; j++)
            {
                row += "* ";
            }

            row += "\n";
        }
        Console.WriteLine(row);

        //Console.WriteLine("12345\n1234\n123\n12\n1");

        /* AXBOROT O'LCHOV BIRLIKLARI : */

        // // 2:
        //int megaBayt = 3;
        //int kiloBayt = megaBayt * 1024;
        //Console.WriteLine(kiloBayt);

        // // 1.1:
        //Console.Write("Fayl hajmmi qancha ekanligini kiriting (Gbayt da) : ");
        //int gegaBayt = int.Parse(Console.ReadLine());
        //int megaBayt = gegaBayt * 1024;
        //Console.WriteLine($"{gegaBayt} GB teng {megaBayt} MB ga");

        // // 1.1 12:
        //Console.Write("necha soniya ekanligini kiriting : ");
        //int seconds = int.Parse(Console.ReadLine());
        //int weeks = seconds / 3600 / 24 / 7;
        //Console.WriteLine($"{seconds} soniya {weeks} haftaga teng");

        // // 1.1 11:
        //Console.Write("necha soniya ekanligini kiriting : ");
        //int seconds = int.Parse(Console.ReadLine());
        //int minutes = seconds / 60;
        //Console.WriteLine($"{seconds} soniya {minutes} daqiqaga teng");

        // // 1.1 10;
        //Console.Write("necha soniya ekanligini kiriting :");
        //int seconds = int.Parse(Console.ReadLine());
        //int hours = seconds / 3600;
        //Console.WriteLine($"{seconds} soniya {hours} soatga teng");

        // // 1.1 9;
        //Console.Write("necha kun ekanligini kiriting :");
        //int days = int.Parse(Console.ReadLine());
        //int weeks = days / 7;
        //int remainderDays = days % 7;
        //Console.WriteLine($"{days} kun {weeks} hafta va {remainderDays} kun");

        // // 1.1 8:
        //Console.Write("Soat kiriting : ");
        //int hours = int.Parse(Console.ReadLine());
        //int days = hours / 24;
        //int rHours = hours % 24;
        //Console.WriteLine($"{hours} soat {days} kun va {rHours} soatga teng;");

        // // 1.1 7;
        //int hours = 8;
        //int second = hours * 60 * 60;
        //Console.WriteLine($"{hours} soat {second} sohiyaga teng");

        // // 1.1. 6;
        //int days = 4;
        //int minutes = days * 24 * 60;
        //Console.WriteLine($"{days} kun {minutes} daqiqaga teng");


        // // 1.1 5:
        //int weeks = 150;
        //int hours = weeks * 7 * 24;
        //Console.WriteLine($"{weeks} hafta {hours} soatga teng");

        // // 1.1 4:
        //int hour = 25;
        //int second = hour * 60 * 60;
        //Console.WriteLine($"{hour} soat {second} soniya ga teng");

        // // 1.1 3:
        //int minut = 4;
        //int second = minut * 60;
        //Console.WriteLine($"{minut} daqiqa {second} soniyaga teng");


        // // 1.1. 2:
        //int week = 5;
        //int hours = week * 7 * 24;
        //Console.WriteLine($"{week} hafta {hours} soatga ga teng");

        //// 1.1 1:
        //int hour = 2;
        //int res = hour * 60;
        //Console.WriteLine(res);

        //int intValue = int.Parse(Console.ReadLine());

        //double pi = 3.14;

        //double S = pi * intValue * intValue;

        //Console.WriteLine(S);
    }
}
