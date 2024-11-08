using System;

public class Car
{
    private string _brand;
    private int _speed;
    
    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }

    public int Speed
    {
        get { return _speed; }
        set
        {
            if (value >= 0 && value <= 200)
            {
                _speed = value;
            }
            else
            {
                Console.WriteLine("error, speed vared shode bishtar az had mojaz ast. mahdoode mojaz:( 0 - 200 )");
            }
        }
    }

    public Car(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"khodro {Brand} ba sorate {Speed} Km/h");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("peride", 40);
        car1.PrintInfo();

        car1.Speed = 220;
        car1.PrintInfo();
    }
}
