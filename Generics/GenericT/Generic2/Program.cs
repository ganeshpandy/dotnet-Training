namespace Generic2
{
     class Program
    {
        static void Main(string[] args)
        {
            Stud<object>obj=new Stud<object>(101,"alex",15,"W3School",10,456);
            obj.display();

        }
    }
    class Stud<T> 
    {
        public T StudId { get; set; }
        public T Name { get; set; }
        public T Age { get; set; }    
        public T SchoolName {  get; set; }
        public T Standard { get; set; }
        public T TotalMark {  get; set; }
        public Stud(T StudId,T Name,T Age,T SchoolName,T Standard,T TotalMark) 
        {
            this.StudId = StudId;
            this.Name = Name;
            this.Age = Age;
            this.SchoolName = SchoolName;
            this.Standard = Standard;
            this.TotalMark = TotalMark;
        }
        public void display() 
        {
            Console.WriteLine("Student ID:"+StudId);            
            Console.WriteLine("Student Name:"+Name);
            Console.WriteLine("Student Age:" + Age);
            Console.WriteLine("School Name:"+SchoolName);
            Console.WriteLine("Standard:"+Standard);
            Console.WriteLine("TotalMark:" + TotalMark);

        }

    }
}
