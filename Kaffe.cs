using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager
{
    //Härledd klass kaffe
    public class Kaffe : Artikel
    {
        public override double BeräknaPriset(double GetSetSåldKvantitet)
        {
            double försäljPris;
            if (GetSetSåldKvantitet < 500)
            {
                försäljPris = base.GetSetPris + base.GetSetPris * 0.15;
            }
            else
            {
                försäljPris = base.GetSetPris + base.GetSetPris * 0.25;
            }

            return försäljPris;
        }
    }

}
