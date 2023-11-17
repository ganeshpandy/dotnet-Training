namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] trainName = { "pallavan", "sahapti" };
            int[] ticketCount = {120,100};
            Console.WriteLine("Enter the TrainName:");
            String inputName=Console.ReadLine();
            Console.WriteLine("Enter how much seat u want:");
            int inputSeatNo =Convert.ToInt32(Console.ReadLine());
            int available=0;


            bool flag = false;
            foreach(string tn in trainName)
            {
                foreach(int tc in ticketCount) 
                {
                    if (inputName == tn && inputSeatNo <= tc) 
                    {
                        available = tc - inputSeatNo;                        
                            flag = true;
                            break;                        
                    }                    
                }
            }
            if (flag)
            {
                Console.WriteLine(available + " seat is avaliable");
            }
            else 
            {
                Console.WriteLine("seat is not avaliable");
            }
        }
    }
}