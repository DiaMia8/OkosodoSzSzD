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
        TanuloModel CreateTanulo(TanuloModel model, int adminId);
        /// <summary>
        /// Bekér egy modelt és visszaad egy admin típusú adatot
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        AdminModel CreateAdmin(AdminModel model);
        /// <summary>
        /// /az összes tanuló lekérdezése
        /// </summary>
        /// <returns></returns>
        List<TanuloModel> GetDiak_All();
        /// <summary>
        /// Egy admin lekérdezése ID alapján
        /// </summary>
        /// <param name="Id">Admin i-ja</param>
        /// <returns>Adminmodel egy példány</returns>
        AdminModel GetOne_Admin(int Id);
        /// <summary>
        /// Egy adminhoz tartozó diákok lekérdezése admin Id alapján
        /// </summary>
        /// <param name="adminId">Admin ID-ja</param>
        /// <returns>tanuló lista</returns>
        List<TanuloModel> GetTanuloByAdminId(int adminId);
        /// <summary>
        /// Egy tanuló lekézdezése ID alapján
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Tanulo egy példánya</returns>
        TanuloModel GetOneTanuloById(int Id);
        /// <summary>
        /// Admin belépés titkosított jelszóátalakítással
        /// </summary>
        /// <param name="felhasznaloNev"></param>
        /// <param name="jelszo"></param>
        /// <returns>az admin id-ja</returns>
        int LoginAdmin(string felhasznaloNev, string jelszo);
        /// <summary>
        /// Random játékhoz lekérdezi az összes feladatot típustól függetlenül
        /// </summary>
        /// <returns>Összes feladat listája</returns>
        List<RandomModel> FeladatGetAll();
    }
}
