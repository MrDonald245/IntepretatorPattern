using System;

namespace Console.Interpretator
{
    class QuadraticExpression : IExpression
    {
        /// <summary>
        /// Solve quadratic expression.
        /// </summary>
        /// <param name="context"></param>
        /// <returns>x1, x2</returns>
        public double[] Solve(Context context)
        {
            double x1, x2;

            if (context.D < 0)
                return default(double[]);
            else if (context.D == 0)
                x1 = x2 = -(context.B / 2 * context.A);
            else
            {
                double sqrtD = Math.Sqrt(context.D);
                x1 = (-context.B + sqrtD) / (2 * context.A);
                x2 = (-context.B - sqrtD) / (2 * context.A);
            }

            return new[] { x1, x2 };
        }
    }
}
