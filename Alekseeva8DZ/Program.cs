using MyApp.Models;

namespace MyProject
{
    public struct Point
    {
        public int X;
        public int Y;
    }

    public struct Rectangle
    {
        public int Width;
        public int Height;
        public Point Position;

        public int CalculateArea()
        {
            return Width * Height;
        }

        public int CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public bool ContainsPoint(Point point)
        {
            return point.X >= Position.X &&
                   point.X <= Position.X + Width &&
                   point.Y >= Position.Y &&
                   point.Y <= Position.Y + Height;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //1
            //Car car1 = new Car();
            //car1.Brand = "Audi";
            //car1.Model = "A6";
            //car1.Year = 2020;
            //car1.Mileage = 82000;

            //Car car2 = new Car();
            //car2.Brand = "Toyota";
            //car2.Model = "Land cruiser";
            //car2.Year = 2023;
            //car2.Mileage = 50000;

            //car1.PrintInfo();
            //car2.PrintInfo();

            //2
            //User user = new User();
            //user.Name = "Валерия Алексеева";
            //user.Email = "lera.alekseeva.4240@mail.ru";
            //user.IsActive = true;

            //Console.WriteLine("Информация о пользователе:");
            //Console.WriteLine($"Имя: {user.Name}");
            //Console.WriteLine($"Email: {user.Email}");
            //Console.WriteLine($"Активен: {user.IsActive}");

            //3
            //ValueChecker checker = new ValueChecker();

            //checker.CheckType(5);
            //checker.CheckType("Hello");


            //4
            //global::System.Console.WriteLine("Hello world!");

            //System mySystem = new System();
            //mySystem.Print();

            //5
            Rectangle rect = new Rectangle();
            rect.Position.X = 10;
            rect.Position.Y = 10;
            rect.Width = 20;
            rect.Height = 15;

            //точки для проверки
            Point point1 = new Point { X = 15, Y = 15 };
            Point point2 = new Point { X = 5, Y = 5 };
            Point point3 = new Point { X = 25, Y = 20 };

            //информация о прямоугольнике
            Console.WriteLine($"Прямоугольник: позиция ({rect.Position.X},{rect.Position.Y}), ширина {rect.Width}, высота {rect.Height}");
            Console.WriteLine($"Площадь: {rect.CalculateArea()}");
            Console.WriteLine($"Периметр: {rect.CalculatePerimeter()}");

            // Проверяем точки
            Console.WriteLine($"Точка ({point1.X},{point1.Y}) внутри прямоугольника: {rect.ContainsPoint(point1)}");
            Console.WriteLine($"Точка ({point2.X},{point2.Y}) внутри прямоугольника: {rect.ContainsPoint(point2)}");
            Console.WriteLine($"Точка ({point3.X},{point3.Y}) внутри прямоугольника: {rect.ContainsPoint(point3)}");
        }   
    }
}




