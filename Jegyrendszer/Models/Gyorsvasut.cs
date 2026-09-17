using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    public class Gyorsvasut : Kozlekedesieszkoz
    {
        public override int arSzamitas(int alapdij, int tavolsag)
        {
            return (alapdij * 2) + (tavolsag * 50);  
        }
    }
}
