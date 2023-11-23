namespace Constructor6
{
     class Program
    {
        static void Main(string[] args)
        {
            LoadData loadData = new LoadData();
            loadData.display();
        }
    }
    class LoadData 
    {
        public int id=int.Parse(Console.ReadLine());
        public string name=Console.ReadLine();
        public LoadData() 
        {
            id = id;
            name = name;
        }
        public void display() 
        {
            Console.WriteLine("id:" + id);
            Console.WriteLine("name:"+name);
        }
       
    }
}
