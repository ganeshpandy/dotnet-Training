using System.Collections;

namespace stack
{
     class Program
    {
        static void Main(string[] args)
        {
           
                StackMain stackMain = new StackMain();
                Stack stack = new Stack();

                stack = stackMain.LoadStack();  //Loading the Stack 
                stackMain.DisplayStackItems(stack);  //Pass the Stack Objects and Displays 
                stackMain.DeleteStackItems(stack);   //Deletes the Items from the stack            
        }
    }
    



    class StackMain
    {
        public Stack LoadStack()
        {
            Stack stack = new Stack();
            stack.Push("samsung");
            stack.Push("Nokia");
            stack.Push("Xolo");

            Console.WriteLine("Stack Loaded!!! ");

            return stack;
        }

        public void DisplayStackItems(Stack stack)
        {
            if (stack != null && stack.Count != 0)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }


        public void DeleteStackItems(Stack stack)
        {
            Console.WriteLine("Delete Stack Items");
            if (stack != null && stack.Count != 0)
            {
                stack.Pop();

                Console.WriteLine(" Stack Items After Deleted");
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}