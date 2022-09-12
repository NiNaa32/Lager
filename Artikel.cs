using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager
{
    public class Artikel
    {
        private double inköpsPris;
        private int inköpsKvantitet;
        private string tillverkaren;
        private int såldKvantitet;

        // Standardkonstruktör
        public Artikel()
        {
            inköpsPris = 0.0;
            inköpsKvantitet = 0;
            tillverkaren = "";
            såldKvantitet = 0;
        }


        // initieringskonstruktör
        public Artikel(double ip, int ik, string tnamn, int sk)
        {
            inköpsPris = ip;
            inköpsKvantitet = ik;
            tillverkaren = tnamn;
            såldKvantitet = sk;
        }

        public double GetSetPris
        {
            get
            {
                return inköpsPris;
            }
            set
            {
                inköpsPris = value;
            }
        }

        public int GetSetKvantitet
        {
            get
            {
                return inköpsKvantitet;
            }
            set
            {
                inköpsKvantitet = value;
            }
        }

        public string GetSetTillverkaren
        {
            get
            {
                return tillverkaren;
            }
            set
            {
                tillverkaren = value;
            }
        }

        public int GetSetSåldKvantitet
        {
            get
            {
                return såldKvantitet;
            }
            set
            {
                såldKvantitet = value;
            }
        }

        public virtual double BeräknaPriset(double GetSetSåldKvantitet)
        {
            return 0.0;
        }

    }

}
