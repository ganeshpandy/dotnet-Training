namespace p4
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Choice:+,-,*,/");
            string choice=Console.ReadLine();
            switch (choice) {
                    case "+":
                    Console.WriteLine("Addition");
                    Add(a, b); break;
                    case "-":
                    Console.WriteLine("Subtraction");
                    Sub(a, b); break;
                    case "*":
                    Console.WriteLine("Multiplication");
                    Mul(a, b); break;
                    case "/":
                    Console.WriteLine("Division");                   
                    if (b ==0)
                    {                         
                        Console.WriteLine("Zero cannot be Accepted");                        
                    }
                    Div(a, b);
                    break;
                    
                default: Console.WriteLine("Invalid option");break;
            }
            /*
            Add(a,b);
            
            Sub(a,b);
              
            Mul(a,b);
            
            Div(a,b);*/
        }

        public static void Add(int a,int b) {
        Console.WriteLine(a+b);
        }
        public static void Sub(int a,int b) {
            Console.WriteLine(a-b);
        }
        public static void Mul(int a,int b) {
        Console.WriteLine(a*b);
        }
        public static void Div(int a,int b) {
        Console.WriteLine(a/b);
        }
    }
}