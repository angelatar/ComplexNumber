using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public struct ComplexNumber
    {
        double real;
        double imaginary;
        public ComplexNumber(double r, double i)
        {
            real = r;
            imaginary = i;
        }
        public static ComplexNumber operator+(ComplexNumber n1, ComplexNumber n2)
        {
            return new ComplexNumber(n1.real + n2.real, n1.imaginary + n2.imaginary);
        }
        public static ComplexNumber operator-(ComplexNumber n1, ComplexNumber n2)
        {
            return new ComplexNumber(n1.real - n2.real, n1.imaginary - n2.imaginary);
        }
        public static ComplexNumber operator*(ComplexNumber n1, ComplexNumber n2)
        {
            return new ComplexNumber((n1.real * n2.real) - (n1.imaginary * n2.imaginary), (n1.imaginary * n2.real) + (n1.real * n2.imaginary));
        }
        public static ComplexNumber operator/(ComplexNumber n1, ComplexNumber n2)
        {
            return new ComplexNumber(((n1.real * n2.real) + (n1.imaginary * n2.imaginary)) / (n2.real * n2.real + n2.imaginary * n2.imaginary),
                ((n1.imaginary * n2.real) - (n1.real * n2.imaginary)) / (n2.real * n2.real + n2.imaginary * n2.imaginary));
        }
        public double Magnitude()
        {
            return Math.Sqrt(this.real * this.real + this.imaginary * this.imaginary);
        }
        public double Phase()
        {
            return Math.Atan2(this.imaginary, this.real);
        }
        public void Show()
        {
            Console.WriteLine(real + "+" + imaginary + "i");
        }
    }
}
