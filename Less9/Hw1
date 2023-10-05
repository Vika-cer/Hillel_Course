//1) Необхідно: створіть клас під назвою Rectangle. 
//У тілі класу створіть два поля, які описують довжини сторін side1, side2.
//Створіть спеціальний конструктор Rectangle(double side1, double side2), у тілі якого
//поля side1 і side2 ініціалізуються значеннями аргументів. Створіть два методи, які
//обчислюють площу прямокутника - double AreaCalculator () і периметр прямокутника - double
//PerimeterCalculator (). 
//Створіть властивості double Area та double Perimeter за допомогою одного методу get.
//Напишіть програму, яка приймає від користувача довжину двох сторін прямокутника та відображає периметр і площу на екрані.

using System;

namespace Rectangle
{
    internal class Rectangle
    {
        private int side1;
        public int Side1
        {
            get { return side1; }
            set { side1 = GetSide1(); }
        }

        public int GetSide1()
        {
            bool resParse = false;
            do
            {
                Console.Write("Write side 1 (0-500): ");
                string input = Console.ReadLine();
                resParse = int.TryParse(input, out side1);
            }
            while (!resParse || side1 < 0 || side1 > 500);
            return side1;
        }

        private int side2;
        public int Side2
        {
            get { return side2; }
            set { side2 = GetSide2(); }
        }

        public int GetSide2()
        {
            bool resParse = false;
            do
            {
                Console.Write("Write side 2 (0-500): ");
                string input = Console.ReadLine();
                resParse = int.TryParse(input, out side2);
            }
            while (!resParse || side2 < 0 || side2 > 500); 
            return side2;
        }

        public Rectangle() 
        {
            Side1 = side1; 
            Side2 = side2;
        }

        public double Area { get { return AreaCalculator(); } }
        private double AreaCalculator()
        {
            double area = side1 * side2; 
            return area;
        }

        public double Perimeter { get { return PerimeterCalculator(); } }
        private double PerimeterCalculator()
        {
            double perimeter = (side1 + side2) * 2; 
            return perimeter;
        }

        public void ConsoleWriteOfAll()
        {
            Console.WriteLine($"Area of a rectangle: {Area}");
            Console.WriteLine($"Perimeter of a rectangle: {Perimeter}");
        }
    }

    internal class Program 
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ConsoleWriteOfAll();
            Console.ReadLine();
        }
    }
}
