namespace p14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Brand Name");
            string brandName=Console.ReadLine();
            Console.WriteLine("Enter Brand Model");
            string brandModel=Console.ReadLine();
            Console.WriteLine("Enter color");
            string color=Console.ReadLine();
            Console.WriteLine("Enter price");
            double price=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter discount");
            int offer=Convert.ToInt32(Console.ReadLine());
            amazon(brandName,brandModel,color,price,offer);
        }
        static void amazon(string brandName,string brandModel,string color,double price,int offer) {
            Console.WriteLine("BrandName:" + brandName);
            Console.WriteLine("BrandModel:" + brandModel);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("price:" + price);
            Console.WriteLine("offer:" + offer);
        }
    }
}