using Classes;

class Program
{
    public static void Main(string[] args)
    {
        M590 m590 = new(50);
        Console.WriteLine($"{nameof(m590.WeaponType)} is {m590.WeaponType}, \n" +
            $"the amount of {nameof(m590.Ammo).ToLower()} is {m590.Ammo}\n");
        m590.Shoot();

        Car car = new Car(10000);
        car.Go();
    }
}