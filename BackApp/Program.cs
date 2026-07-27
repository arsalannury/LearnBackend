namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
        }
    }

    class Holding
    {
        public void Members(Company company)
        {
            Console.WriteLine(company.Name);
        }
    }

    class Company
    {
        public string Name = "DigiKala";

        public void CompnayRoot()
        {
            var holding = new Holding();
            holding.Members(this);
        }
    }

}