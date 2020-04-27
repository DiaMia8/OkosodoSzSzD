using Dapper;
using OkosodoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.DataAccess
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
            //csak addig tartja nyitva az sql kapcsolatot, amíg tartanak a kapcsos zárójelek a using-ban, minden alkalommal újra nyitja a kapcsolatot
 
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("Okosodo")))
            {
                var p = new DynamicParameters();
                p.Add("@Vezetek_nev", model.VezetekNev);
                p.Add("@Kereszt_nev", model.KeresztNev);
                p.Add("@Becenev", model.Becenev);
                p.Add("@Szuletett", model.SzuletesiDatum);
                p.Add(@"Szulo_neve", model.SzuloNeve);
                p.Add("@Szulo_email", model.SzuloEmail);
                p.Add("@Admin_id", model.Admin_Id);
                p.Add("@Keszfeladat_id", 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
                p.Add("@Pont", model.Pont);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTanulo_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }
    }
}
