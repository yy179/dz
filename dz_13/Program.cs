namespace dz_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal bird = new Bird();
            dog.Move();
            dog.MakeSound();
            bird.Move();
            bird.MakeSound();
        }
    }
}