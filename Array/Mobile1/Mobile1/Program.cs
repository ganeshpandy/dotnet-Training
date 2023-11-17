namespace Mobile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Samsung","Nokia","Redmi","Lenovo","Nothing","Iphone","Lava"};
            int i = 0;
            while (i < names.Length) 
            {
                Console.WriteLine("Mobile Name:" + names[i]);
                i++;
            } 
        }
    }
}