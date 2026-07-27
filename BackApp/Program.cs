namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var russianGun = new Wepeon("AK 47");
            russianGun.GetSummaryWepeon();

            var m4Gun = new Wepeon("M4 Tactic", 1954);
            m4Gun.GetSummaryWepeon();
        }
    }

    class Wepeon
    {
        private readonly string _name;
        private readonly int _yearOfBuild;
        private readonly int _bulletCounts;
        private readonly string _color;
        private readonly string _style;


        public Wepeon(string name, int buildYear, int bulletCount, string color, string shootStyle)
        {
            _name = name;
            _yearOfBuild = buildYear;
            _bulletCounts = bulletCount;
            _color = color;
            _style = shootStyle;
        }

        public Wepeon(string name, int buildYear)
        {
            Console.WriteLine("Run 1");
            _name = name;
            _yearOfBuild = buildYear;
        }

        public Wepeon(string name) : this(name, 1902)
        {
            Console.WriteLine("Run 2");
            _name = name;
        }

        public void GetSummaryWepeon()
        {
            Console.WriteLine($"{_name} - {_yearOfBuild}");
        }
    }

}