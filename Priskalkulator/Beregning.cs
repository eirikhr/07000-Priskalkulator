using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priskalkulator
{
    class Calc
    {
        internal static float AtDagLiten(float km, float tid, float til)
        {
            float sv = (km * PriserAgder.kmDagL) + (tid * PriserAgder.TidDag) + PriserAgder.startDagL;

            if (sv < PriserAgder.minDagL)
                sv = PriserAgder.minDagL;
            return sv + til;
        }

        internal static float AtHelgLiten(float km, float tid, float til)
        {
            float sv = (km * PriserAgder.kmHelgL) + (tid * PriserAgder.TidHelg) + PriserAgder.startHelgL;

            if (sv < PriserAgder.minHelgL)
                sv = PriserAgder.minHelgL;
            return sv + til;
        }
        internal static float AtHolyLiten(float km, float tid, float til)
        {
            float sv = (km * PriserAgder.kmHolyL) + (tid * PriserAgder.TidHoly) + PriserAgder.startHolyL;

            if (sv < PriserAgder.minHolyL)
                sv = PriserAgder.minHolyL;
            return sv + til;
        }

        internal static float AtDagMedium(float km, float tid, float til)
        {
            float over = km - 30;
            float sv = (km * PriserAgder.kmDagM) + (tid * PriserAgder.TidDag) + PriserAgder.startDagM;
            float svlang = (30 * PriserAgder.kmDagM) + (tid * PriserAgder.TidDag) + (over * PriserAgder.kmOverDagM) + PriserAgder.startDagM;

            if (svlang < sv)
                sv = svlang;
            if (sv < PriserAgder.minDagM)
                sv = PriserAgder.minDagM;
            return sv + til;
        }
        /**
        internal static float AtDagMedium(float km, float tid, float til)
        {
            float over = km - 30;
            float sv = (km * PriserAgder.kmDagM) + (tid * PriserAgder.TidDag) + PriserAgder.startDagM;
            float svlang = (30 * PriserAgder.kmDagM) + (tid * PriserAgder.TidDag) + (over * PriserAgder.kmOverDagM) + PriserAgder.startDagM;

            if (svlang < sv)
                sv = svlang;
            if (sv < PriserAgder.minDagM)
                sv = PriserAgder.minDagM;
            return sv + til;
        }

        internal static float AtDagMedium(float km, float tid, float til)
        {
            float over = km - 30;
            float sv = (km * PriserAgder.kmDagM) + (tid * PriserAgder.TidDag) + PriserAgder.startDagM;
            float svlang = (30 * PriserAgder.kmDagM) + (tid * PriserAgder.TidDag) + (over * PriserAgder.kmOverDagM) + PriserAgder.startDagM;

            if (svlang < sv)
                sv = svlang;
            if (sv < PriserAgder.minDagM)
                sv = PriserAgder.minDagM;
            return sv + til;
        }

        internal static float AtDagMedium(float km, float tid, float til)
        {
            float over = km - 30;
            float sv = (km * PriserAgder.kmDagM) + (tid * PriserAgder.TidDag) + PriserAgder.startDagM;
            float svlang = (30 * PriserAgder.kmDagM) + (tid * PriserAgder.TidDag) + (over * PriserAgder.kmOverDagM) + PriserAgder.startDagM;

            if (svlang < sv)
                sv = svlang;
            if (sv < PriserAgder.minDagM)
                sv = PriserAgder.minDagM;
            return sv + til;
        }
        */

    }
}
