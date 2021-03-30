using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace PeterGardinerAssignment10.Models
{
    public partial class Teams
    {
        public Teams()
        {
            Bowlers = new HashSet<Bowlers>();
            TourneyMatchEvenLaneTeams = new HashSet<TourneyMatch>();
            TourneyMatchOddLaneTeams = new HashSet<TourneyMatch>();
        }

        [Key]
        public long TeamId { get; set; }
        public string TeamName { get; set; }
        public long? CaptainId { get; set; }

        public virtual ICollection<Bowlers> Bowlers { get; set; }
        public virtual ICollection<TourneyMatch> TourneyMatchEvenLaneTeams { get; set; }
        public virtual ICollection<TourneyMatch> TourneyMatchOddLaneTeams { get; set; }
    }
}
