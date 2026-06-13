Car Peogeout = new Car("206", "Blue Sky", 25000000, 1385);
string warranty = Car.CheckWarranty(10011012);
Console.WriteLine(warranty);


public class Car
{
    readonly string Name;
    readonly string Color;
    readonly Int32 Price;
    readonly Int16 YearOfCreate;
    static readonly int[] ValidSeries = new int[10] { 10011012, 10011013, 10011014, 10011015, 10011016, 100110117, 10011018, 10011019, 10011020, 10011021 };

    public Car(string name, string color, Int32 price, Int16 yearOfCreate)
    {
        Name = name;
        Color = color;
        Price = price;
        YearOfCreate = yearOfCreate;
    }

    public static string CheckWarranty(int seriesNumber)
    {
        foreach (var series in ValidSeries)
        {
            if (seriesNumber == series)
            {
                return "Your warranty still remains for 3 years or 20000 kilometer, " +
                       "check this link below to find more information about your car";
            }
        }
        return "Car warranty not found! Please check the series number";
    }
}
