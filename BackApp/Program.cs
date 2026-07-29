namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var smartPhone = new SmartPhone("Honor X7","Black",12345);
            Console.WriteLine(smartPhone);
        }
    }

    class SmartPhone
    {
        public string Name;
        public string Color;
        public int Storage;

        public SmartPhone(
            string name,
            string color,
            int storage)
        {

            string messageValidation = ValidateParameters(name, nameof(Name), out bool isValid);

            if (!isValid)
            {
                Console.WriteLine(messageValidation);
                return;
            }

            Name = name;
            Color = color;
            Storage = storage;

        }

        string ValidateParameters(string fieldValue, string fieldName, out bool isValid)
        {

            isValid = true;

            if (fieldName == nameof(Name) && fieldValue.Length < 10)
            {
                isValid = false;
                return "The name must be more than 10 character";
            }

            if (fieldName == nameof(Color) && fieldValue.Length < 6 && !fieldValue.StartsWith('#'))
            {
                isValid = false;
                return "The color must be in hex format . for example #000000";
            }

            if (fieldName == nameof(Storage) && fieldValue.Length > 3)
            {
                isValid = false;
                return "The storage must be in valid storage like 128 256 1";
            }

            return "";

        }

    }

}