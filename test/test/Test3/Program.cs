namespace Test3
{
     class Program
    {
        static void Main(string[] args)
        {
            
            stud stud=new stud("alex",101,12345);
            Console.WriteLine(stud.Name);

        }
    }
    public class stud 
    {
        public string Name;
        public int Id;
        long Phno;
        public stud(string Name,int Id,long Phno) 
        {
            this.Name=Name;
            this.Id=Id;
            this.Phno= Phno;            


        }
    }
}
