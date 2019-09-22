using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonLinearEquationSolver
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Solve_Click(object sender, EventArgs e)
        {
            var leftBorder = ParseToDouble(left.Text);
            var rightBorder = ParseToDouble(right.Text);
            var delta = ParseToDouble(deltaTB.Text);

            if (isInputCorrect(leftBorder, rightBorder, delta))
            {
                var equation = new Equation(leftBorder, rightBorder, delta);
                var solution = equation.GetSolution();
                Solution.Text = solution.ToString();
                Iterations.Text = equation.GetCounter().ToString();
            }
            else
            {
                Solution.Text = "Некорректный ввод";
                Iterations.Text = "";
            }
        }

        private double ParseToDouble(string text)
        {
            if (text.Contains('.'))
                text = text.Replace(".", ",");
            if (double.TryParse(text, out double number))
                return number;
            return double.MaxValue;
        }

        private bool isInputCorrect(double a, double b, double c)
        {
            return a != double.MaxValue &&
                b != double.MaxValue &&
                c != double.MaxValue;
        }
    }
}
