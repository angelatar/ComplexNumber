using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Real r1 = new Real(1);
            Real r2 = new Real(2);
            ComplexNumber n1 = new ComplexNumber(r1,r2);
            Console.WriteLine(n1);
            Console.WriteLine(n1.Magnitude());
            Console.WriteLine(n1.Phase());
            ComplexNumber n2 = new ComplexNumber(new Real(3),new Real(5));
            Console.WriteLine(n2);
            Console.WriteLine(n1 + n2);
            Console.WriteLine(n1 - n2);
            Console.WriteLine(n1 * n2);
            Console.WriteLine(n1 / n2);
        }
    }
}
