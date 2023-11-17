namespace p18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Team Name");
            string teamName=Console.ReadLine();
            Console.WriteLine("Score");
            long score=Convert.ToInt64(Console.ReadLine());
            double runRate = score / 6;
            Console.WriteLine("Overs");
            double overs=Convert.ToDouble(Console.ReadLine());
            cricBuzz(teamName, score,overs,runRate);
        }
        static void cricBuzz(string teamName, long score,double runRate,double overs, string series = "WorldCup") {
           
            Console.WriteLine("TeamName:" + teamName);
            Console.WriteLine("Team Score:" + score);
            Console.WriteLine("Run Rate:" + runRate);
            Console.WriteLine("Overs:" + overs);
            Console.WriteLine("series:" + series);
        }
    }
}