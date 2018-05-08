using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeMedia_UNINTER.Utils
{
    public class MathEngine
    {

        public static Decimal calculateMD(List<Decimal> APOLs, Decimal AP, Decimal PD, Decimal PO)
        {
            Decimal n3 = ((APOLs.Sum()) / 5);
            Decimal n4 = (((AP * 4) + (PD * 6))) / 10;
            Decimal MD = ((PO * 30) + (n3*20) + (n4*50)) / 100;
            

            return MD;
        }

        public static Decimal calculateMF(Decimal MD, Decimal EO, Decimal ED)
        {
            Decimal ME = ((EO * 4) + (ED * 6)) / 10;
            Decimal MF = (ME + MD) / 2;
            return MF;
        }

    }
}
