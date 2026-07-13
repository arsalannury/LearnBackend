namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tank abraham = new Tank();
        }
    }

    class Tank
    {

        public string Model;
        public int YearBuild;

        public Tank(string model, int yearBuld)
        {
            Console.WriteLine("2");
            Model = model;
            YearBuild = yearBuld;
        }

        public Tank() : this("Abraham", 1992)
        {
            Console.WriteLine("1");
            YearBuild = 0;
        }
    }
}