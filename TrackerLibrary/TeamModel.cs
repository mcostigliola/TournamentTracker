using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// The team of the tournament
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represent a list of members of a team
        /// </summary>
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        /// <summary>
        /// The name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
