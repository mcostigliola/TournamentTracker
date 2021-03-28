using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make the create prize save to Database
        /// <summary>
        /// Save a new prize to the Database
        /// </summary>
        /// <param name="model">Prize info</param>
        /// <returns>Prize with Id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
