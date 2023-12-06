using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
     class CollegeRegistration
    {
        public string Name {  get; set; }
        public string CollegeName { get; set; }
        public string Course {  get; set; }
        public int Amount {  get; set; }
        public long Phno { get; set; }
        List<CollegeRegistration> list = new List<CollegeRegistration>();
       

        public List<CollegeRegistration> LoadDetails()
        {

            CollegeRegistration Reg = new CollegeRegistration();

            Console.WriteLine("Enter Name");
            Reg.Name = Console.ReadLine()!;

            Console.WriteLine("Enter CollegeName");
            Reg.CollegeName = Console.ReadLine()!;

            Console.WriteLine("Enter Course");
            Reg.Course = Console.ReadLine()!;
            
            Console.WriteLine("Enter Amount");
            Reg.Amount=int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Phone number");
            Reg.Phno =long.Parse(Console.ReadLine()!);

            new CollegeRegistration()
            {
                Name = Reg.Name,
                CollegeName = Reg.CollegeName,
                Course = Reg.Course,
                Amount = Reg.Amount,
                Phno= Reg.Phno
            };
            list.Add(Reg);
            return list;
        }

    }
}
