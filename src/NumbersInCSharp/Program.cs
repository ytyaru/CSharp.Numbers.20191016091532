using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            code0(a, b);
            code1(a, b);
            code2();
            code3();
            code4();
            code5();
            code6();
            code7();
            code8();
            code9();
            code10();
            code11();
            code12();
        }
        static void code0(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        static void code1(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
        static void code2()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
            d = (a + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
        }
        static void code3()
        {
            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }
        static void code4()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
        }
        static void code5()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
        }
        static void code6()
        {
            int max = int.MaxValue;
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
//            int what = int.MaxValue + 3;
//            Console.WriteLine($"An example of overflow: {what}");
        }

        static void code7()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);
        }
        static void code8()
        {
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
        }
        static void code9()
        {
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        static void code10()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
        }
        static void code11()
        {
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        static void code12()
        {
            double r = 2.5;
            double area = Math.Pow(r, 2) * Math.PI; // べき乗する演算子は`^`でも`**`でもない
            Console.WriteLine($"半径{r}cmの円の面積は{area}です。");
        }
    }
}
