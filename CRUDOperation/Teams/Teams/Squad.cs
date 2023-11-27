using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
    internal class Squad
    {
        public string? TeamName { get; set; }
        public int JerseyNo { get; set; }
        public string? PlayerName { get; set; }
        public int Age { get; set; }
        public int TotalRuns { get; set; }
        public int Ranking { get; set; }
        public int Wicket { get; set; }
        //TeamName,JerseyNo,PlayerName,Age,TotakRuns,Ranking,Wicket
    }
}
