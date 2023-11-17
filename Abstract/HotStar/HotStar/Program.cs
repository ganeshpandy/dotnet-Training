namespace HotStar
{
    abstract class Package {
        public int super;
        public int premium;
        public Package(int super,int premimum) { 
            this.super = super;
            this.premium = premimum;
        }
        public abstract void SuperPack();
        public abstract void PremiumPack();
        public void display() { }
    }
    class PaidPackage : Package
    {
        public PaidPackage(int super, int premium) : base(super, premium) {
            this.super=super;
            this.premium=premium;
        }
        
        public override void SuperPack() {
            Console.WriteLine("Watch On TV (or)Laptop");            
            Console.WriteLine("No of devices can be Logged in(4)");
            Console.WriteLine("Video Quality(Full HD 1080P");
        }
        public override void PremiumPack() {
            Console.WriteLine("Watch On TV (or)Laptop");
            Console.WriteLine("Ads free Movies & Shows(Except Sports)");
            Console.WriteLine("No of devices can be Logged in(4)");
            Console.WriteLine("Video Quality(4K 2160P");
        }
        public void check(int super,int premium) {
            if(super>899 && super<=900)
                SuperPack();
            else
                PremiumPack();                      
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Ur choice super pack/premium pack");
            int super = Convert.ToInt32(Console.ReadLine());
            int premium= Convert.ToInt32(Console.ReadLine());
            PaidPackage pp=new PaidPackage(super,premium);
            pp.check(super,premium);
        }
    }
}