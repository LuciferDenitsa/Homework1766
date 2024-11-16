namespace Homework1766
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc1 = new Calculator(new SalaryAcc(1520));
            calc1.Calculate();
            Console.WriteLine();

            Calculator calc2 = new Calculator(new ConcreteAcc(925));
            calc2.Calculate();
            Console.WriteLine();

            Calculator calc3 = new Calculator(new ConcreteAcc(1050));
            calc3.Calculate();
            Console.WriteLine();

        }
    }
}
