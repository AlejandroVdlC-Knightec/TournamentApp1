using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp1.Model
{
    internal class Tournament
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<Team> EnteredTeams { get; set; }
        public List<Prize> Prizes { get; set; }
        public List<List<Matchup>> Rounds { get; set; }

    }
}
