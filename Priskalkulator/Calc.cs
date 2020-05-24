using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Takster oppdatert:
 * 06.05.2020
 */
namespace Priskalkulator
{
    class Calc
    {
        // Agder Taxi
        public class At
        {
            // Kilometer før takst brytes til lavtakst.
            static readonly float sealing = 30;
            public class Dag
            {
                static readonly float startL = 73f;
                static readonly float startM = 111f;
                static readonly float startS = 147f;
                static readonly float kmL = 14.55f;
                static readonly float kmM = 25.7f;
                static readonly float kmS = 37f;
                static readonly float kmOverM = 20.8f;
                static readonly float kmOverS = 29.6f;
                static readonly float tid = 8.35f;
                static readonly float minL = 122f;
                static readonly float minM = 182f;
                static readonly float minS = 242f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float sv = ((km + frem) * kmL) + (min * tid) + startL;
                    if (sv < minL)
                        sv = minL;
                    return sv + til;
                }

                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmM) + (min * tid) + startM;
                    if (km > sealing)
                        sv = (sealing * kmM) + (over * kmOverM) + (min * tid) + startM;
                    if (sv < minM)
                        sv = minM;
                    return sv + til;
                }

                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmS) + (min * tid) + startS;
                    if (km > sealing)
                        sv = (sealing * kmS) + (over * kmOverS) + startS;
                    if (sv < minS)
                        sv = minS;
                    return sv + til;
                }
            }

            public class Kveld
            {
                static readonly float startL = 95f;
                static readonly float startM = 144f;
                static readonly float startS = 191f;
                static readonly float kmL = 18.95f;
                static readonly float kmM = 33.4f;
                static readonly float kmS = 48.1f;
                static readonly float kmOverM = 27.1f;
                static readonly float kmOverS = 38.5f;
                static readonly float tid = 10.9f;
                static readonly float minL = 158f;
                static readonly float minM = 237f;
                static readonly float minS = 314f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float sv = ((km + frem) * kmL) + (min * tid) + startL;
                    if (sv < minL)
                        sv = minL;
                    return sv + til;
                }

                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmM) + (min * tid) + startM;
                    if (km > sealing)
                        sv = (sealing * kmM) + (over * kmOverM) + (min * tid) + startM;
                    if (sv < minM)
                        sv = minM;
                    return sv + til;
                }

                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmS) + (min * tid) + startS;
                    if (km > sealing)
                        sv = (sealing * kmS) + (over * kmOverS) + startS;
                    if (sv < minS)
                        sv = minS;
                    return sv + til;
                }

            }

            public class Hellig
            {
                static readonly float startL = 111f;
                static readonly float startM = 166f;
                static readonly float startS = 220f;
                static readonly float kmL = 21.85f;
                static readonly float kmM = 38.6f;
                static readonly float kmS = 55.5f;
                static readonly float kmOverM = 31.25f;
                static readonly float kmOverS = 44.4f;
                static readonly float tid = 12.55f;
                static readonly float minL = 183f;
                static readonly float minM = 273f;
                static readonly float minS = 363f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float sv = ((km + frem) * kmL) + (min * tid) + startL;
                    if (sv < minL)
                        sv = minL;
                    return sv + til;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmM) + (min * tid) + startM;
                    if (km > sealing)
                        sv = (sealing * kmM) + (over * kmOverM) + (min * tid) + startM;
                    if (sv < minM)
                        sv = minM;
                    return sv + til;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmS) + (min * tid) + startS;
                    if (km > sealing)
                        sv = (sealing * kmS) + (over * kmOverS) + startS;
                    if (sv < minS)
                        sv = minS;
                    return sv + til;
                }
            }
        }
        // Vennesla Taxi
        public class Vt
        {
            // Kilometer før takst brytes til lavtakst.
            static readonly float sealing = 30;
            public class Dag
            {
                static readonly float startL = 72f;
                static readonly float startM = 108f;
                static readonly float startS = 144f;
                static readonly float kmL = 13.55f;
                static readonly float kmM = 23.8f;
                static readonly float kmS = 35f;
                static readonly float kmOverM = 19f;
                static readonly float kmOverS = 27.2f;
                static readonly float tid = 8.75f;
                static readonly float minL = 119f;
                static readonly float minM = 179f;
                static readonly float minS = 238f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float sv = ((km + frem) * kmL) + (min * tid) + startL;
                    if (sv < minL)
                        sv = minL;
                    return sv + til;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmM) + (min * tid) + startM;
                    if (km > sealing)
                        sv = (sealing * kmM) + (over * kmOverM) + (min * tid) + startM;
                    if (sv < minM)
                        sv = minM;
                    return sv + til;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmS) + (min * tid) + startS;
                    if (km > sealing)
                        sv = (sealing * kmS) + (over * kmOverS) + startS;
                    if (sv < minS)
                        sv = minS;
                    return sv + til;
                }           

            }
            public class Kveld
            {
                static readonly float startL = 94f;
                static readonly float startM = 141f;
                static readonly float startS = 188f;
                static readonly float kmL = 17.55f;
                static readonly float kmM = 30.95f;
                static readonly float kmS = 45.55f;
                static readonly float kmOverM = 24.7f;
                static readonly float kmOverS = 36.5f;
                static readonly float tid = 11.35f;
                static readonly float minL = 155f;
                static readonly float minM = 232f;
                static readonly float minS = 309f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float sv = ((km + frem) * kmL) + (min * tid) + startL;
                    if (sv < minL)
                        sv = minL;
                    return sv + til;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmM) + (min * tid) + startM;
                    if (km > sealing)
                        sv = (sealing * kmM) + (over * kmOverM) + (min * tid) + startM;
                    if (sv < minM)
                        sv = minM;
                    return sv + til;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmS) + (min * tid) + startS;
                    if (km > sealing)
                        sv = (sealing * kmS) + (over * kmOverS) + startS;
                    if (sv < minS)
                        sv = minS;
                    return sv + til;
                }

            }
            public class Helg
            {
                static readonly float startL = 101f;
                static readonly float startM = 152f;
                static readonly float startS = 202f;
                static readonly float kmL = 18.95f;
                static readonly float kmM = 33.3f;
                static readonly float kmS = 49f;
                static readonly float kmOverM = 26.6f;
                static readonly float kmOverS = 39.35f;
                static readonly float tid = 12.25f;
                static readonly float minL = 166f;
                static readonly float minM = 250f;
                static readonly float minS = 333f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float sv = ((km + frem) * kmL) + (min * tid) + startL;
                    if (sv < minL)
                        sv = minL;
                    return sv + til;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmM) + (min * tid) + startM;
                    if (km > sealing)
                        sv = (sealing * kmM) + (over * kmOverM) + (min * tid) + startM;
                    if (sv < minM)
                        sv = minM;
                    return sv + til;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmS) + (min * tid) + startS;
                    if (km > sealing)
                        sv = (sealing * kmS) + (over * kmOverS) + startS;
                    if (sv < minS)
                        sv = minS;
                    return sv + til;
                }

            }
            public class Holy
            {
                static readonly float startL = 108f;
                static readonly float startM = 163f;
                static readonly float startS = 216f;
                static readonly float kmL = 20.3f;
                static readonly float kmM = 35.7f;
                static readonly float kmS = 52.55f;
                static readonly float kmOverM = 28.5f;
                static readonly float kmOverS = 42.15f;
                static readonly float tid = 13.1f;
                static readonly float minL = 179f;
                static readonly float minM = 269f;
                static readonly float minS = 356f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float sv = ((km + frem) * kmL) + (min * tid) + startL;
                    if (sv < minL)
                        sv = minL;
                    return sv + til;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmM) + (min * tid) + startM;
                    if (km > sealing)
                        sv = (sealing * kmM) + (over * kmOverM) + (min * tid) + startM;
                    if (sv < minM)
                        sv = minM;
                    return sv + til;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv = ((km + frem) * kmS) + (min * tid) + startS;
                    if (km > sealing)
                        sv = (sealing * kmS) + (over * kmOverS) + startS;
                    if (sv < minS)
                        sv = minS;
                    return sv + til;
                }

            }

        }

        public class Mt
        {
            // Kilometer før takst brytes til høytakst.
            static readonly float sealing = 10;
            public class Dag
            {
                static readonly float startL = 49f;
                static readonly float startM = 91f;
                static readonly float startS = 106f;
                static readonly float kmL = 10.5f;
                static readonly float kmM = 16.71f;
                static readonly float kmS = 24.89f;
                static readonly float kmOverL = 18.5f;
                static readonly float kmOverM = 30.08f;
                static readonly float kmOverS = 41.94f;
                static readonly float tid = 7.3f;
                static readonly float minL = 111f;
                static readonly float minM = 166f;
                static readonly float minS = 220f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startL + (sealing * kmL) + (over * kmOverL) + (frem * kmL) + (min * tid);
                    else
                        sv = startL + (km * kmL) + (frem * kmL) + (min * tid);
                    if (sv < minL)
                        sv = minL;
                    return sv;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startM + (sealing * kmM) + (over * kmOverM) + (frem * kmM) + (min * tid);
                    else
                        sv = startM + (km * kmM) + (frem * kmM) + (min * tid);
                    if (sv < minM)
                        sv = minM;
                    return sv;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startS + (sealing * kmS) + (over * kmOverS) + (frem * kmS) + (min * tid);
                    else
                        sv = startS + (km * kmS) + (frem * kmS) + (min * tid);
                    if (sv < minS)
                        sv = minS;
                    return sv;
                }
            }
            public class Kveld
            {
                static readonly float startL = 59f;
                static readonly float startM = 110f;
                static readonly float startS = 127f;
                static readonly float kmL = 12.7f;
                static readonly float kmM = 20.22f;
                static readonly float kmS = 28.18f;
                static readonly float kmOverL = 22.4f;
                static readonly float kmOverM = 36.4f;
                static readonly float kmOverS = 50.73f;
                static readonly float tid = 530 / 60f;
                static readonly float minL = 134f;
                static readonly float minM = 202f;
                static readonly float minS = 267f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startL + (sealing * kmL) + (over * kmOverL) + (frem * kmL) + (min * tid);
                    else
                        sv = startL + (km * kmL) + (frem * kmL) + (min * tid);
                    if (sv < minL)
                        sv = minL;
                    return sv;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startM + (sealing * kmM) + (over * kmOverM) + (frem * kmM) + (min * tid);
                    else
                        sv = startM + (km * kmM) + (frem * kmM) + (min * tid);
                    if (sv < minM)
                        sv = minM;
                    return sv;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startS + (sealing * kmS) + (over * kmOverS) + (frem * kmS) + (min * tid);
                    else
                        sv = startS + (km * kmS) + (frem * kmS) + (min * tid);
                    if (sv < minS)
                        sv = minS;
                    return sv;
                }
            }
            public class Lørdag
            {
                static readonly float startL = 64f;
                static readonly float startM = 118f;
                static readonly float startS = 138f;
                static readonly float kmL = 13.65f;
                static readonly float kmM = 21.73f;
                static readonly float kmS = 30.28f;
                static readonly float kmOverL = 24.05f;
                static readonly float kmOverM = 39.11f;
                static readonly float kmOverS = 54.5f;
                static readonly float tid = 569.4f / 60f;
                static readonly float minL = 144f;
                static readonly float minM = 216f;
                static readonly float minS = 286f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startL + (sealing * kmL) + (over * kmOverL) + (frem * kmL) + (min * tid);
                    else
                        sv = startL + (km * kmL) + (frem * kmL) + (min * tid);
                    if (sv < minL)
                        sv = minL;
                    return sv;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startM + (sealing * kmM) + (over * kmOverM) + (frem * kmM) + (min * tid);
                    else
                        sv = startM + (km * kmM) + (frem * kmM) + (min * tid);
                    if (sv < minM)
                        sv = minM;
                    return sv;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startS + (sealing * kmS) + (over * kmOverS) + (frem * kmS) + (min * tid);
                    else
                        sv = startS + (km * kmS) + (frem * kmS) + (min * tid);
                    if (sv < minS)
                        sv = minS;
                    return sv;
                }
            }
            public class Helg
            {
                static readonly float startL = 66f;
                static readonly float startM = 122f;
                static readonly float startS = 144f;
                static readonly float kmL = 14.2f;
                static readonly float kmM = 22.56f;
                static readonly float kmS = 31.44f;
                static readonly float kmOverL = 24.45f;
                static readonly float kmOverM = 40.62f;
                static readonly float kmOverS = 56.61f;
                static readonly float tid = 591.3f / 60f;
                static readonly float minL = 150f;
                static readonly float minM = 224f;
                static readonly float minS = 298f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startL + (sealing * kmL) + (over * kmOverL) + (frem * kmL) + (min * tid);
                    else
                        sv = startL + (km * kmL) + (frem * kmL) + (min * tid);
                    if (sv < minL)
                        sv = minL;
                    return sv;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startM + (sealing * kmM) + (over * kmOverM) + (frem * kmM) + (min * tid);
                    else
                        sv = startM + (km * kmM) + (frem * kmM) + (min * tid);
                    if (sv < minM)
                        sv = minM;
                    return sv;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startS + (sealing * kmS) + (over * kmOverS) + (frem * kmS) + (min * tid);
                    else
                        sv = startS + (km * kmS) + (frem * kmS) + (min * tid);
                    if (sv < minS)
                        sv = minS;
                    return sv;
                }
            }
            public class Holy
            {
                static readonly float startL = 71f;
                static readonly float startM = 131f;
                static readonly float startS = 154f;
                static readonly float kmL = 15.25f;
                static readonly float kmM = 24.23f;
                static readonly float kmS = 33.77f;
                static readonly float kmOverL = 26.85f;
                static readonly float kmOverM = 43.62f;
                static readonly float kmOverS = 60.8f;
                static readonly float tid = 635.1f / 60f;
                static readonly float minL = 161f;
                static readonly float minM = 242f;
                static readonly float minS = 320f;
                internal static float Liten(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startL + (sealing * kmL) + (over * kmOverL) + (frem * kmL) + (min * tid);
                    else
                        sv = startL + (km * kmL) + (frem * kmL) + (min * tid);
                    if (sv < minL)
                        sv = minL;
                    return sv;
                }
                internal static float Medium(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startM + (sealing * kmM) + (over * kmOverM) + (frem * kmM) + (min * tid);
                    else
                        sv = startM + (km * kmM) + (frem * kmM) + (min * tid);
                    if (sv < minM)
                        sv = minM;
                    return sv;
                }
                internal static float Stor(float km, float min, float frem, float til)
                {
                    float over = km - sealing;
                    float sv;
                    if (km > sealing)
                        sv = startS + (sealing * kmS) + (over * kmOverS) + (frem * kmS) + (min * tid);
                    else
                        sv = startS + (km * kmS) + (frem * kmS) + (min * tid);
                    if (sv < minS)
                        sv = minS;
                    return sv;
                }
            }
        }
    }
}