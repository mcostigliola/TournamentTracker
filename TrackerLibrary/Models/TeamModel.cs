using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// The team of the tournament
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represent a list of members of a team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// The name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
