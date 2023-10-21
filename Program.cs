
// Filip Nilsson NET23

namespace OOP_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle FirstCircle = new Circle(5);
            double area = FirstCircle.GetArea();
            Console.WriteLine($"The area of your first circle is: {area:#.##}");

            Circle SecondCircle = new Circle(6);
            double area2 = SecondCircle.GetArea();
            Console.WriteLine($"The area of your second circle is: {area2:#.##}");

            Console.ReadLine();
        }
    }
}