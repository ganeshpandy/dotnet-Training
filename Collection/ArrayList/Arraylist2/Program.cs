using System.Collections;

namespace Arraylist2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("    Menu List");
            Console.WriteLine("=====================");
            ArrayList myAL = new ArrayList();            
            myAL.Insert(0, "FriedRice");
            myAL.Insert(1, "CurdRice");
            myAL.Insert(2, "TomatoRice");
            myAL.Insert(3, "LemonRice");
            myAL.Insert(4, "Biryani");
            myAL.Insert(5, "Full Meals");

            string[] Customer = { "Name" ,"alex","Address","TN"};
            foreach (var data in myAL) 
            {
            Console.WriteLine(data);
            }
            /*Console.WriteLine("==================");
            Console.WriteLine("InsertRange Method");
            Console.WriteLine("==================");
            myAL.InsertRange(1, myAL);
            foreach (var data in myAL)
            {
                Console.WriteLine(data);
            }*/
            Console.WriteLine("==================");
            ArrayList myAL2 = new ArrayList() { 0,1};
          
            Console.WriteLine("Enter the option:\n"+ "1.contains\n"+"2.Clone");
            int option = int.Parse(Console.ReadLine());
            switch (option) {
                case 1:
                    Console.WriteLine("==================");
                    Console.WriteLine("Contains Method");
                    Console.WriteLine("==================");
                    Console.WriteLine(myAL.Contains("120"));
                    break;
                case 2:
                    Console.WriteLine("==================");
                    Console.WriteLine("Clone Method");
                    Console.WriteLine("==================");
                    myAL2=(ArrayList)myAL.Clone();
                    foreach (var data in myAL2) 
                    {
                        Console.WriteLine(data);
                    }
                    break;
                case 3:
                    Console.WriteLine("==================");
                    Console.WriteLine("CopyTo Method");
                    Console.WriteLine("==================");

                    break;

            }
            
        }
    }
}