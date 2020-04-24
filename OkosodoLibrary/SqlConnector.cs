using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// /Elment egy új tanulót
        /// </summary>
        /// <param name="model">Tanulo információk</param>
        /// <returns>Tanulo adatokat az ID-vel együtt</returns>
        public TanuloModel CreateTanulo(TanuloModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
