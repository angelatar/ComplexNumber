using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public struct ComplexNumber
    {
        Real real;
        Real imaginary;
        public ComplexNumber(Real r, Real i)
        {
            real = r;
            imaginary = i;
        }
        //Addition
        public static ComplexNumber operator+(ComplexNumber n1, ComplexNumber n2)
        {
            //create and return new object
            return new ComplexNumber(n1.real + n2.real, n1.imaginary + n2.imaginary);
        }
        //Subtraction
        public static ComplexNumber operator-(ComplexNumber n1, ComplexNumber n2)
        {
            //create and return new object
            return new ComplexNumber(n1.real - n2.real, n1.imaginary - n2.imaginary);
        }
        //Multiplication
        public static ComplexNumber operator*(ComplexNumber n1, ComplexNumber n2)
        {
            //create and return new object
            return new ComplexNumber((n1.real * n2.real) - (n1.imaginary * n2.imaginary), (n1.imaginary * n2.real) + (n1.real * n2.imaginary));
        }
        //Division
        public static ComplexNumber operator/(ComplexNumber n1, ComplexNumber n2)
        {
            //create and return new object
            return new ComplexNumber(((n1.real * n2.real) + (n1.imaginary * n2.imaginary)) / (n2.real * n2.real + n2.imaginary * n2.imaginary),
                ((n1.imaginary * n2.real) - (n1.real * n2.imaginary)) / (n2.real * n2.real + n2.imaginary * n2.imaginary));
        }
        //Absolute value (magnitude)
        public Real Magnitude()
        {
            //create and return new object
            return new Real(Math.Sqrt((this.real * this.real + this.imaginary * this.imaginary).d));
        }
        //Argument(phase)
        public Real Phase()
        {
            //create and return new object
            return new Real(Math.Atan2(this.imaginary.d, this.real.d));
        }
        public override string ToString()
        {
            return (imaginary.d > 0) ?(real.d + "+" + imaginary.d + "i") : (real.d.ToString() + imaginary.d + "i");
        }
    }


}
