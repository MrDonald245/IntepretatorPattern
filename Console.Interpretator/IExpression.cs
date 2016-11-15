namespace Console.Interpretator
{
    interface IExpression
    {
        double[] Solve(Context context);
    }
}
