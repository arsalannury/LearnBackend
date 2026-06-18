namespace BackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From OOP!");     
        }

        public int CalculateSum(int x, int y) => x + y;
        public int CalculateSum(int x , int y, int z) => x + y + z;

    }
}