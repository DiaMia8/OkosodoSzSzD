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

        private const string db = "Okosodo";
        /// <summary>
        /// Elment egy adminisztrátort
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Adminisztrátor ID-val</returns>
        public AdminModel CreateAdmin(AdminModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                var par = new DynamicParameters();
                par.Add("@Felhasznalo_nev", model.FelhasznaloNev);
                par.Add("@Vezetek_nev", model.VezetekNev);
                par.Add("@Kereszt_nev", model.KeresztNev);
                par.Add("@Email", model.Email);
                par.Add("@Jelszo", model.Jelszo);
                par.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAdmin_Insert", par, commandType: CommandType.StoredProcedure);

                model.Id = par.Get<int>("@Id");

                return model;
            }
           
        }

        /// <summary>
        /// /Elment egy új tanulót és elmenti a kapcsoló táblába a tanuló és az admin ID-ját
        /// </summary>
        /// <param name="model">Tanulo információk</param>
        /// <returns>Tanulo adatokat az ID-vel együtt</returns>
        public TanuloModel CreateTanulo(TanuloModel model, int adminId)
        {
            //csak addig tartja nyitva az sql kapcsolatot, amíg tartanak a kapcsos zárójelek a using-ban, minden alkalommal újra nyitja a kapcsolatot
 
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                var par = new DynamicParameters();
                par.Add("@Vezetek_nev", model.VezetekNev);
                par.Add("@Kereszt_nev", model.KeresztNev);
                par.Add("@Becenev", model.Becenev);
                par.Add("@Szuletett", model.SzuletesiDatum);
                par.Add(@"Szulo_neve", model.SzuloNeve);
                par.Add("@Szulo_email", model.SzuloEmail);             
                par.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                
                connection.Execute("dbo.spTanulo_Insert", par, commandType: CommandType.StoredProcedure);

                model.Id = par.Get<int>("@Id");

                var p = new DynamicParameters();
                p.Add("@Admin_id", adminId);
                p.Add("@Diak_id", model.Id);
                
                connection.Execute("dbo.Admin_Diakjai_Insert", p, commandType: CommandType.StoredProcedure);

                

                return model;

            }
        }

        

        public List<TanuloModel> GetDiak_All()
        {
            List<TanuloModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                output = connection.Query<TanuloModel>("dbo.spDiakGetAll").ToList();
            }

            return output;
        }

        public TanuloModel GetOneTanuloById(int Id)
        {
            TanuloModel output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                var par = new DynamicParameters();
                par.Add("@id", Id);
                output = connection.Query<TanuloModel>("dbo.spDiakGetById", par, commandType: CommandType.StoredProcedure).Single();


            }
            return output;
        }

        public AdminModel GetOne_Admin(int Id)
        {
            AdminModel output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                var par = new DynamicParameters();
                par.Add("@id", Id);
                output = connection.Query<AdminModel>("spAdminGetById", par, commandType: CommandType.StoredProcedure).Single();
                
                
            }
            return output;
        }

        public List<TanuloModel> GetTanuloByAdminId(int adminId)
        {
            List<TanuloModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                var par = new DynamicParameters();
                par.Add("@Id", adminId);
                output = connection.Query<TanuloModel>("spDiakGetByAdminId", par, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public int LoginAdmin(string felhasznaloNev, string jelszo)
        {
            int output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                var par = new DynamicParameters();
                par.Add("Felhasznalo_Nev", felhasznaloNev);
                par.Add("Jelszo", jelszo);
                par.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAdminLogin", par, commandType: CommandType.StoredProcedure);

                output = par.Get<int>("@Id");
            }

            return output;
        }

        List<RandomModel> IDataConnection.FeladatGetAll()
        {
            List<RandomModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                output = connection.Query<RandomModel>("dbo.spFeladatGetAll").ToList();
            }

            return output;
        }
    }
}
