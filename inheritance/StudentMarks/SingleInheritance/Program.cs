namespace SingleInheritance
{
    class Animal {
    public void eat() {
            Console.WriteLine("Animal eat");
        }
    }
    class Tiger:Animal {
        public void hunt() {
        Console.WriteLine("Tiger used to hunt for eating");
        }
    }
    
     class Program
    {
        static void Main(string[] args)
        {
            Tiger t=new Tiger();
            t.hunt();
            t.eat();            
        }
    }
}