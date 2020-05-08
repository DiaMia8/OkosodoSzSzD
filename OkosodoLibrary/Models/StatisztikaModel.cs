using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.Models
{
    public class StatisztikaModel
    {
        public string DiakBeceNev { get; set; }

        public int OsszesMegoldott { get; set; }

        public int OsszesMegoldottMatematikai { get; set; }

        public int  OsszesHelyesMatematikai { get; set; }

        public int OsszesMegoldottAbc { get; set; }

        public int OsszesHelyesAbc { get; set; }

        public int OsszPontSzam { get; set; }

        public StatisztikaModel()
        {

        }

        public StatisztikaModel(string becenev, int osszmegoldott, int osszmegoldottmatek, int helyesmatek, int osszmegoldottabc, int helyesabc, int osszpont)
        {
            this.DiakBeceNev = becenev;
            this.OsszesMegoldott = osszmegoldott;
            this.OsszesMegoldottMatematikai = osszmegoldottmatek;
            this.OsszesHelyesMatematikai = helyesmatek;
            this.OsszesMegoldottAbc = osszmegoldottabc;
            this.OsszesHelyesAbc = helyesabc;
            this.OsszPontSzam = osszpont;
        }
    }
}
