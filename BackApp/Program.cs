namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var smartPhone = new SmartPhone("Xiaomi Redmi Note 13 Pro", 2025);
            Console.WriteLine(smartPhone);
        }
    }

    class SmartPhone
    {
        public string Name;
        public int PublishYear;
        public int PublishMonth;
        public string Color;
        public string Ram;
        public string Storage;

        public SmartPhone(
            string name = "Iphone 17 ProMax",
            int publishYear = 2025,
            int publishMonth = 9,
            string color = "Black",
            string ram = "12",
            string storage = "1T")
        {
            Console.WriteLine('1');
            Name = name;
            PublishYear = publishYear;
            PublishMonth = publishMonth;
            Color = color;
            Ram = ram;
            Storage = storage;

        }

        public SmartPhone(string name)
        {
            Console.WriteLine('2');
            Name = name;
        }

    }

}