namespace Lesson_1_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.FirstName = "Behzod";
            student1.LastName = "Hoshimov";
            student1.Age = 23;
            student1.School = 56;
            student1.YearOfBirht = "1998";
            student1.Gread = "4";



            Car car1 = new Car()
            {
                Model = "Spark",
                Color = "Red",
                Brend = "GM",
                Speed = 180,
                Weight = 1090,
                HorsePower = 90,
                YearOfManifacture = "2015"
            };

            Car car2 = new Car();
            car2.Brend = "BMW";
            car2.Model = "X5";
            car2.HorsePower = 300;
            car2.Speed = 300;
            car2.Color = "Sky Blue";
            car2.YearOfManifacture = "2019";
            car2.Weight = 1600;


            Console.WriteLine(car2.Brend);
        }
    }
}
