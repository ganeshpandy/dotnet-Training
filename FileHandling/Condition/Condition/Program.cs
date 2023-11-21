namespace Condition
{
    class Example
    {
        static void Main(string[] args)
        {
            FoodItems foodItems = new FoodItems();
            while (true)
            {
                Console.WriteLine("Enter 0 to continue or 1 to terminate : ");
                int i = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    foodItems.FoodChanges();
                }
                else
                {
                    break;
                }
            }
        }
    }
    public class FoodItems
    {
        public string? FoodName { get; set; }
        public string? FoodPrice { get; set; }
        public int Quantity { get; set; }
        public string? CustomerAddress { get; set; }
        public long? CustomerPhNo { get; set; }
        public void FoodChanges()
        {
            while (true)
            {
                Console.WriteLine("Enter choice : ");
                string myChoice = Console.ReadLine();
                if (myChoice == "create")
                {
                    if (System.IO.File.Exists("C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecords.txt"))
                    {
                        Console.WriteLine("File already created");
                    }
                    else
                    {
                        System.IO.File.WriteAllText("C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecords.txt", "");
                        Console.WriteLine("File created!");
                    }
                }
                else if (myChoice == "replace")
                {
                    System.IO.File.Replace("C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecords1.txt",
                                           "C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecords2.txt",
                                           "C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecords3.txt");
                    Console.WriteLine("Food records Replaced!");
                }
                else if (myChoice == "copy")
                {
                    try
                    {
                        System.IO.File.Copy("C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecords.txt",
                                            "C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecordscopied.txt");
                    }
                    catch (IOException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                    Console.WriteLine("Food records Copied!");
                }
                else if (myChoice == "append")
                {
                    Console.WriteLine("Enter Food Name : ");
                    FoodName = Console.ReadLine();
                    Console.WriteLine("Enter price : ");
                    FoodPrice = Console.ReadLine();
                    Console.WriteLine("Enter Quantity : ");
                    Quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Customer Address : ");
                    CustomerAddress = Console.ReadLine();
                    Console.WriteLine("Enter Phone number : ");
                    CustomerPhNo = long.Parse(Console.ReadLine());

                    string AllData = "Food order Details : \n" + "Food Name : " + FoodName +
                            "\n" + "Price : " + FoodPrice + "\n" + "Quantity : " + Quantity + "\n" + "Address : " +
                            CustomerAddress + "\n" + "Phone number : " + CustomerPhNo + "\n";
                    System.IO.File.AppendAllText("C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecord.txt", AllData);
                    Console.WriteLine("Food records Appended!");
                }
                else if (myChoice == "delete")
                {
                    System.IO.File.Delete("C:\\Users\\DELL\\Desktop\\NewFiles\\foodrecord.txt");
                    Console.WriteLine("Food records Deleted");
                }
                else
                {
                    Console.WriteLine("That's not a method");
                    break;
                }
            }
        }
    }
}