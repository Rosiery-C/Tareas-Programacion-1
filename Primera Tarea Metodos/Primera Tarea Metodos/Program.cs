using System;
using System.Text;
using System.Threading.Tasks;

namespace Primera_Tarea_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapecio rectangle1 = new Trapecio();
            rectangle1.basis = 3;
            rectangle1.height = 7;

            rectangle1.Grow(10);

            Console.WriteLine(rectangle1.Area());
            Console.WriteLine(rectangle1.Perimeter());


            Trapecio rectangle2 = new Trapecio();
            rectangle2.basis = 1.5;
            rectangle2.height = 4;

            Console.WriteLine(rectangle1.Compare(rectangle2));

            Trapecio rectangle3 = new Trapecio();
            rectangle3.basis = 7;
            rectangle3.height = 10;

            Console.WriteLine(rectangle3.Area());


            Console.ReadKey();

        }

    }
}
