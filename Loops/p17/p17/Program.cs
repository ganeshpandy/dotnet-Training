namespace p17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter pizza Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter size");
            string size=Console.ReadLine();
            Console.WriteLine("Enter Extras");
            string extras=Console.ReadLine();
            Console.WriteLine("Add cart Item");
            int item=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price");
            float price=Convert.ToSingle(Console.ReadLine());
            pizza(name, size, extras, item,price);
        }
        static void pizza(string name,string size,string extras,int item,float price) {
            Console.WriteLine("pizza Name:"+name);
            Console.WriteLine("Size:" + size);
            Console.WriteLine("Extras" + extras);
            Console.WriteLine("item" + item);
            Console.WriteLine("price"+price);

                
         }
    }
}