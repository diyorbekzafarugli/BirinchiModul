namespace Lesson_5_Array_vs_List____Function_;

internal class Program
{
    static void Main(string[] args)
    {



        //List<int> tensNums = new List<int>() { 23, 322, 121, 24, 4, 0, 32, 2, 42, 3, -98 };

        //OutToConsole(IncreaseToTen(tensNums));



        //Console.WriteLine("Hello, World!");
        // // List - dynamic hisoblanadi va bu uning uzunligiga nisbatan:

        //Console.Write("List uzunligini kriritng : ");
        //int n = int.Parse(Console.ReadLine());

        //List<int> ints = new List<int>();

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write($"Listning {i + 1} - elementini kiriting : ");
        //    int num = int.Parse(Console.ReadLine());

        //    ints.Add(num);
        //}

        // // Array - static hisoblanadi va bu so'z uning uzunligiga nisbatan:
        //int[] arr = new[] {12,3,4,5,6};

        //var arr1 = new int[5];
        //arr1[0] = 12;
        //arr1[1] = 90;
        //arr1[2] = 34;
        //arr1[3] = -2;
        //Console.WriteLine(arr1.Count());
        //Console.WriteLine(arr1[4]);
    }


    static void OutToConsole(List<int> ints)
    {
        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }
    }


    static List<int> IncreaseToTen(List<int> nums)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            nums[i] += 10;
        }
        return nums;
    }
}