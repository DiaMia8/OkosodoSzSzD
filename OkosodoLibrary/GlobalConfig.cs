using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// /Kapcsolat létrehozása, mindenhonnan látható, viszont csak innen módosítható, csak az itt fellelhető metódusok változtathatják meg a benne lévő adatokat
        /// </summary>
        static public List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        
        //Jelenleg csak adatbázisna lehet menteni, de skálázható txt vagy mySql-re is
       
        public static void InitializeConnections(bool database)
        {
            if (database)
            {
                //TODO - SQL kapcsolat létrehozása
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
        }
    }
}
