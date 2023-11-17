namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Helloworld";
            string s2 = "hello";
            string s3 =(string)s1.Clone();
            Console.WriteLine("clone method:"+s3);
            Console.WriteLine("Length method" + s1.Length);
            Console.WriteLine("Upper method:" + s2.ToUpper());
            Console.WriteLine("Lower method:" + s3.ToLower());
            Console.WriteLine("Concat method:"+string.Concat(s1, s2));
            Console.WriteLine("Contains method:" + s1.Contains(s2));
            Console.WriteLine("Equals method:"+s1.Equals(s2));
            Console.WriteLine("Remove method:" + s1.Remove(2));
            Console.WriteLine("Replace method:" + s1.Replace('H', 'F'));
            Console.WriteLine("Remove method:" + s1.Remove(2));
            Console.WriteLine("Substring method:" + s1.Substring(2));





        }
    }
}