using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
     public class Student
    {
        public string? Name;
        public int Tamil;
        public int English;
        public int Maths;
        public int Science;
        public int Social;
        public Student(string Name,int Tamil,int English,int Maths,int Science,int Social) {
            this.Name = Name;
            this.Tamil = Tamil;
            this.English = English;
            this.Maths = Maths;
            this.Science = Science;
            this.Social = Social;        
        }
        public void Average() {
            double Average = Tamil + English + Maths + Social + Science;
            Average = Average / 5;
            if (Tamil >= 40 && English >= 40 && Maths >= 40 && Social >= 40 && Science >= 40)
            {
                if (Average >=90)
                {
                    Console.WriteLine("Distinction");
                }
                else if (Average >= 75 && Average < 90)
                {
                    Console.WriteLine("First Class");
                }
                else if (Average >= 40)
                {
                    Console.WriteLine("Pass");
                }
                
            }
            else {
                Console.WriteLine("fail");
            }
        }
        

    }
}
