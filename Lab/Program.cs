using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab
{

    delegate double DoubleOp(double x);

    class MathOperations
    {
        //Both Static and non-static work
        public static double MultiplyByTwo(double val)
        {
            return val * 2;
        }

        public static double Square(double val)
        {
            return val * val;
        }
    }

    class CSimpleDelegate
    {
        //What if I make it non static
        public static void MyFunction(DoubleOp op, double vals)
        {
            double res = op(vals);
            System.Console.WriteLine(res);
        }

    }

    class Program
    {
        public delegate int Callthefactorial(int number);

        static void Main(string[] args)
        {

            DoubleOp Func1 = new DoubleOp(MathOperations.MultiplyByTwo);
            double x = Func1(3);
            System.Console.WriteLine(x);

            Func1 = new DoubleOp(MathOperations.Square);
            x = Func1(3);
            System.Console.WriteLine(x);

            //passing a delegate to another function
            CSimpleDelegate.MyFunction(Func1, 4);
            System.Console.ReadLine();

            /* Callthefactorial factptr = null;

             factptr = calculateFactorial;

             Console.WriteLine(factptr.Invoke(5).ToString());

             Console.ReadLine();
             */
        }

        public static int calculateFactorial(int num)
        {
            if (num > 0)
            {
                return num * calculateFactorial(num - 1);
            }
            else
            {
                return 1;
            }
        }
    }

    
}


