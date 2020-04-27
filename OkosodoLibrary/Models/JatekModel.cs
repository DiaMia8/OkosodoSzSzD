using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.Models
{
    public class JatekModel
    {
        /// <summary>
        /// összes feladat, amit a random gyakorló játékhoz tervezek
        /// </summary>
        public List<IFeladatModel> gyujtemeny = new List<IFeladatModel>();

        /// <summary>
        /// Matematikai feladatok gyüjteménye
        /// </summary>
        public List<MatematikaiModel> matematikaiFeladatok = new List<MatematikaiModel>();

        /// <summary>
        /// Logikai feladatok gyüjteménye
        /// </summary>
        public List<LogikaiModel> logikaiFeladatok = new List<LogikaiModel>();

        /// <summary>
        /// Abc gyakorló feladatok gyűjteménye
        /// </summary>
        public List<AbcModel> abcFeladatok = new List<AbcModel>();
    }
}
