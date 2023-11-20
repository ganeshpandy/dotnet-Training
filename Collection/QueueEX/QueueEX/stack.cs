using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueEX
{
    class StackExamples
    {
        static void Main(string[] args)
        {

            StackMain stackMain = new StackMain();
            Stack stack = new Stack();

            stack = stackMain.LoadStackSave();  //Loading the Stack 
            stackMain.DisplayStackItems(stack);  //Pass the Stack Objects and Displays 
            stackMain.DeleteStackItems(stack);   //Deletes the Items from the stack

        }
    }



    class StackMain
    {
        public Stack LoadStackSave()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Stack Loaded ... ");

            return stack;
        }

        public void DisplayStackItems(Stack stack)
        {
            if (stack != null && stack.Count > 0)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }


        public void DeleteStackItems(Stack stack)
        {
            Console.WriteLine("Delete Stack Items Started... ");
            if (stack != null && stack.Count > 0)
            {
                stack.Pop();

                Console.WriteLine(" Stack Items After Deleted... ");
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
