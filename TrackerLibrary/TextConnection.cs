using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        //TODO - Wire up CreatePrize to text file.
        /// <summary>
        /// Create prize to text file
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Model with Id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
