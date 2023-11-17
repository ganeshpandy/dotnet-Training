using System.Drawing;

namespace Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] user = { "ganesh", "alex" };
            string[] pass = { "ganesh1","alex1" };
            //Console.WriteLine("Enter the size of the array:");
            //int size = Convert.ToInt32(Console.ReadLine());
            string[] userName = new string[user.Length];
            Console.WriteLine("Enter the UserName:");
            for (int i = 0; i < user.Length; i++)
            {
                userName[i] = Console.ReadLine();
            }
            string[] password = new string[pass.Length];
            Console.WriteLine("Enter the Password:");
            for (int i = 0; i < pass.Length; i++)
            {
                password[i] = Console.ReadLine();
            }
            if (userName == user)
            {
                Console.WriteLine("login successful");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
            

            /*foreach (string i in userName)
            {
                Console.WriteLine(i);
            }*/

        }
    }
}
