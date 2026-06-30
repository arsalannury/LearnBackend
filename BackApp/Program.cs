Car pride = new Car("Pride 131", "Blue Sky", 4_500_000);

Console.WriteLine(pride.CalculateCarPrice());

class Car
{
    // default constructor parameter less \\
    string _name; // -> default value is empty string
    string _color; // -> default value is empty string
    int _price; // -> default value is 0

    public Car(string name, string color, int price)
    {
        _name = name;
        _color = color;
        _price = price;
    }

    public int CalculateCarPrice()
    {
        int constantPriceBaseYear = 1000;

        return (this._price * constantPriceBaseYear) / (DateTime.Now.Year - 2000);
    }

}