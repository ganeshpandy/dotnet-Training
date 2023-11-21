using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
     class TeamMember
    {
        public List<Squad> AddMembers()
        {
            List<Squad> list = new List<Squad>()
            {
                new Squad() {JerseyNo=18,TeamName="India",PlayerName="Kohil",Age=33,TotalRuns=765,Ranking=1,Wicket=1}
            };
            return list;
        }
        public void DisplaySquad(List<Squad> squadMemeber)
        {
            foreach (var s in squadMemeber)
            {
                Console.WriteLine("Player JerseyNo:"+s.JerseyNo);
                Console.WriteLine("Player TeamName:" + s.TeamName);
                Console.WriteLine("Player PlayerName:" + s.PlayerName);
                Console.WriteLine("Player Age:" + s.Age);
                Console.WriteLine("Player Ranking:" + s.Ranking);
                Console.WriteLine("Player Wicket:" + s.Wicket);
                Console.WriteLine("Player TotalRuns:" + s.TotalRuns);
            }
        }
    }
}
