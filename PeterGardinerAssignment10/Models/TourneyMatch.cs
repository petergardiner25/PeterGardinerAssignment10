﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PeterGardinerAssignment10.Models
{
    public partial class TourneyMatch
    {
        public TourneyMatch()
        {
            MatchGames = new HashSet<MatchGame>();
        }

        public long MatchId { get; set; }
        public long? TourneyId { get; set; }
        public string Lanes { get; set; }
        public long? OddLaneTeamId { get; set; }
        public long? EvenLaneTeamId { get; set; }

        public virtual Teams EvenLaneTeam { get; set; }
        public virtual Teams OddLaneTeam { get; set; }
        public virtual Tournament Tourney { get; set; }
        public virtual ICollection<MatchGame> MatchGames { get; set; }
    }
}