using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priskalkulator
{
    class Calculate
    {
        /*
         * INPUTS
         * Taxilag (tl):
         * 1 - Agder
         * 2 - Vennesla
         * 3 - MT
         * 
         * Type takst (tid):
         * 1 - Dagtid
         * 2 - Helg (også kveld i AT)
         * 3 - Hellig
         * 4 - Kveld (MT/VT)
         * 5 - Lørdag (MT)
         * 
         * Størrelse:
         * 1 - Vanlig bil 1-4
         * 2 - Minibuss 5-8
         * 3 - Buss 9-16
         */
        internal static string Price(float tl, float tid, float str, float km, float min, float frem, float til)
        {
            //AGDER TAXI BEREGNING
            if (tl == 1)
            {
                // DAGTID
                if (tid == 1)
                {
                    if (str == 1)
                    {
                        return "TL Agder, Dagtid, Vanlig bil.";
                    }
                    return "TL Agder - Dagtid";
                }
                return "Taxilag Agder";
            }

            if (tl == 2)
            {
                return "Taxilag Vennesla";
            }

            if (tl == 3)
            {
                return "Taxilag Mandal";
            }

            else
            {
                return "Taxilag må fylles ut";
            }
                

        }
    }
}
