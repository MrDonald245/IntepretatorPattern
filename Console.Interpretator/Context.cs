namespace Console.Interpretator
{
    class Context
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public double D => B * B - 4 * A * C;


        public Context(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
