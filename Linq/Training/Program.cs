using System;

namespace Training
{
    //SET OPERATOR
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDetails.LoadStudent();
            StudentDetails.LoadCourse();

            /*Console.WriteLine("UNION");
            var union = StudentDetails.LoadStudent().Union(StudentDetails.LoadCourse());
            foreach (string item in union)
            {
                Console.WriteLine(item);
            }*/


            /*Console.WriteLine("------------------");
            Console.WriteLine("Intersect");
            var intersect = StudentDetails.LoadStudent().Intersect(StudentDetails.LoadCourse());
            foreach (string item in intersect)
            {
                Console.WriteLine(item);
            }    */

            /*Console.WriteLine("------------------");
            Console.WriteLine("Except");
            var except = StudentDetails.LoadStudent().Except(StudentDetails.LoadCourse());           
            foreach (string item in except)
            {
                Console.WriteLine(item);
            }*/

            /*Console.WriteLine("------------------");
            Console.WriteLine("Distinct");
            var distinct = StudentDetails.LoadStudent().Distinct();
            foreach (string item in distinct)
            {
                Console.WriteLine(item);
            }*/

            /*Console.WriteLine("------------------");
            Console.WriteLine("Take ");
            var take = StudentDetails.LoadStudent().Take(101);
            foreach (string item in take)
            {
                Console.WriteLine(item);
            }*/

        }
    }
}
