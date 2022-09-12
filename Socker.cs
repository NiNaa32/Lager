using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager
{
    // Härledd klass Socker
    public class Socker : Artikel
    {

        public override double BeräknaPriset(double GetSetSåldKvantitet)
        {
            double försäljPris;
            försäljPris = base.GetSetPris + base.GetSetPris * 0.2;
            return försäljPris;
        }
    }

}
