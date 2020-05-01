using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.Models
{
    // lehet nem fog kelleni
    public class RandomModel : IFeladatModel
    {
        ///// <summary>
        ///// összes feladat, amit a random gyakorló játékhoz tervezek
        ///// </summary>
        //public List<IFeladatModel> gyujtemeny = new List<IFeladatModel>();

        ///// <summary>
        ///// Matematikai feladatok gyüjteménye
        ///// </summary>
        //public List<MatematikaiModel> matematikaiFeladatok = new List<MatematikaiModel>();

        ///// <summary>
        ///// Abc gyakorló feladatok gyűjteménye
        ///// </summary>
        //public List<AbcModel> abcFeladatok = new List<AbcModel>();
        public int Id { get; set; }
        public string Nev { get; set; }
        public char Tipus { get; set; }
        public string KepUrl { get; set; }
        public string Megoldas { get; set; }
        public int MaxPont { get; set; }
    }
}
