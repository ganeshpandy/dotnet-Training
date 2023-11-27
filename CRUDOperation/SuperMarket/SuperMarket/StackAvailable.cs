using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
     class StackAvailable:Items
    {
     Stack<Items>stack = new Stack<Items>();
        Items items = null, OldStack=null;
        //RackNo,ItemType,ItemName,ItemCount
        public Stack<Items> Create()
        {
            Items items = new Items();

            Console.Write("Enter RackNo : ");
            items.RackNo = int.Parse(Console.ReadLine()!);

            Console.Write("Enter ItemType : ");
            items.ItemType = Console.ReadLine();

            Console.Write("Enter items Name : ");
            items.ItemName = Console.ReadLine();

            Console.Write("Enter ItemCount : ");
            items.ItemCount = int.Parse(Console.ReadLine()!);

            items = new Items()
            {
                RackNo = items.RackNo,
                ItemType = items.ItemType,
                ItemName = items.ItemName,
                ItemCount = items.ItemCount,
                };
            stack.Push(items);
            Console.WriteLine("Items details created!");
            return stack;
        }
        public void Read()
        {
            if (stack.Count > 0)
            {
                foreach (var data in stack)
                {
                    Console.WriteLine("RackNo    : " + data.RackNo);
                    Console.WriteLine("ItemType  : " + data.ItemType);                    
                    Console.WriteLine("ItemName  : " + data.ItemName);
                    Console.WriteLine("ItemCount : " + data.ItemCount);
                    }
            }
            else
            {
                Console.WriteLine("stack not found!");
            }
        }
        //RackNo,ItemType,ItemName,ItemCount
        public void Update()
        {
            Console.Write("Enter  ID to update: ");
            string UpdateStack = Console.ReadLine();
            foreach (var data in stack)
            {
                if (data.ItemType == UpdateStack)
                {
                    OldStack = data;
                    break;
                }
            }
            Console.WriteLine("Enter the Id");
            items.RackNo = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the ItemType");
            items.ItemType = Console.ReadLine()!;

            Console.WriteLine("Enter new ItemName");
            items.ItemName = Console.ReadLine()!;

            Console.WriteLine("Enter the ItemCount");
            items.ItemCount =int.Parse(Console.ReadLine());
            }
        public void Delete()
        {
            if (true)
            {
                stack.Clear();
                Console.WriteLine("All records deleted!");
            }
            else
            {
                Console.WriteLine("No records found!");
            }
        }
    }
}
