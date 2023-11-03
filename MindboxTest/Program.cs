using MindboxTest.Models;

namespace MindboxTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circ = new Circle(5);
            Triangle tr = new Triangle(25,24,7);
            FigureDefiner fg = new FigureDefiner(5,5,5);
            Console.WriteLine(fg.Define());

            Console.WriteLine(circ.GetArea());
            Console.WriteLine(tr.GetArea());
            Console.WriteLine(tr.IsRectangular());
            Console.ReadKey();
        }
    }
}