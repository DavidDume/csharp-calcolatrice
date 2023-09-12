using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public class CalcoliHelper
    {
        //SOMMA
        public static int sommaInt(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double sommaDouble(double num1, double num2)
        {
            return num1 + num2;
        }

        //DIFFERENZA
        public static int diffInt(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double diffDouble(double num1, double num2)
        {
            return num1 - num2;
        }

        //MOLTIPLICAZIONE
        public static int moltInt(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double moltDouble(double num1, double num2)
        {
            return num1 * num2;
        }

        //MODULO
        public static int moduloInt(int num1, int num2)
        {
            return num1 / num2;
        }

        public static double moduloDouble(double num1, double num2)
        {
            return num1 / num2;
        }

        //MINIMO
        public static int minInt(int num1,int num2)
        {
            if (num1 < num2) return num1;
            else return num2;

        }
        public static double minDouble(double num1, double num2)
        {
            if(num1 < num2) return num1;
            else return num2;
        }

        //MASSIMO
        public static int maxInt(int num1,int num2)
        {
            if (num1 < num2) return num2;
            else return num1;
        }
        public static double maxDouble(double num1, double num2)
        {
            if (num1 < num2) return num2; else return num1;
        }
    }
}
