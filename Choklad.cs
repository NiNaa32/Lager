using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager
{
    // Härledd klass choklad  
    public class Choklad : Artikel
    {
        public override double BeräknaPriset(double GetSetSåldKvantitet)
        {
            double försäljPris;
            if (GetSetSåldKvantitet < 100)
            {
                försäljPris = base.GetSetPris + base.GetSetPris * 0.2;
            }
            else
            {
                försäljPris = base.GetSetPris + base.GetSetPris * 0.3;
            }

            return försäljPris;
        }
    }

}
