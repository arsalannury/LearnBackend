namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var t = new Iran();

        }
    }


    class Iran
    {
        public const int sum = 10 * 10;
        public readonly string Capital = "Tehran";
        public readonly int Population = 91;
        public readonly string[] Neighbors = new string[6] { "Iraq", "Pakistan", "Afghanistan", "Turkamanistan", "Armenia", "Turkey" };
        public readonly string[] Religions = new string[6] { "Islam", "Christianity", "Judaism", "Zoroastrianism", "Druze", "bahaism" };

        public static int Calc()
        {
            return 10 * 10;
        }
    }

}