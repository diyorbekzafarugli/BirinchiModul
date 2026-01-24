namespace Lesson_1_8_;

internal class Program
{

    static List<int> Ages = new List<int>();
 
    static void Main(string[] args)
    {
        // //  CRUD => Create Read Update Delete:

        while(true)
        {
            Console.WriteLine("1. Yosh qo'shish :");
            Console.WriteLine("2. Yoshni yangilsh:");
            Console.WriteLine("3. Yoshni o'chirish :");
            Console.WriteLine("4. Ko'rish :");


            int.TryParse(Console.ReadLine(), out int num);

            if (num == 1)
            {
                Console.Write("Yoshni kiriting :");
                int.TryParse(Console.ReadLine(), out int age);
                CreateAge(age);

            } else if (num == 2)
            {
                Console.Write("Eskisini kiriting :");
                int.TryParse(Console.ReadLine(), out int age1);
                Console.Write("Yangisini kiriting :");
                int.TryParse(Console.ReadLine(), out int age2);
                UpdateAge(age1, age2);

            } else if (num == 3)
            {
                Console.Write("O'chirmoqchi bo'lgan yoshni kiriting :");
                int.TryParse(Console.ReadLine(), out int age);
                DeleteAge(age);
            } else if (num == 4)
            {
                ReadAge();
            }


            Console.ReadKey();
            Console.Clear();
        }



    }

    static void CreateAge( int age)
    {
        Ages.Add(age);
    }


    static void UpdateAge(int age1, int age2)
    {
        int index = Ages.IndexOf(age1);

        if (index != -1)
        {
            Ages[index] = age2;
        }
    }

    static void DeleteAge(int age)
    {
        Ages.Remove(age);
    }

    static void ReadAge()
    {
        foreach (var age in Ages)
        {
            Console.WriteLine(age);
        }
    }
}
