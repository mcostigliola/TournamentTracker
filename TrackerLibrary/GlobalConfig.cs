using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnection(bool database, bool textFiles)
        {
            if(database)
            {
                //TODO - Create Database connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                //TODO - Ceate text connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
