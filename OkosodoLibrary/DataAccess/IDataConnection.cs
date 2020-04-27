using OkosodoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        /// /Bekér egy modelt és vissza ad egy TanuloModel típusú adathalmazt
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        TanuloModel CreateTanulo(TanuloModel model);
    }
}
