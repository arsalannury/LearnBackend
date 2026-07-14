namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    class A
    {
        public void Foo(B instanceB)
        {
            Console.WriteLine(instanceB);
        }
    }

    class B
    {
        public string Property = "Test";

        public void Test()
        {
            var instance = new A();
            instance.Foo(this);
        }
    }

}