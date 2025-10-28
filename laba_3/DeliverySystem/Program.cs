namespace DeliverySystem
{
    public class Program
    {
        public static void Main()
        {
            Vehicle scooter = new Scooter("Honda Gyro X", 2022, 800, 45);
            Vehicle car = new Car("Nissan GT-R R35", 2021, 18000, 2);
            Vehicle van = new Van("Toyota HiAce", 2018, 92000, 3, 1500);

            Console.WriteLine(scooter.GetInfo());
            Console.WriteLine($"Max speed: {scooter.GetMaxSpeed()} km/h");
            scooter.Move(20);
            ((Scooter)scooter).Charge();

            Console.WriteLine();
            Console.WriteLine(car.GetInfo());
            Console.WriteLine($"Max speed: {car.GetMaxSpeed()} km/h");
            car.Move(50);

            Console.WriteLine();
            Console.WriteLine(van.GetInfo());
            Console.WriteLine($"Max speed: {van.GetMaxSpeed()} km/h");
            ((Van)van).LoadCargo(800);
            Console.WriteLine(van.GetInfo());
            ((Van)van).LoadCargo(300);
            ((Van)van).UnloadCargo();
        }
    }
}
