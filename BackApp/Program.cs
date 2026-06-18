namespace BackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From OOP!");     
        }

        public int CalculateSum(Int16 x, Int16 y) => x + y;
        public void CalculateSum(Int32 x , Int32 y)
        {
            Console.WriteLine($"{x} {y}");
        }

    }
}