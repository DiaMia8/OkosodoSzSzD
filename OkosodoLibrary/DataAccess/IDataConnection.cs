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


        /// <summary>
        /// Matematiakai játékhoz lekérdezi az összes feladatot
        /// </summary>
        /// <returns>matematikai feladatok lista</returns>
        List<MatematikaiModel> GetAllMatematikaiFeladat();


        /// <summary>
        /// Abc gyakorló feladatok lekérdezése
        /// </summary>
        /// <returns>ABC lista</returns>
        List<AbcModel> GetAllAbcFeladat();


        /// <summary>
        /// Megoldott feladatokat elmenti az adatbázisba
        /// </summary>
        /// <param name="model"></param>
        /// <returns>MegoldottFeladatok model</returns>
        MegoldottFeladatokModel CreateMegoldottFeladatokModel(MegoldottFeladatokModel model);


        /// <summary>
        /// Lekérdezi statisztikához a diák becenevét
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>string</returns>
        string GetDiakBeceNev(int ID);


        /// <summary>
        /// Lekérdezi statisztikához az összesen megoldott feladatok számát
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        int GetOsszesMegoldott(int ID);


        /// <summary>
        /// Lekérdezi statisztikához az összes megoldott matematikai feladat számát
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        int GetOsszesMegoldottMatematikai(int ID);


        /// <summary>
        /// Lekérdezi statisztikához az összes helyesen megoldott matematikai feladat számát
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        int GetOsszesHelyesMatematikai(int ID);


        /// <summary>
        /// Lekérdezi statisztikához az összes megoldott abc feladat számát
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        int GetOsszesMegoldottAbc(int ID);


        /// <summary>
        /// Lekérdezi statisztikához az összes helyesen megoldott abc feladat számát
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        int GetHelyesAbc(int ID);


        /// <summary>
        /// Lekérdezi statisztikához az összes pontot amit a tanuló eddig elért
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        int GetOsszPontSzam(int ID);


        /// <summary>
        /// Megvizsgálja, hogy van-e a diáknak megoldott feladata
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        bool VanMegoldottFeladat(int ID);
    }
}
