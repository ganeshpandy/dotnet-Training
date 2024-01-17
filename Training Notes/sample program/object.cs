class Test
    {
        static void Main(string[] args)
        {

            //ClassName ObjectName = new ClassName();

            Example exampleObject = new Example();

            exampleObject.Write();

            exampleObject.Read();

            string GameName = exampleObject.Play();

            Console.WriteLine(GameName);


            Example example = new Example();
            example.Write();
            example.Read();
            string GameName1 = example.Play();

            Console.WriteLine(GameName1);
        }

    }

    class Example
    {

        public string Name = "Name of the Class";

        public void Write()
        {
            Console.WriteLine("I am from Example Class and Write Method");
        }

        public void Read() 
        {
            Console.WriteLine("I am from Example Class and Read Method");
        }


        public string Play()
        {
            string GameName = "FootBall";
            return GameName;
        }
    }
-----------------------------------------------------------------	-------------------
namespace EmployeeApplication
{
    class Test
    {


        static void Main(string[] args)
        {
            string firstName = "John";
            string LastName = "Brad";
            Int32 empId = 1001;
            DateTime dateTimeDOB = DateTime.Now;

            Employee employeeObject = new Employee();

           

           string fullname = employeeObject.GetEmployeeFullName(firstName, LastName);

            Console.WriteLine(fullname);


            string SaveEmployeeResponse = employeeObject.SaveEmployee(firstName, LastName, empId, dateTimeDOB);

            Console.WriteLine(SaveEmployeeResponse);
        }

    }


   class Employee
    {

        public string GetEmployeeFullName(string firstName,string LastName)
        {
            Console.WriteLine("I am from Employee Class and Method GetEmployeeFullName");
            string FullName = firstName + " " + LastName;
            return FullName;
        }


        public string SaveEmployee(string firstName,string lastName,int EmpId, DateTime DOB)
        {
            Console.WriteLine("I am from Employee Class and Method SaveEmployee ");
            //DO DB operation 


            return  "Employee Details Saved"; 
        }

    }


   

}
-------------------------------------------------------------------------------------------------------

namespace EmployeeApplication
{
    class Test
    {


        static void Main(string[] args)
        {           
            Example example = new Example();
            example.Read();
        }

    }


 
    class Example
    {
        string CompanyName;
        public Example()
        {
             CompanyName = "SIS Training";
          
        }


        public void Read()
        {
            Console.WriteLine("I am from Read Method and Example Class");

            Console.WriteLine(CompanyName);
        }


        public void Write()
        {
            Console.WriteLine("I am from Write Method and Example Class");

            Console.WriteLine(CompanyName);
        }
    }

   

}


-------------------------------------------------------------------------------------


 class Test
    {


        static void Main(string[] args)
        {
            

            Example example = new Example();

            Example example1 = new Example("Ganesh");
        }

    }


 
    class Example
    {
        string CompanyName;
        public Example()
        {
            Console.WriteLine("I am from Read Method and Example Class");

        }

        public Example(string Name)
        {
            Console.WriteLine("I am Example with Parameter");

        }


        public void Read()
        {
            Console.WriteLine("I am from Read Method and Example Class");

            Console.WriteLine(CompanyName);
        }


        public void Write()
        {
            Console.WriteLine("I am from Write Method and Example Class");

            Console.WriteLine(CompanyName);
        }
    }
	
	
----------------------------------------------------------------------------------
	
	
	  class Test
    {


        static void Main(string[] args)
        {

            Employee employee  = new Employee();


        }

    }


 
    class Employee
    {
        string FName = string.Empty;
        string LName = string.Empty;
        string Email = string.Empty;
        public Employee() 
        
        {
            FName = "Virat";

            LName = "Koli";

            Email = "Virat@gmail.com";

            Console.WriteLine(FName);
            Console.WriteLine(LName);
            Console.WriteLine(Email);

        }
       
       
    }
	
-----------------------------------------------	-------------
	
	
	
	  class Test
    {


        static void Main(string[] args)
        {

            Employee employee  = new Employee();


        }

    }


 
    class Employee
    {
        string FName = string.Empty;
        string LName = string.Empty;
        string Email = string.Empty;
        public Employee() 
        
        {
            FName = "Virat";

            LName = "Koli";

            Email = "Virat@gmail.com";

            Console.WriteLine(FName);
            Console.WriteLine(LName);
            Console.WriteLine(Email);

        }
       
       
    }