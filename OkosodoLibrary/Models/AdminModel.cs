using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.Models
{
    public class AdminModel
    {
        /// <summary>
        /// Adminisztráló felhasználó neve
        /// </summary>
        public string FelhasznaloNev { get; set; }
        /// <summary>
        /// Adminisztráló neve vezetéknév
        /// </summary>
        public string VezetekNev { get; set; }

        /// <summary>
        /// Adminisztráló kereszt neve
        /// </summary>
        public string KeresztNev { get; set; }

        /// <summary>
        /// adminisztráló email címe - validálás nélkül
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// jelszó, validálást és biztonsági funkciókat megcsinálni
        /// </summary>
        public string Jelszo { get; set; }

        /// <summary>
        /// Adatbázis kapcsolathoz, automatikus generálst megcsinálni
        /// </summary>
        public int Id { get; set; }

        public AdminModel()
        {

        }

        public AdminModel(string felhasznaloNev, string vezetekNev, string keresztNev, string email, string jelszo)
        {
            FelhasznaloNev = felhasznaloNev;
            VezetekNev = vezetekNev;
            KeresztNev = keresztNev;
            Email = email;
            Jelszo = jelszo;
        }

    }
}
