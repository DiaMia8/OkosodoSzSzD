using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.Models
{
    public class TanuloModel
    {
        /// <summary>
        /// Egyedi azonosító
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// tanuló vezetékneve
        /// </summary>C:\Users\diana\Desktop\Okosodo\OkosodoLibrary\Models\TanuloModel.cs
        public string VezetekNev { get; set; }

        /// <summary>
        /// tanuló keresztneve
        /// </summary>
        public string KeresztNev { get; set; }

        /// <summary>
        /// választható becenév, erre referálni a saját formján
        /// </summary>
        public string Becenev { get; set; }

        /// <summary>
        /// szülő teljes neve, egy változóban 
        /// </summary>
        public string SzuloNeve { get; set; }

        /// <summary>
        /// szülő email címe - eredményeket ide lehet triggerelni
        /// </summary>
        public string SzuloEmail { get; set; }

        /// <summary>
        /// Diák születési dátuma
        /// </summary>
        public  DateTime SzuletesiDatum { get; set; }
        

        public TanuloModel()
        {

        }

        //adatbázisba mentéshez használt konstruktor
        public TanuloModel(string vezeteknev, string keresztnev, string becenev, string szuloneve, string szuloemail, DateTime szuletett, int pont)
        {
            VezetekNev = vezeteknev;
            KeresztNev = keresztnev;
            Becenev = becenev;
            SzuloNeve = szuloneve;
            SzuloEmail = szuloemail;
            SzuletesiDatum = szuletett;
            
        }
    }
}
