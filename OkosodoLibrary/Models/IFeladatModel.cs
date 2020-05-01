using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.Models
{
    public interface IFeladatModel
    {
        /// <summary>
        /// minden feladatnak lesz sorszáma, lehet kiegészül egy típus kóddal
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// feladat neve pl, matekmacis stb...
        /// </summary>
        string Nev { get; set; }


        char Tipus { get; set; }
        /// <summary>
        /// képek elérési útja adatbázisból
        /// </summary>
        string KepUrl { get; set; }

        /// <summary>
        /// a kép alapján egy billentyű lenyomással lehet a következő feladatra lépni, itt található a helyes betű vagy szám
        /// </summary>
        string Megoldas { get; set; }

        /// <summary>
        /// maximális pontszám, alapértelmezett 3 pont lesz
        /// </summary>
        int MaxPont { get; set; }
    }
}
