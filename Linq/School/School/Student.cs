namespace School
{
    internal class Student
    {
        public int DepartmentId { get; set; }        
        public string StudentName { get; set; }
        public string Standard { get; set; }
        public List<int>Marks = new List<int>();
        public int TotalMarks {  get; set; }
        List<Student>list = new List<Student>();
        
        Student stud = null;
        public List<Student> LoadStudent()
        {
            list.Add(new Student() { DepartmentId = 1, StudentName = "Alex", Standard = "10th", Marks = new List<int> { 33, 44, 54, 23, 54, 67 } });
            list.Add(new Student() { DepartmentId = 1, StudentName = "Bolt", Standard = "10th", Marks = new List<int> { 45, 56, 67, 67, 89, 90 } });
            list.Add(new Student() { DepartmentId = 1, StudentName = "Charles", Standard = "10th", Marks = new List<int> { 78, 45, 78, 45, 78, 89 } });

            return list;
        }
        public void Display()
        {
            
            foreach (var student in list)
            {
                var total = student.Marks.Sum();
                Console.WriteLine($"{student.StudentName}'s Total Marks: {total}");               
                student.TotalMarks = total;

                var count=student.Marks.Count();
                Console.WriteLine("Count: "+count);

                var avg=student.Marks.Average();
                Console.WriteLine("Average: "+avg);               

            }          
            var max = list.Max(student => student.TotalMarks);
            Console.WriteLine($"Maximum Total Mark Among Students: {max}");

            /*var Pass = list.All(student => student.Marks.All(mark => mark > 50));
            Console.WriteLine($"Studentmarks"+Pass);*/
        }
    }
}

