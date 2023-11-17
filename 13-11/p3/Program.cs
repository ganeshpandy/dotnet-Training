namespace p3
{
     class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Square();
            s.ShapeDraw();
            s = new Circle();
            s.ShapeDraw();


        }
        
    }
}