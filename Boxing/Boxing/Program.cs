namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int num = 2020;

            // boxing
            object obj = num;//2020           
            num = 100;//change the value
            
            //unboxing
            int i = (int)obj;

            Console.WriteLine("Value - type value of num is : {0}", num);
            Console.WriteLine("Object - type value of obj is : {0}", obj);
            Console.WriteLine("Value of i is : " + i);
        }
    }
}
