namespace BackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From OOP!");

            var calculator = new Calculator("+");
            calculator.SumNumbers(101, 102, 103);
        }

    }

    class Calculator
    {

        private readonly string _operatorName = "+";

        public Calculator(string name)
        {
            _operatorName = name;
        }

        public int SumNumbers(int x, int y) => x + y;
        public int SumNumbers(int x, int y, int z) => x + y + z;
    }

}