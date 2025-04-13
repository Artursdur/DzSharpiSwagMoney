using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzSharpiKotorieMoneySWAG
{
    public class BABKI
    {
        public double Sum { get; set; }



        public static implicit operator BABKI(double sum)
        {
            return new BABKI(sum);
        }


        public static BABKI operator +(BABKI num1, BABKI num2)
        {
            return new BABKI(num1.Sum + num2.Sum);
        }
        public static BABKI operator +(BABKI num1, double num2)
        {
            BABKI res = num1 + num2;
            return res;
        }

        public static BABKI operator -(BABKI num1, BABKI num2)
        {
            return new BABKI(num1.Sum - num2.Sum);
        }

        public static BABKI operator -(BABKI num1, double num2)
        {
            BABKI res = num1 - num2;
            return res;
        }



        public static BABKI operator *(BABKI num1, int num2)
        {
            return new BABKI(num1.Sum * num2);
        }

        public static BABKI operator /(BABKI num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("вы не можете разделить ни одно число на 0");
            }
            return new BABKI(num1.Sum / num2);
        }



        public static BABKI operator ++(BABKI num)
        {
            return new BABKI(num.Sum + 0.1);
        }

        public static BABKI operator --(BABKI num)
        {

            return new BABKI(num.Sum - 0.1);
        }


        public static bool operator >(BABKI num1, BABKI num2)
        {
            return num1.Sum > num2.Sum;
        }

        public static bool operator <(BABKI num1, BABKI num2)
        {
            return num1.Sum < num2.Sum;
        }

        public static bool operator ==(BABKI num1, BABKI num2)
        {
            return num1.Sum == num2.Sum;
        }

        public static bool operator !=(BABKI num1, BABKI num2)
        {
            return num1.Sum != num2.Sum;
        }

        public BABKI(double sum)
        {
            Sum = sum;
        }

        public bool IsNegative()
        {
            return Sum < 0;
        }


    }
}