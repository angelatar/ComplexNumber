using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    //My simple type
    public struct Real
    {
        public double d;
        public Real(double temp)
        {
            d = temp;
        }
        public static Real operator +(Real d1, Real d2)
        {
            return new Real(d1.d + d2.d);
        }
        public static Real operator -(Real d1, Real d2)
        {
            return new Real(d1.d - d2.d);
        }
        public static Real operator *(Real d1, Real d2)
        {
            return new Real(d1.d * d2.d);
        }
        public static Real operator /(Real d1, Real d2)
        {
            return new Real(d1.d / d2.d);
        }
        public override string ToString()
        {
            return d.ToString();
        }
    }
}
