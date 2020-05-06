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
        
        public int Id { get; set; }
        public string Nev { get; set; }
        public char Tipus { get; set; }
        public string KepUrl { get; set; }
        public string Megoldas { get; set; }
        public int MaxPont { get; set; }
    }
}
