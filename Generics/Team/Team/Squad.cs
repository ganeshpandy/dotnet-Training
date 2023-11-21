using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    class Squad
    {
        public string? TeamName { get; set; }
        public int JerseyNo { get; set; }
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public int TotalRuns { get; set; }
        public int Ranking { get; set; }
        public int Wicket { get; set; }
       

        /*public Squad(string teamName,int jerseyNo,string playerName,int age,int totalRuns,int ranking,int wicket) 
        {
            TeamName = teamName;
            JerseyNo = jerseyNo;
            PlayerName = playerName;
            Age = age;
            TotalRuns = totalRuns;
            Ranking = ranking;
            Wicket = wicket;
        }*/

    }
}
