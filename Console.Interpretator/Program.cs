namespace Console.Interpretator
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(1, 2, -3);
            IExpression expression = new QuadraticExpression();

            double[] results = expression.Solve(context);

            for (int i = 0; i < results.Length; ++i)
            {
                System.Console.WriteLine($"x{i} = {results[i]}");
            }


            System.Console.ReadKey();
        }
    }
}
