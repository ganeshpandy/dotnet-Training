using System.Collections;

namespace QueueEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue Company = new Queue();
            Company.Enqueue("Id");
            Company.Enqueue(101);
            Company.Enqueue(102);
            Company.Enqueue(103);
            Company.Enqueue("Name");
            Company.Enqueue("AXel");
            foreach (var item in Company)
            {
                Console.WriteLine(item);
            }
            Company.Dequeue();//Returns an item from the beginning of the queue and removes it from the queue.
            Console.WriteLine();
            Console.WriteLine("After Deque");
            Console.WriteLine("=============");
            foreach (var item in Company)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Company.Peek();//Returns an first item from the queue without removing it.
            Console.WriteLine("After Peek");
            Console.WriteLine("=============");
            foreach (var item in Company) 
            {
            Console.WriteLine(item);
            }
            
        }
    }
}