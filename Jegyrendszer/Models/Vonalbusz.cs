using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    public class Vonalbusz : Kozlekedesieszkoz
    {
        public override int arSzamitas(int alapdij, int tavolsag)
        {
            return alapdij + (tavolsag * 30);
        }
    }
}
