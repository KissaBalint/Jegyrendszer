using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    public class Roller : Kozlekedesieszkoz
    {
        public override int arSzamitas(int alapdij, int tavolsag)
        {
            return tavolsag * 120;
        }
    }
}
