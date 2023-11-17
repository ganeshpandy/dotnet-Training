using System;
using System.Collections;
namespace ArrayList1
{
     class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList()//for creating arraylist
            {"Employee ID",101,"Employee Name","alex" };                      
            Console.WriteLine("Employee Details");
            Console.WriteLine("================");
           foreach (var data in arrayList)//for displayling arraylist 
            {
            Console.WriteLine(data);
            }

           Console.WriteLine();
            ArrayList arrayList2 = new ArrayList() { "Role","Tester" };
           Console.WriteLine("Insert Method");
           Console.WriteLine("================");
            try
            {
                arrayList2.Insert(arrayList2.Count, "salary");//for insert the data into previous list
                arrayList2.InsertRange(3, arrayList2);//for insert from range
                foreach (var data in arrayList2)
                {
                    Console.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Clone Method");
            Console.WriteLine("================");
            arrayList.AddRange(arrayList2);
        }
    }
}
