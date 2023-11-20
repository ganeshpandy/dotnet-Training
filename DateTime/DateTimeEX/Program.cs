namespace DateTimeEX
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Please Enter Date of birth");

            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please Enter Date of school open (YYYY-MM-DD):");

            string? UserInput = Console.ReadLine();

            if (DateOnly.TryParse(UserInput, out DateOnly DateOfSchoolOpen))

            {

                Console.WriteLine($"School open om :{DateOfSchoolOpen}");

            }

            else

            {

                Console.WriteLine("Invalid format");

            }

            DateTime RegDate = DateTime.Now;
        }
           
        class Student

        {

            public int Id { get; set; }

            public string? Name { get; set; }

            public DateTime dob { get; set; }

            public DateTime RegDate { get; set; } = DateTime.Now;

            public DateOnly DateOfSchoolOpen { get; set; } = new DateOnly();

            public Student(int id, string name, DateTime DOB, DateTime rEGDATE, DateOnly SCHOOLOPEN)

            {

                Id = id;

                Name = name;

                dob = DOB;

                RegDate = rEGDATE;

                DateOfSchoolOpen = SCHOOLOPEN;

            }

            public void Display()

            {

                string Path = @"C:\Users\LENOVO\Desktop\DotNet\DateTime\dateTime.txt";

                string Detail = "\n" + " Student Detail " + "\n" + "ID :" + Id + "\n" + "Name : " + Name + "\n" +

                    "Date : " + dob + "\n" + "Registeration Date :" + RegDate + "\n" + "DateOfSchoolOpen  :" + DateOfSchoolOpen;

                File.AppendAllText(Path, Detail);

            }

        }
    }
    }
