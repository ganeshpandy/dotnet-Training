namespace LoginTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<LoginDetails> details = new List<LoginDetails>();
            details = LoginMain.LoadDetails();

            var Selected = from data in details
                              where data.Name== "Alex"
                              select data;

           /* foreach (var data in details)
            {
               
                //Console.WriteLine($"Name: {data.Name}, Email: {data.Email}, Phone: {data.Phno}");                
            }*/
            foreach (var item in Selected)
            {
                Console.WriteLine($"Name: {item.Name}, Username: {item.Email}, Password: {item.Password}");
                
            }

        }
    }
}
