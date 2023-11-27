using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
     class PlayerDetails:Squad
    {
        List<Squad> list = new List<Squad>();
        Squad squad = null, OldData = null;
        //TeamName,JerseyNo,PlayerName,Age,TotalRuns,Ranking,Wicket
        public List<Squad> Create()
        {
            Squad squad = new Squad();

            Console.Write("Enter TeamName : ");
            squad.TeamName = Console.ReadLine()!;

            Console.Write("Enter JerseyNo : ");
            squad.JerseyNo =int.Parse(Console.ReadLine()!);

            Console.Write("Enter PlayerName : ");
            squad.PlayerName = Console.ReadLine();

            Console.Write("Enter Age : ");
            squad.Age = int.Parse(Console.ReadLine()!);

            Console.Write("Enter TotalRuns : ");
            squad.TotalRuns = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Ranking : ");
            squad.Ranking = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Wicket : ");
            squad.Wicket = int.Parse(Console.ReadLine()!);

            squad = new PlayerDetails()
            {
                TeamName = squad.TeamName,
                JerseyNo=squad.JerseyNo,
                PlayerName=squad.PlayerName,
                Age=squad.Age,
                TotalRuns=squad.TotalRuns,
                Ranking=squad.Ranking,
                Wicket=squad.Wicket,
            };
            list.Add(squad);
            Console.WriteLine("Details created!");
            return list;
        }
        //TeamName,JerseyNo,PlayerName,Age,TotalRuns,Ranking,Wicket
        public void Read()
        {
            if (list.Count > 0)
            {
                foreach (var data in list)
                {
                    Console.WriteLine("TeamName         : " + data.TeamName);
                    Console.WriteLine("JerseyNo         : " + data.JerseyNo);
                    Console.WriteLine("PlayerName       : " + data.PlayerName);
                    Console.WriteLine("Player Age       : " + data.Age);
                    Console.WriteLine("Player TotalRuns : " + data.TotalRuns);
                    Console.WriteLine("Player Ranking   : " + data.Ranking);
                    Console.WriteLine("Wicket           : " + data.Wicket);
                }
            }
            else
            {
                Console.WriteLine("data not found!");
            }
        }
        //TeamName,JerseyNo,PlayerName,Age,TotalRuns,Ranking,Wicket
        public void Update()
        {
            Console.Write("Enter  ID to update: ");
            int UpdatePlayer = int.Parse(Console.ReadLine()!);
            foreach (var data in list)
            {
                if (data.JerseyNo == UpdatePlayer)
                {
                    OldData = data;
                    break;
                }
            }
            Console.WriteLine("Enter the TeamName");
            squad.TeamName = Console.ReadLine()!;

            Console.WriteLine("Enter the JerseyNo");
            squad.JerseyNo = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the PlayerName");
            squad.PlayerName = Console.ReadLine()!;

            Console.WriteLine("Enter  the Age");
            squad.Age =int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the TotalRuns");
            squad.TotalRuns =int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter New Ranking : ");
            squad.Ranking = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the PhoneNo");
            squad.Wicket = int.Parse(Console.ReadLine()!);
        }
        public void Delete()
        {
            if (true)
            {
                list.Clear();
                Console.WriteLine("All records deleted!");
            }
            else
            {
                Console.WriteLine("No records found!");
            }
        }
        public void Display()
        {
            while (true)
            {
                Console.WriteLine("Enter the option\n" + "1.Create\n" + "2.Update\n" + "3.Read\n" + "4.Delete");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Create();
                        Console.WriteLine("Data created");
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Read();
                        break;
                    case 4:
                        Delete();
                        break;

                }
                //Console.ReadKey();
            }
        }
    }
}
