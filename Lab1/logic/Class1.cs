using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.logic
{

    class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private const double EPS = 1e-9;

        private static bool TanUndefined(double angle)
        {
         return   Math.Abs(Math.Cos(angle)) < 1e-12;
        }

        private double f1(double x)
        {
            if (TanUndefined(x + 1)) return double.NaN;          // полюси тангенса
            double den = x * x * x * x + 2 * x * x * x - x;      // x(x+1)(x^2+x−1)
            if (Math.Abs(den) < EPS) return double.NaN;          // ділення на нуль
            double t = Math.Tan(x + 1);
            return (t * t) / den;
        }

        private double f2(double x)
        {
            double ang = 2 * x - 1;
            if (TanUndefined(ang)) return double.NaN;            // полюси тангенса
            double den = Math.Tan(ang) + 1.0;
            if (Math.Abs(den) < EPS) return double.NaN;          // tg(2x−1) = −1
            return (2 * x + 2) / den;
        }

        private double f3(double x)
        {
            double num = Math.Cos(x + 2);
            num *= num;                                          // cos^2
            double den = Math.Exp(-2.0 * x) + Math.Pow(3.0 * x * x, 0.25) + 1.0;
            return num / den;                                    // знаменник завжди > 1
        }

        private double F(double x, double a)
        {
            if (x <= 0) return f1(x);
            if (x <= a) return f2(x);
            return f3(x);
        }

        public void tab(double xn, double xk, double h, double a)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                y = F(x, a);
                xy[i, 0] = x;
                xy[i, 1] = y;
                x += h;
                i++;
            }
            n = i;
        }
    }
}
