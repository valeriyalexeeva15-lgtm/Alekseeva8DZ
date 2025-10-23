namespace Alekseeva8DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Audi";
            car1.Model = "A6";
            car1.Year = 2020;
            car1.Mileage = 82000;

            Car car2 = new Car();
            car2.Brand = "Toyota";
            car2.Model = "Land cruiser";
            car2.Year = 2023;
            car2.Mileage = 50000;

            car1.PrintInfo();
            car2.PrintInfo();
        }
    }
}

