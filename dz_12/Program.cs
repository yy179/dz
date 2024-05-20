namespace dz_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle car = new car("Mazda", 120, 4);
            car.Move();
            vehicle bike = new bike("bmx", 60, "two-wheeled");
            bike.Move();
            vehicle veh = new vehicle("Train", 180);
            veh.Move();
        }
    }
}