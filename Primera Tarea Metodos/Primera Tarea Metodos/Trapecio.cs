using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_Tarea_Metodos
{
    public class Trapecio
    {
        public double basis;
        public double height;

        public double Area()
        {
            double area = this.basis * this.height;
            return area;
        }

        public double Perimeter()
        {
            double perim = this.basis + this.height + this.height;
            return perim;
        }

        public void Grow(double quantity)
        {
            this.basis = this.basis + quantity;
            this.height = this.height + quantity;
        }

        public double Compare(Trapecio rect)
        {
            return this.Area() - rect.Area();
        }
    }
}
