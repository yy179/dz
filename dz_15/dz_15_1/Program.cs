namespace dz_15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shopp = new Shop (12,"Table",2700);
            Cart cart = new Cart();
            Console.WriteLine(shopp.GetAllProducts());
            Console.WriteLine("------------------------");
            shopp.AddProduct(13,"Window",1890 );
            shopp.AddProduct(14, "Chair", 1200);
            Console.WriteLine(shopp.GetAllProducts());
            Console.WriteLine("------------------------");
            Console.WriteLine(shopp.GetProductById(12));
            Console.WriteLine("------------------------");
            cart.AddToCart(12);
            Console.WriteLine(cart.GetTotalPrice);
        }
    }
}