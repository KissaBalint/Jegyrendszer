using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    public abstract class Kozlekedesieszkoz
    {
        public int alapdij;
        public int tavolsag;

        public abstract int arSzamitas(int alapdij, int tavolsag);
    }
}
