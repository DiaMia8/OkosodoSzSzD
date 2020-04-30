using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosodoLibrary.Models
{
    class MegoldottFeladatokModel
    {
        public int Id { get; set; }

        public int DiakId { get; set; }

        public int FeladatId { get; set; }

        public int ElertPont { get; set; }

        public bool Megoldott { get; set; }

        public MegoldottFeladatokModel()
        {

        }

        public MegoldottFeladatokModel(int diakId, int feladatId, int elertpont, bool megoldott)
        {
            DiakId = diakId;
            FeladatId = feladatId;
            ElertPont = elertpont;
            Megoldott = megoldott;
        }
    }
}
