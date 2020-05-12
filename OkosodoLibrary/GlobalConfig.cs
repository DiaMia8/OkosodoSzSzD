using OkosodoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        static public IDataConnection Connection { get; private set; }
        
        //Jelenleg csak adatbázisna lehet menteni, de skálázható txt vagy mySql-re is, elestleg string bemeneti paraméterekkel, enumban dolgozva, de jelenleg csak adatbázisban dolzozik
        public static void InitializeConnections(bool database)
        {
            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
        }

        public static string ConnString(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
