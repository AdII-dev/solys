using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solys
{
    internal class Adat
    {
        public string Bolygo {get; set;}
        public int HoldSzam { get; set;}
        public double BolygTerfog { get; set;}

        public Adat(string sor)
        {
            var m = sor.Split(';');
            Bolygo = m[0];
            HoldSzam = Convert.ToInt32(m[1]);
            if (m[2].Contains('.')) BolygTerfog = double.Parse(m[2].Replace('.', ','));
        }

    }
}
