using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearEquationSolver
{
    class Equation
    {
        private double leftBorder;
        private double rightBorder;
        private double delta;
        private double x;
        private int counter;
        public Equation(double leftBorder, double rightBorder, double delta)
        {
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            this.delta = delta;
            counter = 0;
        }

        public double GetSolution()
        {
            while (IntervalIsBigger(leftBorder, rightBorder, delta))
            {
                x = (leftBorder + rightBorder) / 2.0;
                counter++;
                if (F(leftBorder) * F(x) < 0)
                    rightBorder = x;
                else if (F(x) * F(rightBorder) < 0)
                    leftBorder = x;
                else
                    return x;
            }
            return (leftBorder + rightBorder) / 2.0;
        }

        public int GetCounter()
        {
            return counter;
        }

        private bool IntervalIsBigger(double a, double b, double delta)
        {
            return Math.Abs(b - a) > delta;
        }

        private double F(double x)
        {
            return (x * x * x + 0.4 * x + 2);
        }
    }
}
