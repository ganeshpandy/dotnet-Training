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
            myAL.Insert(0, "FRIEDRICE");
            myAL.Insert(1, "CURDRICE");
            myAL.Insert(2, "TOMATORICE");
            myAL.Insert(3, "LEMONRICE");
            myAL.Insert(4, "BIRYANI");
            myAL.Insert(5, "FULL MEALS");

            string[] Customer = new String[10];
            Customer[0] = "Name";
            Customer[1] = "Alex";
            Customer[2] = "Address";
            Customer[3] = "TN";
            foreach (var data in myAL) 
            {
            Console.WriteLine(data);
            }
            Console.WriteLine("==================");
            //ArrayList myAL2 = new ArrayList() { 0,1};
          
            Console.WriteLine("Enter the Option:\n"+
            "1.For Enter the FoodItem\n" + "2.For Menu List\n" + "3.CopyTo\n"+"4.GetRange\n"+"5.InsertRange");
            int option = int.Parse(Console.ReadLine());
            //string Order = "";
            switch (option) {
                case 1:
                    Console.WriteLine("===================================");
                    Console.WriteLine("Enter the FoodItem(Contains Method)");
                    Console.WriteLine("===================================");
                    string Fooditem=Console.ReadLine().ToUpper();
                    for (int i = 0; i < myAL.Count; i++) {
                        Console.WriteLine(myAL.Contains(Fooditem));
                        break;
                    }
                    break;
                case 2:
                    Console.WriteLine("==================");
                    Console.WriteLine("Menu List(Clone Method)");
                    Console.WriteLine("==================");
                    myAL=(ArrayList)myAL.Clone();
                    foreach (var data in myAL) 
                    {
                        Console.WriteLine(data);
                    }
                    break;
                case 3:
                    Console.WriteLine("==================");
                    Console.WriteLine("CopyTo Method");
                    Console.WriteLine("==================");
                    myAL.CopyTo(Customer,6);
                    foreach (var item in Customer)
                    {
                        Console.WriteLine(item);
                        //Order= item;
                    }
                    break;
                case 4:
                    Console.WriteLine("==================");
                    Console.WriteLine("GetRange Method");
                    Console.WriteLine("==================");
                    ArrayList newarraylist = myAL.GetRange(0, 6);
                    foreach (var data in newarraylist)
                    {
                        Console.WriteLine(data);
                    }
                    break;
                case 5:
                    Console.WriteLine("==================");
                    Console.WriteLine("InsertRange Method");
                    Console.WriteLine("==================");
                    myAL.InsertRange(1, myAL);
                    foreach (var data in myAL)
                    {
                        Console.WriteLine(data);
                    }
                    break;
                default: Console.WriteLine("Invalid Option");break;
               
                    


            }
            
        }
    }
}