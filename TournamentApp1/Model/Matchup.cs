using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp1.Model
{
    internal class Matchup
    {
        private List<MatchupEntry> Entries;
        private Team Winner { get; set; }
        private int MatchupRound { get; set; }
     }
}
