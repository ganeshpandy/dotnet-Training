namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {2,7,3,9,4,1,8,5};
            int[] a2 = new int[a.Length];
            Console.WriteLine("Length of Array:"+a.Length);
            Console.WriteLine("index of a[1]"+Array.IndexOf(a,1));

            Array.Sort(a);
            Console.WriteLine("Sorted Array:");
            printArray(a);
            Console.WriteLine();

            Array.Copy(a,a2,a.Length);
            Console.WriteLine("a2 is Copy of a");
            printArray(a2);
            Console.WriteLine();

            Array.Reverse(a2);
            Console.WriteLine("Reverse order of a2");
            printArray(a2);
            Console.WriteLine();

        }
        static void printArray(int[] a) {
            foreach (int arr in a)
                Console.Write(arr+",");
        }

    }
}

//foreach (int i in a)
//    Console.Write(i +",");