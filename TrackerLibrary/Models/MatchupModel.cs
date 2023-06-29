using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a single match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Unique ID for Match Up
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The set of teams that were involved this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// The Winning Team of the Match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}