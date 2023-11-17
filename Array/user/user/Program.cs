namespace user
{
    internal class Program
    {
        static void Main(string[] args)
        {                        
            string[] user = { "ganesh", "tharmesh","gobi","sairam" };
            string[] pass = { "ganesh1", "tharmesh1", "gobi1", "sairam1" };
            Console.WriteLine("Enter the UserName:");
            string inputUser = Console.ReadLine();
            Console.WriteLine("Enter the password:");
            string inputPassword = Console.ReadLine();
            bool flag= false;
            foreach(string userName in user) { 
            foreach(string password in pass)
                {
                    if (inputUser == userName && inputPassword==password) 
                    {
                        flag= true;        
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Sucess Login");
            }
            else
            {
                Console.WriteLine("Login failed");
            }


        }
            
}
            
            
        }
